using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Code.Models;

namespace Code.Controllers
{
    public class EmployerController : Controller
    {
        private readonly ILogger<EmployerController> _logger;

        public EmployerController(ILogger<EmployerController> logger)
        {
            _logger = logger;
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ProDevProg()
        {
            return View();
        }

        public IActionResult PersDevProg()
        {
            return View();
        }

        public IActionResult OnlineProg()
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
