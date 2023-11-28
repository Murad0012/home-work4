using HomeWork4.Data;
using HomeWork4.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork4.Models
{
    public class ShopModel : PageModel
    {
        public List<Product> ?Products { get; set; }
        public void OnGet() => Products = ProductRepository.GetProducts();
    }
}
