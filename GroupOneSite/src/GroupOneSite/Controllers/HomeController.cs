using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupOneSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Our Team";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Information";

            return View();
        }

        public IActionResult Partners()
        {
            ViewData["Message"] = "Our Partners";

            return View();
        }

        public IActionResult Milestones()
        {
            ViewData["Message"] = "Current Milestones";

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
