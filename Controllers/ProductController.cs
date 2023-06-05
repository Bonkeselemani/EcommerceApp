using Microsoft.AspNetCore.Mvc;
using E_commerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;

namespace EcommerceApp.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<string> _colors;
        public ProductController()
        {
            
            _colors = new List<string>() { "Red", "Blue", "Yellow" }; ;
        }
        public IActionResult Index()
        {
            TempData["CurrentPages"] = "Products List";
            return View();
        }
        [HttpGet]
        public IActionResult NewProduct()
        {
            ViewBag.Color = new SelectList(_colors);
            TempData["CurrentPages"] = "New Product";
            return View();

        }
        [HttpPost]
        public IActionResult NewProduct(Product product)
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