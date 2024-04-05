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
            CreateMap<ProductEntity, Product>().ReverseMap();
			CreateMap<CategoryEntity, Category>().ReverseMap();
			CreateMap<BrandEntity, Brand>().ReverseMap();

			CreateMap<ProductInBasketEntity, ProductInBasket>().ReverseMap();
			CreateMap<BasketEntity, Basket>().ReverseMap();

		}
    }
}
