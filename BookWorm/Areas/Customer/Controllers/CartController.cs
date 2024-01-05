using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using BookWorm.Models.Models;
using BookWorm.Models.ViewModels;
using BookWorm.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System.Security.Claims;

namespace BookWorm.API.Areas.Customer.Controllers;
[Area("Customer")]
[Authorize]
public class CartController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    [BindProperty]
    public CartVM CartVM { get; set; }
    public CartController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        CartVM = new()
        {
            ShoppingCartList = _unitOfWork.ShoppingCartRepository.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product"),
            OrderHeader = new()
        };
        foreach (var cart in CartVM.ShoppingCartList)
        {
            cart.Price = GetPriceBasedOnQuantity(cart);
            CartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
        }
        return View(CartVM);
    }
    public IActionResult Plus(int cartId)
    {
        var cartFromDb = _unitOfWork.ShoppingCartRepository.Get(u => u.Id == cartId);
        cartFromDb.Count += 1;
        _unitOfWork.ShoppingCartRepository.Update(cartFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Minus(int cartId)
    {
        var cartFromDb = _unitOfWork.ShoppingCartRepository.Get(u => u.Id == cartId);
        if (cartFromDb.Count <= 1)
        {
            //remove from cart
            _unitOfWork.ShoppingCartRepository.Remove(cartFromDb);
        }
        else
        {
            cartFromDb.Count -= 1;
            _unitOfWork.ShoppingCartRepository.Update(cartFromDb);
        }
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Delete(int cartId)
    {
        var cartFromDb = _unitOfWork.ShoppingCartRepository.Get(u => u.Id == cartId);
        _unitOfWork.ShoppingCartRepository.Remove(cartFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Summary()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        CartVM = new()
        {
            ShoppingCartList = _unitOfWork.ShoppingCartRepository.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product"),
            OrderHeader = new()
        };
        CartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUserRepository.Get(u => u.Id == userId);
        CartVM.OrderHeader.Name = CartVM.OrderHeader.ApplicationUser.FirstName;
        //CartVM.OrderHeader.LastName = CartVM.OrderHeader.ApplicationUser.LastName;
        CartVM.OrderHeader.PhoneNumber = CartVM.OrderHeader.ApplicationUser.PhoneNumber;
        CartVM.OrderHeader.StreetAddress = CartVM.OrderHeader.ApplicationUser.StreetAddress;
        CartVM.OrderHeader.City = CartVM.OrderHeader.ApplicationUser.City;
        CartVM.OrderHeader.State = CartVM.OrderHeader.ApplicationUser.State;
        CartVM.OrderHeader.PostalCode = CartVM.OrderHeader.ApplicationUser.PostalCode;
        foreach (var cart in CartVM.ShoppingCartList)
        {
            cart.Price = GetPriceBasedOnQuantity(cart);
            CartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
        }
        return View(CartVM);
    }
    [HttpPost]
    [ActionName("Summary")]
    public IActionResult SummaryPost()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        CartVM.ShoppingCartList = _unitOfWork.ShoppingCartRepository.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product");
        CartVM.OrderHeader.OrderDate = System.DateTime.Now;
        CartVM.OrderHeader.ApplicationUserId = userId;

        ApplicationUser applicationUser = _unitOfWork.ApplicationUserRepository.Get(u => u.Id == userId);

        if (applicationUser.CompanyId.GetValueOrDefault() == 0)
        {
            //Ordinary customer && should pay immediately
            CartVM.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
            CartVM.OrderHeader.OrderStatus = SD.StatusPending;
        }
        else
        {
            //Company account && payment comes after 30days
            CartVM.OrderHeader.PaymentStatus = SD.PaymentStatusDelayedPayment;
            CartVM.OrderHeader.OrderStatus = SD.StatusApproved;
        }
        foreach (var cart in CartVM.ShoppingCartList)
        {
            cart.Price = GetPriceBasedOnQuantity(cart);
            CartVM.OrderHeader.OrderTotal += (cart.Price * cart.Count);
        }
        _unitOfWork.OrderHeaderRepository.Add(CartVM.OrderHeader);
        _unitOfWork.Save();

        //Process OrderDetail
        foreach (var cart in CartVM.ShoppingCartList)
        {
            OrderDetail orderDetail = new()
            {
                ProductId = cart.ProductId,
                OrderHeaderId = CartVM.OrderHeader.Id,
                Price = cart.Price,
                Count = cart.Count,
            };
            _unitOfWork.OrderDetailRepository.Add(orderDetail);
            _unitOfWork.Save();
        }
        if (applicationUser.CompanyId.GetValueOrDefault() == 0)
        {
            //Ordinary customer && should pay immediately
            //stripe payment GateWay integration
            string domain = "https://localhost:7174/";
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = domain + $"customer/cart/OrderConfirmation?id={CartVM.OrderHeader.Id}",
                CancelUrl = domain + $"customer/cart/index",
                LineItems = new List<Stripe.Checkout.SessionLineItemOptions>(),
                Mode = "payment",
            };
            foreach (var item in CartVM.ShoppingCartList)
            {
                SessionLineItemOptions sessionLineItemOptions = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)item.Price * 100,
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Product.Title,
                        }
                    },
                    Quantity = item.Count
                };
                options.LineItems.Add(sessionLineItemOptions);
            }
            var service = new Stripe.Checkout.SessionService();
            Session session = service.Create(options);
            _unitOfWork.OrderHeaderRepository.UpdateStripePaymentId(CartVM.OrderHeader.Id, session.Id, session.PaymentIntentId);
            _unitOfWork.Save();
            Response.Headers.Location = session.Url;
            return new StatusCodeResult(303);
        }
        return RedirectToAction(nameof(OrderConfirmation), new { id = CartVM.OrderHeader.Id });
    }

    public IActionResult OrderConfirmation(int id)
    {
        OrderHeader orderHeader = _unitOfWork.OrderHeaderRepository.Get(u => u.Id == id, includeProperties: "ApplicationUser");
        if (orderHeader.PaymentStatus == SD.PaymentStatusDelayedPayment)
        {
            //This checks for customer payment
            SessionService sessionService = new SessionService();
            Session session = sessionService.Get(orderHeader.SessionId);
            if (session.PaymentStatus.Equals("paid", StringComparison.CurrentCultureIgnoreCase))
            {
                _unitOfWork.OrderHeaderRepository.UpdateStripePaymentId(id, session.Id, session.PaymentIntentId);
                _unitOfWork.OrderHeaderRepository.UpdateStatus(id, SD.StatusApproved, SD.PaymentStatusApproved);
                _unitOfWork.Save();
            }
        };
        List<ShoppingCartVM> shoppingCartVM = _unitOfWork.ShoppingCartRepository.GetAll(u => u.ApplicationUserId == orderHeader.ApplicationUserId).ToList();
        _unitOfWork.ShoppingCartRepository.RemoveRange(shoppingCartVM);
        _unitOfWork.Save();

        return View(id);
    }
    private double GetPriceBasedOnQuantity(ShoppingCartVM shoppingCartVM)
    {
        if (shoppingCartVM.Count <= 50)
        {
            return shoppingCartVM.Product.Price;
        }
        else
        {
            if (shoppingCartVM.Count <= 100)
            {
                return shoppingCartVM.Product.Price50;
            }
            else
            {
                return shoppingCartVM.Product.Price100;
            }
        }
    }
}
