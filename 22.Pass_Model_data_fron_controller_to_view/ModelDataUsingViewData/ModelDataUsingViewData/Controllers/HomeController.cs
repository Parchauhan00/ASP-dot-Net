using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            Employee emp = new Employee()
            {
                EmpId = 101,
                EmpName= "Pru",
                Designation = "Dotnet developer",
                Salary = 32000
            };

            ViewData["myEmployee"] = emp;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
