using InternetStore.Core.Models;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Core.Enums;

namespace IntetnetStore.DataAccess.Configuration
{
	public class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
	{
		public void Configure(EntityTypeBuilder<RoleEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasMany(r => r.Permissions)
				.WithMany(p => p.Roles)
				.UsingEntity<RolePermissionEntity>(
					l => l.HasOne<PermissionEntity>().WithMany().HasForeignKey(e => e.PermissionId),
					r => r.HasOne<RoleEntity>().WithMany().HasForeignKey(e => e.RoleId));

			var roles = Enum
				.GetValues<Role>()
				.Select(x => new RoleEntity
				{
					Id = (int)x,
					Name = x.ToString()
				});

			builder.HasData(roles);
		}
	}
}
