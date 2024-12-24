using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("pc")]
        public IActionResult Myhome()
        {
            return View();
        }

        [Route("info")]
        [Route("my")]
        public IActionResult Info()
        {
            return View();
        }
        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id ?? 10;
        }
    }
}
