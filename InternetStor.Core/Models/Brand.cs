using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Models
{
	public class Brand
	{
		public const int MAX_NAME_LENGHT = 252;
		public Brand(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

		public Guid Id { get; }
		public string Name { get; }

		public static (Brand Brand, string Error) Create(Guid id, string name)
		{
			var error = string.Empty;

			if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGHT)
				error = "Brand name can't be empty or longer then " + MAX_NAME_LENGHT + " characters\n";

			var brand = new Brand(id, name);

			return (brand, error);
		}
	}
}
