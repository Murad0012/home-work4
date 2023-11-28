using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork4.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Contact()
		{
			return View();
		}
	}
}
