using System.Linq;
using AutoMapper;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.DTOs.Product;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PaginateQueryDto paginateQuery)
        {
            var res = _productRepository.GetAll(paginateQuery);
            return Ok(new PaginateDto<ProductDto>
            {
                Data = res.Data.Select(product => _mapper.Map<ProductDto>(product)),
                TotalCount = res.TotalCount
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<ProductDto>(_productRepository.GetById(id)));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(_mapper.Map<Product>(_productRepository.GetByName(name)));
        }

        [HttpGet("nameContain/{name}")]
        public IActionResult GetByNameContain(string name)
        {
            return Ok(_productRepository.GetByNameContain(name).Select(product =>
                _mapper.Map<ProductDto>(product))
            );
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductInsertDto productInsertDto)
        {
            return Ok(_productRepository.Create(_mapper.Map<Product>(productInsertDto)));
        }

        [HttpPost("units")]
        public IActionResult AddUnits([FromBody] ProductAddUnitsDto productAddUnitsDto)
        {
            return Ok(_productRepository.AddUnits(productAddUnitsDto));
        }

        [HttpPut]
        public IActionResult Update([FromBody] ProductDto productDto)
        {
            return Ok(_productRepository.Update(_mapper.Map<Product>(productDto)));
        }
    }
}