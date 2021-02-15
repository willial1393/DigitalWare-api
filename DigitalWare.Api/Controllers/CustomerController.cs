using System.Collections.Generic;
using AutoMapper;
using DigitalWare.Core.DTOs;
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
        public IActionResult GetAll()
        {
            var clients = _customerRepository.GetAll();
            var clientDto = _mapper.Map<IEnumerable<CustomerDto>>(clients);
            return Ok(clientDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_customerRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            return Ok(_customerRepository.Create(customer));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Customer customer)
        {
            return Ok(_customerRepository.Update(customer));
        }
    }
}