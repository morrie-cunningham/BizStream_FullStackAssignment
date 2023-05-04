using BizStreamFullStackAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.IO;
using System.Text;

namespace BizStreamFullStackAssignment.Controllers
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

        public IActionResult SaveContactForm(ContactForm cf)
        {
            if (ModelState.IsValid)
            {
                string filename = "contactFormInfo_" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".txt";
                string[] contents = { "First Name: " + cf.FName, "Last Name: " + cf.LName, "Email: " + cf.Email, "Message: " + cf.Message };
                System.IO.File.WriteAllLines(filename, contents);
                return RedirectToAction("Success");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Success()
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