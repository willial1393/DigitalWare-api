using System.Linq;
using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStockRepository _stockRepository;

        public StockController(IMapper mapper, IStockRepository stockRepository)
        {
            _mapper = mapper;
            _stockRepository = stockRepository;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PaginateQueryDto paginateQuery)
        {
            var res = _stockRepository.GetAll(paginateQuery);
            return Ok(new PaginateDto<StockDto>
            {
                Data = res.Data.Select(stock => _mapper.Map<StockDto>(stock)),
                TotalCount = res.TotalCount
            });
        }

        [HttpGet("history")]
        public IActionResult GetAllHistory([FromQuery] PaginateQueryDto paginateQuery)
        {
            var res = _stockRepository.GetAllHistory(paginateQuery);
            return Ok(new PaginateDto<StockHistoryDto>
            {
                Data = res.Data.Select(stock => _mapper.Map<StockHistoryDto>(stock)),
                TotalCount = res.TotalCount
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<StockDto>(_stockRepository.GetById(id)));
        }

        [HttpGet("product/{id}")]
        public IActionResult GetByProductId(int id)
        {
            return Ok(_mapper.Map<StockDto>(_stockRepository.GetByProductId(id)));
        }
    }
}