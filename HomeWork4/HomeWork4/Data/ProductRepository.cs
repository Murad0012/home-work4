using HomeWork4.Entites;

namespace HomeWork4.Data
{
	public class ProductRepository
	{
		public static List<Product> GetProducts()
		{
			return new()
			{
				new()
				{
					Name = "Strawberry",
					Price = "85$",
					ImgName = "product-img-1.jpg"
				},
				new()
				{
					Name = "Berry",
					Price = "70$",
					ImgName = "product-img-2.jpg"
				},
				new()
				{
					Name = "Lemon",
					Price = "35$",
					ImgName = "product-img-3.jpg"
				},
				new()
				{
					Name = "Avocado",
					Price = "50$",
					ImgName = "product-img-4.jpg"
				},
				new()
				{
					Name = "Green Apple",
					Price = "45$",
					ImgName = "product-img-5.jpg"
				},
				new()
				{
					Name = "Strawberry",
					Price = "80$",
					ImgName = "product-img-6.jpg"
				},
			};
		}
	}
}