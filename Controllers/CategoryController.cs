using E_commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceApp.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult Index()
        {
            TempData["CurrentPages"] = "Category List";
            return View();
        }

        [HttpGet]
        public IActionResult NewCategory()
        {
           
            TempData["CurrentPages"] = "New Category";
            return View();

        }
        [HttpPost]
        public IActionResult NewCategory(Category categoty)
        {
            if (ModelState.IsValid)
            {
                return View("Index");

            }
            else
            {
                return NotFound();
            }



        }
    }
}
