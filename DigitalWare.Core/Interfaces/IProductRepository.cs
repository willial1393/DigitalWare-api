using System.Collections.Generic;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.DTOs.Product;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface IProductRepository
    {
        public PaginateDto<Product> GetAll(PaginateQueryDto paginateDto);
        public Product GetById(int id);
        public Product GetByName(string name);
        public IEnumerable<Product> GetByNameContain(string name);
        public Product Create(Product product);
        public bool AddUnits(ProductAddUnitsDto productAddUnitsDto);
        public Product Update(Product product);
    }
}