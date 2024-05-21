﻿using InternetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Entities
{
	public class UserEntity
	{
		public Guid Id { get; set; }
		public string UserName { get;  set; } = string.Empty;
		public string PasswordHash { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;

		public ICollection<RoleEntity> Roles { get; set; } = [];
		public ICollection<ProductEntity> Products { get; set; } = [];
	}
}
