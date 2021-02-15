using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.DTOs.Product;
using DigitalWare.Core.Entities;

namespace DigitalWare.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<ProductInsertDto, Product>();

            CreateMap<StockDto, Stock>();
            CreateMap<Stock, StockDto>();
        }
    }
}