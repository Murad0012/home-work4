using HomeWork4.Data;
using HomeWork4.Entites;
using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork4.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Shop()
		{
			var product = new ShopModel();
			product.Products = ProductRepository.GetProducts();
			return View(product);
		}

		public IActionResult SingleProduct()
		{
			return View();
		}
	}
}
