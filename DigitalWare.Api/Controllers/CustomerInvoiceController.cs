using System.Linq;
using AutoMapper;
using DigitalWare.Core.DTOs.CustomerInvoice;
using DigitalWare.Core.DTOs.Paginate;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInvoiceController : ControllerBase
    {
        private readonly ICustomerInvoiceRepository _customerInvoiceRepository;
        private readonly IMapper _mapper;

        public CustomerInvoiceController(IMapper mapper, ICustomerInvoiceRepository customerInvoiceRepository)
        {
            _mapper = mapper;
            _customerInvoiceRepository = customerInvoiceRepository;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PaginateQueryDto paginateQuery)
        {
            var res = _customerInvoiceRepository.GetAll(paginateQuery);
            return Ok(new PaginateDto<CustomerInvoiceDto>
            {
                Data = res.Data.Select(invoice => _mapper.Map<CustomerInvoiceDto>(invoice)),
                TotalCount = res.TotalCount
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_mapper.Map<CustomerInvoiceDto>(_customerInvoiceRepository.GetById(id)));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerInvoiceInsertDto customerInvoiceInsertDto)
        {
            var customerInvoice = _mapper.Map<CustomerInvoice>(customerInvoiceInsertDto);
            var customer = _customerInvoiceRepository.Create(customerInvoice);
            return Ok(_mapper.Map<CustomerInvoiceDto>(customer));
        }

        [HttpPut]
        public IActionResult Update([FromBody] CustomerInvoice customerInvoice)
        {
            return Ok(_mapper.Map<CustomerInvoiceDto>(_customerInvoiceRepository.Update(customerInvoice)));
        }
    }
}