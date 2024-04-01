using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Entities;
using System.Collections.Generic;


namespace IntetnetStore.DataAccess.Seeder
{
	public static class SeedData
	{
		public static List<ProductEntity> GetProduct()
		{
			List<ProductEntity> ListProducts = new List<ProductEntity>() {
				new ProductEntity { 
					Id = Guid.NewGuid(),
					Name = "Ноутбук Acer Aspire 7",
					Description = "A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black / AMD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650",
					Price = 28999,
					ImagePath = @"https://content2.rozetka.com.ua/goods/images/big/343096346.jpg",
					Count = 1,
					CategoryId = Guid.Parse("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
					BrandId = Guid.Parse("48be627a-fea0-477f-8682-f9b9725c387b")
				},
				new ProductEntity{
					Id = Guid.NewGuid(),
					Name = "Ноутбук ASUS Laptop",
					Description = "X515EA-BQ2066 (90NB0TY1-M00VF0) Slate Grey / 15.6\" IPS Full HD / Intel Core i3-1115G4 / RAM 12 ГБ / SSD 512 ГБ",
					Price = 16588,
					ImagePath = @"https://content2.rozetka.com.ua/goods/images/big/347802389.jpg",
					Count = 1,
					CategoryId = Guid.Parse("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
					BrandId = Guid.Parse("0bc0af50-0c40-4912-a453-fae84802afe6")
				},
				new ProductEntity{
					Id = Guid.NewGuid(),
					Name = "Ноутбук Lenovo IdeaPad 1",
					Description = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 3 7320U (2.4 - 4.1 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon 610M Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.58 кг / сірий",
					Price = 19999,
					ImagePath = @"https://content1.rozetka.com.ua/goods/images/big/334484472.jpg",
					Count = 1,
					CategoryId = Guid.Parse("b61decb4-84d9-4057-b1e4-d7fb612d1d8f"),
					BrandId = Guid.Parse("46a417c5-5e5f-448c-9811-dd96cfeddf2c")
				},
				new ProductEntity{
					Id = Guid.NewGuid(),
					Name = "Iphone 15 Pro Max",
					Description = "Екран (6.7, OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / основна потрійна камера: 48 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17",
					Price = 52299,
					ImagePath = @"https://content.rozetka.com.ua/goods/images/big/364834229.jpg",
					Count = 1,
					CategoryId = Guid.Parse("7d7dde3b-1176-47fa-86d4-be71afd4ffce"),
					BrandId = Guid.Parse("bf383338-5fab-4845-a5bb-79c7288b4739")
				},
			};
			return ListProducts;
		}

		public static List<CategoryEntity> GetCategory()
		{
			List<CategoryEntity> ListCategories =  new List<CategoryEntity>()
			{
				new CategoryEntity{ Id = Guid.Parse("b61decb4-84d9-4057-b1e4-d7fb612d1d8f") , Name = "Laptop" },
				new CategoryEntity{ Id = Guid.Parse("7d7dde3b-1176-47fa-86d4-be71afd4ffce") , Name = "Smartphone" },
				new CategoryEntity{ Id = Guid.Parse("549343a6-85ce-448d-bd68-dd5c0c5ade0b") , Name = "Electronice" },
			};

			return ListCategories;
		}
		public static List<BrandEntity> GetBrand()
		{
			List<BrandEntity> ListBrands = new List<BrandEntity>()
			{
				new BrandEntity{ Id = Guid.Parse("0bc0af50-0c40-4912-a453-fae84802afe6") , Name = "Asus" },
				new BrandEntity{ Id = Guid.Parse("48be627a-fea0-477f-8682-f9b9725c387b") , Name = "Acer" },
				new BrandEntity{ Id = Guid.Parse("46a417c5-5e5f-448c-9811-dd96cfeddf2c") , Name = "Lenovo" },
				new BrandEntity{ Id = Guid.Parse("bf383338-5fab-4845-a5bb-79c7288b4739") , Name = "Apple" },
			};

			return ListBrands;
		}
	}
}

