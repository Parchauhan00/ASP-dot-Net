using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class PrashantController1 : Controller
    {
        public IActionResult PrashantMethod()
        {
            return View();
        }

        public int Details(int id)
        {
            return id;
        }

    }
}
