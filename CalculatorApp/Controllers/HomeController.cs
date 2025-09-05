using System.Diagnostics;
using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddCalculator()

        { 
            return View();
        }

        [HttpPost]
        public ViewResult AddCalculator(Calc calc)

        { 
            Repository.AddCalculator(calc);
            return View();
        }

        public ViewResult ListCalculators()
        {
            return View(Repository.Calculators);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
