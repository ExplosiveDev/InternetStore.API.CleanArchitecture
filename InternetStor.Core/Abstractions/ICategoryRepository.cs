using InternetStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Abstractions
{
	public interface ICategoryRepository
	{
		Task<List<Category>> Get();
	}
}
