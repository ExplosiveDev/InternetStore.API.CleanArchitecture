using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Models
{
	public class Category
	{
		public const int MAX_NAME_LENGHT = 252;
		public Category(Guid id, string name)
        {
			Id = id;
			Name = name;
        }

        public Guid Id { get; }
		public string Name { get; }

		public static (Category Category, string Error) Create(Guid id, string name)
		{
			var error = string.Empty;

			if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGHT)
				error = "Category name can't be empty or longer then " + MAX_NAME_LENGHT + " characters\n";

			var category = new Category(id, name);

			return (category, error);
		}
	}
}
