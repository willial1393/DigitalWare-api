using System.Collections.Generic;
using System.Linq;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;

namespace DigitalWare.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetClients()
        {
            return _context.Customers.ToList();
        }

        public Customer GetClientById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer Create(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}