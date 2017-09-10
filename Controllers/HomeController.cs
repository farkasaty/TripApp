using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TripApp.Controllers
{
    public class HomeController : Controller
    {
        private ITripRepository db;
        private IConfiguration _config;
        private ILogger<HomeController> _logger;

        public HomeController(IConfiguration config, ITripRepository tripRepository, ILogger<HomeController> logger)
        {
            db = tripRepository;
            _config = config;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError($"There is a bug in your application: {ex.Message}");
            }
            ViewBag.TripCount = db.GetAllTrips().Count();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
