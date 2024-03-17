﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Entities
{
	public class UserEntity
	{
		public Guid Id { get; set; }
		public string UserName { get;  set; }
		public string PasswordHash { get;  set; }
		public string Email { get;  set; }
	}
}
