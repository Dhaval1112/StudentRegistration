using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Controllers
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

        public IActionResult StudentSignup()
        {
            List<string> Courses = new List<string>();
            Courses.Add("BCA");
            Courses.Add("MCA");
            Courses.Add("MSC.IT");
            ViewBag.dropDown = new SelectList(Courses);

            return View();
        }
        [HttpPost]
        public IActionResult StudentSignup(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                TempData["First_name"] = model.FirstName;
                TempData["Last_name"] = model.LastName;
                TempData["Mobile_number"] = model.MobileNumber;
                TempData["Course"] = model.Course;
                TempData["City"] = model.City;
                TempData["EmailId"] = model.EmailId;
                TempData["Fees"] = model.Fees;
                TempData["Gender"] = model.Gender;

            }    
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
