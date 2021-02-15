using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.DTOs.Customer;
using DigitalWare.Core.DTOs.CustomerInvoice;
using DigitalWare.Core.DTOs.CustomerInvoiceConcept;
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
            CreateMap<CustomerInsertDto, Customer>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<ProductInsertDto, Product>();

            CreateMap<StockDto, Stock>();
            CreateMap<Stock, StockDto>();

            CreateMap<StockHistory, StockHistoryDto>();
            CreateMap<StockHistoryDto, StockHistory>();

            CreateMap<CustomerInvoice, CustomerInvoiceDto>();
            CreateMap<CustomerInvoiceDto, CustomerInvoice>();
            CreateMap<CustomerInvoiceInsertDto, CustomerInvoice>();

            CreateMap<CustomerInvoiceConcept, CustomerInvoiceConceptDto>();
            CreateMap<CustomerInvoiceConceptDto, CustomerInvoiceConcept>();
            CreateMap<CustomerInvoiceInsertConceptDto, CustomerInvoiceConcept>();
        }
    }
}