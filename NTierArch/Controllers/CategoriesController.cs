using Microsoft.AspNetCore.Mvc;
using GE = Global.Entity;
using Business.Layer;
using Business.Layer.Interface;

namespace NTierArch.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryBL _category;

        public CategoriesController(ICategoryBL category)
        {
            _category = category;
        }
        public IActionResult Index()
        {
            List<GE::Category> categories = _category.GetCategories();
            return View(categories);
        }
    }
}
