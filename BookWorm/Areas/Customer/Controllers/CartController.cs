using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using BookWorm.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookWorm.API.Areas.Customer.Controllers;
[Area("Customer")]
[Authorize]
public class CartController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
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
        CartVM.OrderHeader.Name = CartVM.OrderHeader.ApplicationUser.FirstName.ToString() + " " + CartVM.OrderHeader.ApplicationUser.LastName.ToString();
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
