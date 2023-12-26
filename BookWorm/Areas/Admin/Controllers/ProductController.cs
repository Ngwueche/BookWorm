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
        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.categoryRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                })
            };
            //create
            if (id == null || id == 0) { return View(productVM); }

            else
            {
                //update

                var product = _unitOfWork.productRepository.Get(u => u.Id == id);
                if (product == null) return NotFound();
                productVM.Title = product.Title;
                productVM.Description = product.Description;
                productVM.ISBN = product.ISBN.ToUpper();
                productVM.Author = product.Author;
                productVM.ListPrice = product.ListPrice;
                productVM.Price = product.Price;
                productVM.Price50 = product.Price50;
                productVM.Price100 = product.Price100;
                productVM.CategoryId = product.CategoryId;
                productVM.ImageUrl = product.ImageUrl;
                return View(productVM);

            }


        }

        [HttpPost]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
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

                // Check if it's an update by checking if productVM.Id is not zero
                if (productVM.Id != 0)
                {
                    // If it's an update, retrieve the existing product from the database
                    var existingProduct = _unitOfWork.productRepository.Get(u => u.Id == productVM.Id);

                    // Check if the existing product is found
                    if (existingProduct == null) return NotFound();

                    // Update properties of the existing product
                    existingProduct.Title = newProduct.Title;
                    existingProduct.Description = newProduct.Description;
                    existingProduct.ISBN = newProduct.ISBN;
                    existingProduct.Author = newProduct.Author;
                    existingProduct.ListPrice = newProduct.ListPrice;
                    existingProduct.Price = newProduct.Price;
                    existingProduct.Price50 = newProduct.Price50;
                    existingProduct.Price100 = newProduct.Price100;
                    existingProduct.CategoryId = newProduct.CategoryId;
                    existingProduct.ImageUrl = newProduct.ImageUrl;

                    _unitOfWork.productRepository.Update(existingProduct);
                }
                else
                {
                    // It's a new product, add it to the repository
                    _unitOfWork.productRepository.Add(newProduct);
                }

                _unitOfWork.Save();
                TempData["Success"] = "Item Saved Successfully";
                return RedirectToAction("Index");
            }

            // ModelState is not valid, so we need to populate the CategoryList before returning to the view
            productVM.CategoryList = _unitOfWork.categoryRepository.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(productVM);
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
