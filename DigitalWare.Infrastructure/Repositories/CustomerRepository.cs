using System.Linq;
using DigitalWare.Core.DTOs.Paginate;
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

        public PaginateDto<Customer> GetAll(PaginateQueryDto paginateDto)
        {
            var res = new PaginateDto<Customer>
            {
                Data = _context.Customers
                    .OrderBy(customer => customer.FirstName)
                    .Skip(paginateDto.Skip)
                    .Take(paginateDto.Take)
                    .ToList()
            };
            if (paginateDto.RequireTotalCount)
            {
                res.TotalCount = _context.Customers.Count();
            }

            return res;
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer GetByDocument(string document)
        {
            return _context.Customers.FirstOrDefault(customer => customer.DocumentNumber == document);
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