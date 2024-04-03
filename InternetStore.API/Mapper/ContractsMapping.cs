using AutoMapper;
using InternetStore.API.Contracts;
using InternetStore.Core.Models;

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
