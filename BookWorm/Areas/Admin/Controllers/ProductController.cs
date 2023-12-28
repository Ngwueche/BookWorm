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
        private readonly IWebHostEnvironment _webHostEnvironment; //provides the root folder
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        //Read
        public IActionResult Index()
        {
            var products = _unitOfWork.productRepository.GetAll(includeProperties: "Category");

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
                productVM.Id = product.Id;
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
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null) //checks if a file exists.
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); //gives the the file a new name
                    string productPath = Path.Combine(wwwRootPath, @"images\product"); //gives the file a path
                    //Delete an existing image if a new one is to be updated
                    if (!string.IsNullOrEmpty(productVM.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, productVM.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    //upload new image
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create)) //saves the file to the path
                    {
                        file.CopyTo(fileStream);
                    }
                    productVM.ImageUrl = @"\images\product\" + fileName;
                }
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
                    existingProduct.Title = productVM.Title;
                    existingProduct.Description = productVM.Description;
                    existingProduct.ISBN = productVM.ISBN;
                    existingProduct.Author = productVM.Author;
                    existingProduct.ListPrice = productVM.ListPrice;
                    existingProduct.Price = productVM.Price;
                    existingProduct.Price50 = productVM.Price50;
                    existingProduct.Price100 = productVM.Price100;
                    existingProduct.CategoryId = productVM.CategoryId;
                    existingProduct.ImageUrl = productVM.ImageUrl;

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
            productVM.CategoryList = _unitOfWork.categoryRepository.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(productVM);
        }
        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0) return NotFound();
        //    var getProduct = _unitOfWork.productRepository.Get(u => u.Id == id);
        //    if (getProduct == null) return NotFound();
        //    return View(getProduct);
        //}
        //[HttpPost]
        //public IActionResult Delete(Product product)
        //{
        //    _unitOfWork.productRepository.Remove(product);
        //    _unitOfWork.Save();
        //    TempData["Success"] = "Item deleted successully";
        //    return RedirectToAction("Index");
        //}

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _unitOfWork.productRepository.GetAll(includeProperties: "Category");
            return Json(new { data = products });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var product = _unitOfWork.productRepository.Get(u => u.Id == id);
            if (product == null) return Json(new { success = false, message = "Error Deleting this product" });
            //Delete an existing image if a new one is to be updated
            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, product.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _unitOfWork.productRepository.Remove(product);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Product deleted successfully" });
        }
        #endregion
    }
}
