using System.Collections.Generic;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public Customer GetById(int id);
        public Customer Create(Customer customer);
        public Customer Update(Customer customer);
    }
}