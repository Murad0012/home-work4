using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork4.Controllers
{
    public class AboutController : Controller
       {
        public IActionResult About()
        {
            return View();
        }
    }
}
