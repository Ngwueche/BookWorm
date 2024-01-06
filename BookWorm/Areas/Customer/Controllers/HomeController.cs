using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using BookWorm.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BookWorm.API.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var products = _unitOfWork.ProductRepository.GetAll(includeProperties: "Category");
            return View(products);
        }
        public IActionResult Details(int? productId)
        {
            var cart = new ShoppingCartVM()
            {
                Product = _unitOfWork.ProductRepository.Get(u => u.Id == productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId
            };
            return View(cart);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCartVM shoppingCartVM)
        {
            //GET THE LOGIN DETAILS OF A USER GLOBALLY
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCartVM.ApplicationUserId = userId;

            ShoppingCartVM cartFromDB = _unitOfWork.ShoppingCartRepository.Get(u => u.ApplicationUserId == userId && u.ProductId == shoppingCartVM.ProductId);
            if (cartFromDB != null)
            {
                //Cart already exists
                cartFromDB.Count += shoppingCartVM.Count;
                _unitOfWork.ShoppingCartRepository.Update(cartFromDB);
                _unitOfWork.Save();
            }
            else
            {
                //Cart does not exist
                _unitOfWork.ShoppingCartRepository.Add(shoppingCartVM);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart, _unitOfWork.ShoppingCartRepository.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart Updated successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
