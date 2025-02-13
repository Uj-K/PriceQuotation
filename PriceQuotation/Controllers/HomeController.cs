using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Models.PriceQuotation()); 
        }

        [HttpPost]
        public IActionResult Index(Models.PriceQuotation model) 
        {
            if (ModelState.IsValid)
            {
                
                return View(model);
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
