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
    public class ServSuppController : Controller
    {
        private readonly ILogger<ServSuppController> _logger;

        public ServSuppController(ILogger<ServSuppController> logger)
        {
            _logger = logger;
        }

        public IActionResult AdditionalSupp()
        {
            return View();
        }

        public IActionResult GroupStudy()
        {
            return View();
        }

        public IActionResult OnlineMent()
        {
            return View();
        }

        public IActionResult PersonalMent()
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
