using InternetStore.Core.Enums;
using InternetStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Abstractions
{
	public interface IUserRepository
	{
		public Task Add(User user);
		public Task<User> GetByEmail(string email);
		public Task<bool> IsUniqueEmail(string email);
	}
}
