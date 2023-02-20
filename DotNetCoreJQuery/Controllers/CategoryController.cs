using DotNetCoreJQuery.Data;
using DotNetCoreJQuery.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreJQuery.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAllcategory()
        {
            CategoryInfoModel model = new CategoryInfoModel();
            model.CategoryList = _context.Categories.ToList();


            return Json(model);
        }
    }
}
