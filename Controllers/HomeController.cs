using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tyler_Assignment1.Models;

namespace Tyler_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // Controller for the Index and Grade Calculator pages
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("GradeCalculator")]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        // Pass the GradeCalculatorModel page through
        [HttpPost("GradeCalculator")]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
