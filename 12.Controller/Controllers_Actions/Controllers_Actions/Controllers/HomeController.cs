using Microsoft.AspNetCore.Mvc;

namespace Controllers_Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            
            
        {

            ViewData["data1"] = "View data";
            ViewBag.data2 = "ViewBag data";
            TempData["data3"] = "Temp Data";


            //VieBag example
            //    ViewBag.data1 = "crazyFact";
            //    ViewBag.data2 = "24";
            //    ViewBag.data2 = DateTime.Now.ToShortDateString();
            //    string[] arr = { "prime", "kumar", "singh" };
            //    ViewBag.data4 = arr;
            //    ViewBag.data5 = new List<string>()
            //        {
            //            "Cricket","Football","Hockey"
            //        };





            // ViewData Examples

            //    ViewData["data1"] = "Prashant Kumar";
            //    ViewData["data2"] = 25;
            //    ViewData["data3"] = DateTime.Now.ToLongDateString;

            //    string[] arr = { "prime", "kumar", "singh" };
            //    ViewData["data4"] = arr;

            //    ViewData["data5"] = new List<string>()
            //    {
            //        "Cricket","Football","Hockey"
            //    };
            ViewData["mygame"] = "GTAVI";


            return View();  // ViewResult , PartialViewResult, JasonResult ---
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public int Displayid(int id)
        {
            return id;
        }
    }
}
