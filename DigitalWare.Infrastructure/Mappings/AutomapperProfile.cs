using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.Entities;

namespace DigitalWare.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}