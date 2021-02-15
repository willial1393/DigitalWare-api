using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface ICustomerRepository
    {
        public PaginateDto<Customer> GetAll(PaginateQueryDto paginateDto);
        public Customer GetById(int id);
        public Customer GetByDocument(string document);
        public Customer Create(Customer customer);
        public Customer Update(Customer customer);
    }
}