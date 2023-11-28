using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork4.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Shop()
		{
			return View();
		}

		public IActionResult SingleProduct()
		{
			return View();
		}
	}
}
