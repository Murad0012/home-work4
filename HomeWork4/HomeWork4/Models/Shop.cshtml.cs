using HomeWork4.Data;
using HomeWork4.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork4.Models
{
    public class ShopModel
    {
        public List<Product> ?Products { get; set; }
    }
}
