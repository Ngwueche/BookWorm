using BookWorm.DataAccess.Data.DTOs;
using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWorm.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitofWork _unitOfWork;
        public CategoryController(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var category = _unitOfWork.categoryRepository.GetAll();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateRequestDTO category)
        {
            if (ModelState.IsValid)
            {
                var newValues = new Category
                {
                    Name = category.Name,
                    DisplayOrder = category.DisplayOrder,
                };

                _unitOfWork.categoryRepository.Add(newValues);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var category = _unitOfWork.categoryRepository.Get(u => u.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.categoryRepository.Update(category);
                _unitOfWork.Save();
                TempData["success"] = "Category Edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var category = _unitOfWork.categoryRepository.Get(u => u.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _unitOfWork.categoryRepository.Remove(category);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");

        }

    }
}
