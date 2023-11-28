using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
