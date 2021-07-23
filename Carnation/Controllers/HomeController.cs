using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Carnation.Models;
using Microsoft.AspNetCore.Authorization;

namespace Carnation.Controllers
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

        public IActionResult SampleCars()
        {
            return View();
        }
        public IActionResult Company()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Suv()
        {
            return View();
        }

        public IActionResult Compact()
        {
            return View();
        }

        public IActionResult Future()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Custom()
        {
            return View();
        }
        
        public IActionResult Merchant()
        {
            return View();
        }

        public IActionResult Admin()
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
