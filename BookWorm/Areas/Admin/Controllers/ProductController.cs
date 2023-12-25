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
                Product = new Product()
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
                    Title = productVM.Product.Title,
                    Description = productVM.Product.Description,
                    ISBN = productVM.Product.ISBN.ToUpper(),
                    Author = productVM.Product.Author,
                    ListPrice = productVM.Product.ListPrice,
                    Price = productVM.Product.Price,
                    Price50 = productVM.Product.Price50,
                    Price100 = productVM.Product.Price100,
                    CategoryId = productVM.Product.CategoryId,
                    ImageUrl = productVM.Product.ImageUrl,
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
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.productRepository.Update(product);
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
