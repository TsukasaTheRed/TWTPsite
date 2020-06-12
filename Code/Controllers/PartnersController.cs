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
    public class PartnersController : Controller
    {
        private readonly ILogger<PartnersController> _logger;

        public PartnersController(ILogger<PartnersController> logger)
        {
            _logger = logger;
        }

        public IActionResult InternOpportunity()
        {
            return View();
        }

        public IActionResult JoinUs()
        {
            return View();
        }

        public IActionResult OurPartners()
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
