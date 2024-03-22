using InternetStore.Core.Enums;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Configuration
{
	public class PermissionConfiguration : IEntityTypeConfiguration<PermissionEntity>
	{
		public void Configure(EntityTypeBuilder<PermissionEntity> builder)
		{
			builder.HasKey(x => x.Id);

			var permissions = Enum
				.GetValues<Permission>()
				.Select(x => new PermissionEntity
				{
					Id = (int)x,
					Name = x.ToString()
				});

			builder.HasData(permissions);
		}
	}

}
