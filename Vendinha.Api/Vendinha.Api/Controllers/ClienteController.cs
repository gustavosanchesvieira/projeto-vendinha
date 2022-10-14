using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendinha.Api.Interfaces.Repositorios;
using Vendinha.Api.Models;

namespace Vendinha.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : BaseController
    {
        private readonly IRepositorioCliente _repositorioCliente;

        public ClienteController(IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            try
            {
                var listaClientes = await _repositorioCliente.GetClientesList();
                return Ok(listaClientes);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente(int id)
        {
            try
            {
                var cliente = await _repositorioCliente.GetClienteById(id);
                return Ok(cliente);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }

        }

        [HttpPost]
        public async Task<IActionResult> PostCliente([FromBody] Cliente cliente)
        {
            try
            {
                var newCliente = await _repositorioCliente.CreateCliente(cliente);
                return Ok(newCliente);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, [FromBody] Cliente cliente)
        {
            try
            {
                if (id != cliente.Id)
                {
                    return BadRequest();
                }

                await _repositorioCliente.UpdateCliente(cliente);
                return Ok();
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                var cliente = await _repositorioCliente.GetClienteById(id);

                if (cliente == null)
                {
                    return NotFound();
                }

                await _repositorioCliente.DeleteCliente(cliente.Id);
                return Ok();
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }
    }
}
