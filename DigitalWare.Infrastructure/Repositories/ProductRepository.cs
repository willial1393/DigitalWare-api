using System;
using System.Collections.Generic;
using System.Linq;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.DTOs.Product;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;

namespace DigitalWare.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginateDto<Product> GetAll(PaginateQueryDto paginateDto)
        {
            var res = new PaginateDto<Product>
            {
                Data = _context.Products
                    .OrderBy(product => product.Name)
                    .Skip(paginateDto.Skip)
                    .Take(paginateDto.Take)
                    .ToList()
            };
            if (paginateDto.RequireTotalCount)
            {
                res.TotalCount = _context.Products.Count();
            }

            return res;
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public Product GetByName(string name)
        {
            return _context.Products.FirstOrDefault(product => product.Name.ToLower() == name.ToLower());
        }

        public IEnumerable<Product> GetByNameContain(string name)
        {
            return _context.Products.Where(product =>
                product.Name.ToLower().Contains(name.ToLower())
            );
        }

        public Product Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        public bool AddUnits(ProductAddUnitsDto productAddUnitsDto)
        {
            var last = _context.StockHistories
                .OrderByDescending(history => history.Created)
                .FirstOrDefault(history => history.ProductId == productAddUnitsDto.ProductId);
            _context.StockHistories.Add(new StockHistory
            {
                Created = DateTime.Now,
                Quantity = productAddUnitsDto.Units,
                Total = productAddUnitsDto.UnitPrice + productAddUnitsDto.Units,
                Type = "IN",
                ProductId = productAddUnitsDto.ProductId,
                TotalQuantity = Convert.ToInt16(productAddUnitsDto.Units + (last?.TotalQuantity ?? 0)),
                UnitPrice = productAddUnitsDto.UnitPrice
            });
            _context.SaveChanges();
            return true;
        }

        public Product Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}