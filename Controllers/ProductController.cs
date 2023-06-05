using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            TempData["CurrentPages"] = "Products List";
            return View();
        }

        public IActionResult NewProduct()
        {
            TempData["CurrentPages"] = "New Product";
            return View();

        }
    }
}