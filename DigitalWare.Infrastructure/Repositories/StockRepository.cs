using System.Linq;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;

namespace DigitalWare.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginateDto<Stock> GetAll(PaginateQueryDto paginateDto)
        {
            var res = new PaginateDto<Stock>
            {
                Data = _context.Stock
                    .OrderBy(stock => stock.Name)
                    .Skip(paginateDto.Skip)
                    .Take(paginateDto.Take)
                    .ToList()
            };
            if (paginateDto.RequireTotalCount)
            {
                res.TotalCount = _context.Stock.Count();
            }

            return res;
        }

        public Stock GetById(int id)
        {
            return _context.Stock.Find(id);
        }

        public Stock GetByProductId(int id)
        {
            return _context.Stock.FirstOrDefault(stock => stock.ProductId == id);
        }
    }
}