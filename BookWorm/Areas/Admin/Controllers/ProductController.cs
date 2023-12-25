using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using BookWorm.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookWorm.API.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //Read
        public IActionResult Index()
        {
            var products = _unitOfWork.productRepository.GetAll();

            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> categoryList = _unitOfWork.categoryRepository.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            ProductVM productVM = new ProductVM()
            {
                CategoryList = categoryList,

            };
            return View(productVM);
        }
        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new Product
                {
                    Title = productVM.Title,
                    Description = productVM.Description,
                    ISBN = productVM.ISBN.ToUpper(),
                    Author = productVM.Author,
                    ListPrice = productVM.ListPrice,
                    Price = productVM.Price,
                    Price50 = productVM.Price50,
                    Price100 = productVM.Price100,
                    CategoryId = productVM.CategoryId,
                    ImageUrl = productVM.ImageUrl,
                };
                _unitOfWork.productRepository.Add(newProduct);
                _unitOfWork.Save();
                TempData["Success"] = "Item Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var getProduct = _unitOfWork.productRepository.Get(u => u.Id == id);
            if (getProduct == null) return NotFound();
            return View(getProduct);
        }
        [HttpPost]
        public IActionResult Edit(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                var getProduct = _unitOfWork.productRepository.Get(u => u.Id == productVM.Id);
                getProduct.Title = productVM.Title;
                getProduct.Description = productVM.Description;
                getProduct.ISBN = productVM.ISBN.ToUpper();
                getProduct.Author = productVM.Author;
                getProduct.ListPrice = productVM.ListPrice;
                getProduct.Price = productVM.Price;
                getProduct.Price50 = productVM.Price50;
                getProduct.Price100 = productVM.Price100;
                getProduct.CategoryId = productVM.CategoryId;
                getProduct.ImageUrl = productVM.ImageUrl;

                _unitOfWork.productRepository.Update(getProduct);
                _unitOfWork.Save();
                TempData["Success"] = "Item Updated Suceessfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var getProduct = _unitOfWork.productRepository.Get(u => u.Id == id);
            if (getProduct == null) return NotFound();
            return View(getProduct);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _unitOfWork.productRepository.Remove(product);
            _unitOfWork.Save();
            TempData["Success"] = "Item deleted successully";
            return RedirectToAction("Index");
        }
    }
}
