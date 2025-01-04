using Microsoft.AspNetCore.Mvc;

namespace Controllers_Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
