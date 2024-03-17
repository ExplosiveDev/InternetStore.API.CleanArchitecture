using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.Mapper
{
	public class MapperProfle : AutoMapper.Profile
	{
		public MapperProfle()
		{
			CreateMap<ProductEntity, Product>().ReverseMap();
		}
	}
}
