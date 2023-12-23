using BookWorm.DataAccess.Data.DTOs;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
        public IActionResult Create(CreateProductRequestDTO createProductRequestDTO)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new Product
                {
                    Title = createProductRequestDTO.Title,
                    Description = createProductRequestDTO.Description,
                    ISBN = createProductRequestDTO.ISBN,
                    Author = createProductRequestDTO.Author,
                    ListPrice = createProductRequestDTO.ListPrice,
                    Price = createProductRequestDTO.Price,
                    Price50 = createProductRequestDTO.Price50,
                    Price100 = createProductRequestDTO.Price100,
                    CategoryId = createProductRequestDTO.CategoryId
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
        public IActionResult Edit(UpdateProductRequestDTO updateProductRequestDTO)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new Product
                {
                    Title = updateProductRequestDTO.Title,
                    Description = updateProductRequestDTO.Description,
                    ISBN = updateProductRequestDTO.ISBN,
                    Author = updateProductRequestDTO.Author,
                    ListPrice = updateProductRequestDTO.ListPrice,
                    Price = updateProductRequestDTO.Price,
                    Price50 = updateProductRequestDTO.Price50,
                    Price100 = updateProductRequestDTO.Price100,
                };
                _unitOfWork.productRepository.Update(newProduct);
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
