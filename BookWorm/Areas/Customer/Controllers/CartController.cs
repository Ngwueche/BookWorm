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
            ShoppingCartList = _unitOfWork.shoppingCartRepository.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product")
        };
        foreach (var cart in CartVM.ShoppingCartList)
        {
            cart.Price = GetPriceBasedOnQuantity(cart);
            CartVM.OrderTotal += (cart.Price * cart.Count);
        }
        return View(CartVM);
    }
    public IActionResult Plus(int cartId)
    {
        var cartFromDb = _unitOfWork.shoppingCartRepository.Get(u => u.Id == cartId);
        cartFromDb.Count += 1;
        _unitOfWork.shoppingCartRepository.Update(cartFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Minus(int cartId)
    {
        var cartFromDb = _unitOfWork.shoppingCartRepository.Get(u => u.Id == cartId);
        if (cartFromDb.Count <= 1)
        {
            //remove from cart
            _unitOfWork.shoppingCartRepository.Remove(cartFromDb);
        }
        else
        {
            cartFromDb.Count -= 1;
            _unitOfWork.shoppingCartRepository.Update(cartFromDb);
        }
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Delete(int cartId)
    {
        var cartFromDb = _unitOfWork.shoppingCartRepository.Get(u => u.Id == cartId);
        _unitOfWork.shoppingCartRepository.Remove(cartFromDb);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Summary()
    {
        return View();
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
