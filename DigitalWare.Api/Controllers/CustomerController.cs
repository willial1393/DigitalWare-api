using System.Linq;
using AutoMapper;
using DigitalWare.Core.DTOs.Customer;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PaginateQueryDto paginateQuery)
        {
            var res = _customerRepository.GetAll(paginateQuery);
            return Ok(new PaginateDto<CustomerDto>
            {
                Data = res.Data.Select(customer => _mapper.Map<CustomerDto>(customer)),
                TotalCount = res.TotalCount
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<CustomerDto>(_customerRepository.GetById(id)));
        }

        [HttpGet("document/{document}")]
        public IActionResult GetById(string document)
        {
            return Ok(_mapper.Map<CustomerDto>(_customerRepository.GetByDocument(document)));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerInsertDto customerInsertDto)
        {
            var customer = _customerRepository.Create(_mapper.Map<Customer>(customerInsertDto));
            return Ok(_mapper.Map<CustomerDto>(customer));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Customer customer)
        {
            return Ok(_mapper.Map<CustomerDto>(_customerRepository.Update(customer)));
        }
    }
}