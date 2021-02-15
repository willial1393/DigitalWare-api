using System;
using System.Linq;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DigitalWare.Infrastructure.Repositories
{
    public class CustomerInvoiceRepository : ICustomerInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerInvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginateDto<CustomerInvoice> GetAll(PaginateQueryDto paginateDto)
        {
            var res = new PaginateDto<CustomerInvoice>
            {
                Data = _context.CustomerInvoices
                    .OrderByDescending(invoice => invoice.Created)
                    .Skip(paginateDto.Skip)
                    .Take(paginateDto.Take)
                    .Include(invoice => invoice.Customer)
                    .ToList()
            };
            if (paginateDto.RequireTotalCount)
            {
                res.TotalCount = _context.CustomerInvoices.Count();
            }

            return res;
        }

        public CustomerInvoice GetById(int id)
        {
            return _context.CustomerInvoices
                .Include(invoice => invoice.Customer)
                .Include(invoice => invoice.Concepts)
                .ThenInclude(concept => concept.Product)
                .FirstOrDefault(invoice => invoice.Id == id);
        }

        public CustomerInvoice Create(CustomerInvoice customerInvoice)
        {
            customerInvoice.Created = DateTime.Now;
            _context.Add(customerInvoice);
            _context.SaveChanges();
            return customerInvoice;
        }

        public CustomerInvoice Update(CustomerInvoice customerInvoice)
        {
            _context.Update(customerInvoice);
            _context.SaveChanges();
            return customerInvoice;
        }
    }
}