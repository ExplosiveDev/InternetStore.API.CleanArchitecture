using AutoMapper;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Mapping
{
	public class DataBaseMapping : Profile
	{
        public DataBaseMapping()
        {
            CreateMap<ProductEntity, Product>();
			CreateMap<CategoryEntity, Category>();
			CreateMap<BrandEntity, Brand>();
		}
    }
}
