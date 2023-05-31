using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
