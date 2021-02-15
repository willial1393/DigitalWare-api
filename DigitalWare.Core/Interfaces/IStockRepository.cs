using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface IStockRepository
    {
        public PaginateDto<Stock> GetAll(PaginateQueryDto paginateDto);
        public Stock GetById(int id);
        public Stock GetByProductId(int id);
    }
}