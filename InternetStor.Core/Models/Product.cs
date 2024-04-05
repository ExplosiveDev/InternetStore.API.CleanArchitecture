using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternetStore.Core.Models
{
	public class Product
	{
		public const int MAX_NAME_LENGHT = 252;
		public const int MAX_DESCRIPTION_LENGHT = 1024;
        private Product(Guid id, string name, string description, decimal price, string imagePath, int count, Category? category, Guid categoryId, Brand? brand, Guid brandId)
        {
            Id = id; Name = name; 
			Description = description; 
			Price = price; 
			ImagePath = imagePath; 
			Count = count;
			Category = category;
			CategoryId = categoryId;
			Brand = brand;
			BrandId = brandId;
        }
		private Product(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId, Guid brandId)
		{
			Id = id; Name = name;
			Description = description;
			Price = price;
			ImagePath = imagePath;
			Count = count;
			CategoryId = categoryId;
			BrandId = brandId;
		}
		public Guid Id { get; }
		public string Name { get; }
		public string Description { get; }
		public decimal Price { get; }
		public string? ImagePath { get; }
		public int Count { get; }

		public Category Category { get; }
		public Guid CategoryId { get; }
		public Brand? Brand { get; }
		public Guid BrandId { get; }

		public static (Product Product, string Error ) 
			Create(Guid id, string name, string description, decimal price, string imagePath, int count, Category? category, Guid categoryId, Brand? brand, Guid brandId)
		{
			var error = string.Empty;

			if(string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGHT)
				error = "Product name can't be empty or longer then " + MAX_NAME_LENGHT + " characters\n";
			if (string.IsNullOrEmpty(description) || name.Length > MAX_DESCRIPTION_LENGHT)
				error += "Product description can't be empty or longer then " + MAX_DESCRIPTION_LENGHT + " characters\n";
			if (price <= 0)
				error += "Price can't be less than or equal to 0\n";

			var product = new Product(id,name,description,price,imagePath,count,category,categoryId,brand,brandId);

			return (product, error);
		}
		public static (Product Product, string Error)
			CreateWithOutSensetiveData(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId, Guid brandId)
		{
			var error = string.Empty;

			if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGHT)
				error = "Product name can't be empty or longer then " + MAX_NAME_LENGHT + " characters\n";
			if (string.IsNullOrEmpty(description) || name.Length > MAX_DESCRIPTION_LENGHT)
				error += "Product description can't be empty or longer then " + MAX_DESCRIPTION_LENGHT + " characters\n";
			if (price <= 0)
				error += "Price can't be less than or equal to 0\n";

			var product = new Product(id, name, description, price, imagePath, count, categoryId,brandId);

			return (product, error);
		}
	}
}
