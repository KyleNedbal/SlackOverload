using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IDbConnection db;

        public HomeController(ILogger<HomeController> logger, IDbConnection _db)
        {
            db = _db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username)
        {
            DAL.CurrentUser = username;
            return Redirect("/questions");
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
