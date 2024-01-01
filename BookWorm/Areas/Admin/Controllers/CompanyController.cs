using BookWorm.DataAccess.Repositories.IRepositories;
using BookWorm.Models.Models;
using BookWorm.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookWorm.API.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var getCompanies = _unitOfWork.CompanyRepository.GetAll();
            return View(getCompanies);
        }

        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            CompanyVM companyVM = new();
            //create
            if (id == null || id == 0) { return View(companyVM); }
            else
            {
                //update
                var company = _unitOfWork.CompanyRepository.Get(u => u.Id == id);
                if (company == null) return NotFound();
                companyVM.Name = company.Name;
                companyVM.StreetAddress = company.StreetAddress;
                companyVM.City = company.City;
                companyVM.State = company.State;
                companyVM.PostalCode = company.PostalCode;
                companyVM.PhoneNumber = company.PhoneNumber;
                companyVM.Email = company.Email;
                return View(companyVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(CompanyVM companyVM)
        {
            if (ModelState.IsValid)
            {
                var newCompany = new CompanyUser
                {
                    Id = companyVM.Id,
                    Name = companyVM.Name,
                    StreetAddress = companyVM.StreetAddress,
                    City = companyVM.City,
                    State = companyVM.State,
                    PostalCode = companyVM.PostalCode,

                };

                // Check if it's an update by checking if companyVM.Id is not zero
                if (companyVM.Id != 0)
                {
                    // If it's an update, retrieve the existing company from the database
                    var existingCompany = _unitOfWork.CompanyRepository.Get(u => u.Id == companyVM.Id);

                    // Check if the existing company is found
                    if (existingCompany == null) return NotFound();

                    // Update properties of the existing company
                    existingCompany.Name = companyVM.Name;
                    existingCompany.StreetAddress = companyVM.StreetAddress;
                    existingCompany.City = companyVM.City;
                    existingCompany.State = companyVM.State;
                    existingCompany.PostalCode = companyVM.PostalCode;


                    _unitOfWork.CompanyRepository.Update(existingCompany);
                }
                else
                {
                    // It's a new company, add it to the repository
                    _unitOfWork.CompanyRepository.Add(newCompany);
                }
                _unitOfWork.Save();
                TempData["Success"] = "Company Saved Successfully";
                return RedirectToAction("Index");
            }
            return View(companyVM);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var companies = _unitOfWork.CompanyRepository.GetAll();
            return Json(new { data = companies });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var company = _unitOfWork.CompanyRepository.Get(u => u.Id == id);
            if (company == null) return Json(new { success = false, message = "Error Deleting this company" });

            _unitOfWork.CompanyRepository.Remove(company);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Product deleted successfully" });
        }
        #endregion
    }
}
