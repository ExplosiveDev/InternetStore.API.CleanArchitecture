using AutoMapper;
using InternetStore.API.Contracts;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Entities;

namespace InternetStore.API.Mapper
{
	public class ContractsMapping : Profile
	{
        public ContractsMapping()
        {
            CreateMap<Product, ProductsResponse>();
            CreateMap<ProductsRequest, Product>();

		}
    }
}
