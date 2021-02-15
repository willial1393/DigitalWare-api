using System.Linq;
using DigitalWare.Core.DTOs.Paginate;
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

        public Product Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}