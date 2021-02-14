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
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _clientRepository.GetClients();
            var clientDto = _mapper.Map<IEnumerable<ClientDto>>(clients);
            return Ok(clientDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clientRepository.GetClientById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Client client)
        {
            return Ok(_clientRepository.Create(client));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Client client)
        {
            return Ok(_clientRepository.Update(client));
        }
    }
}