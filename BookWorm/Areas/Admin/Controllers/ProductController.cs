using BookWorm.DataAccess.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace BookWorm.API.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        public ProductController(IUnitofWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
