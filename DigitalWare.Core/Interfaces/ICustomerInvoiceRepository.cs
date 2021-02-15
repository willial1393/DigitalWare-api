using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface ICustomerInvoiceRepository
    {
        public PaginateDto<CustomerInvoice> GetAll(PaginateQueryDto paginateDto);
        public CustomerInvoice GetById(int id);
        public CustomerInvoice Create(CustomerInvoice customerInvoice);
        public CustomerInvoice Update(CustomerInvoice customerInvoice);
    }
}