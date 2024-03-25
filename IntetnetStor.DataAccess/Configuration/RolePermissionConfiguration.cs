using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntetnetStore.DataAccess.Entities;
using InternetStore.Core.Enums;

namespace IntetnetStore.DataAccess.Configuration
{
	public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermissionEntity>
	{
		private readonly AuthorizationOption _authorization;

		public RolePermissionConfiguration(AuthorizationOption authorization)
		{
			_authorization = authorization;
		}

		public void Configure(EntityTypeBuilder<RolePermissionEntity> builder)
		{
			builder.HasKey(r => new { r.RoleId, r.PermissionId });

			builder.HasData(ParseRolePermissions());
		}

		private RolePermissionEntity[] ParseRolePermissions()
		{
			return _authorization.RolePermissions
				.SelectMany(rp => rp.Permissions
					.Select(p => new RolePermissionEntity
					{
						RoleId = (int)Enum.Parse<Role>(rp.Role),
						PermissionId = (int)Enum.Parse<Permission>(p)
					}))
					.ToArray();
		}

	}

}
