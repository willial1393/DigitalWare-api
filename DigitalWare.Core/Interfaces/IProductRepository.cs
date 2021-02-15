using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface IProductRepository
    {
        public PaginateDto<Product> GetAll(PaginateQueryDto paginateDto);
        public Product GetById(int id);
        public Product GetByName(string name);
        public Product Create(Product product);
        public Product Update(Product product);
    }
}