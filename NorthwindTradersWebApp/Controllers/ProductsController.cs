using Microsoft.AspNetCore.Mvc;

namespace NorthwindTradersWebApp.Controllers
{
    public class ProductsController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
