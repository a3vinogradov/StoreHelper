using Microsoft.AspNetCore.Mvc;

namespace StoreHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
