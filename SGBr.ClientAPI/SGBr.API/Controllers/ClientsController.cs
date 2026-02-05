using System;
using Microsoft.AspNetCore.Mvc;
using SGBr.Application.DTOs;
using SGBr.Application.Interfaces;

namespace SGBr.API.Controllers
{
    [ApiController]
    [Route("/clientes")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var clients = _clientService.List();

                return Ok(clients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClientCreateDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return ValidationProblem(ModelState);

                ClientDTO newClient = _clientService.Create(dto);

                return Ok(newClient);
            }
            catch (ArgumentException e)
            {
                string fieldName = e.ParamName ?? "";
                var cleanMessage = e.Message.Split(" (Parameter")[0];
                ModelState.AddModelError(fieldName, cleanMessage);
                return ValidationProblem(ModelState);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao criar o cliente.");
            }
        }
    }
}
