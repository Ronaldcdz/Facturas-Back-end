using Application.DTOs.Cliente;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturas.Controllers
{
    // [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _clienteService.GetAllViewDTO());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _clienteService.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }


        [HttpPost]
        public async Task<IActionResult> Post(ClienteSaveEditDTO cliente)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("");
            }

            var clienteAdded = await _clienteService.Add(cliente);
            if (clienteAdded == null)
            {
                return BadRequest();

            }

            return CreatedAtAction(
                         nameof(Get),
                         new { clienteAdded.Id },
                         cliente);

        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ClienteSaveEditDTO cliente)
        {

            var clienteFound = await _clienteService.GetById(cliente.Id);

            if (clienteFound == null)
            {
                return NotFound();
            }

            await _clienteService.Update(cliente, cliente.Id);
            // return NoContent();

            return CreatedAtAction(
                         nameof(Get),
                         new { cliente.Id },
                         cliente);

        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var clienteFound = await _clienteService.GetById(id);

            if (clienteFound == null)
            {
                return NotFound();
            }

            await _clienteService.Delete(id);
            return NoContent();
        }
    }
}
