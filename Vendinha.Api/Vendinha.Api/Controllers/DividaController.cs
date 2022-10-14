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
    public class DividaController : BaseController
    {
        private readonly IRepositorioDivida _repositorioDivida;
        public DividaController(IRepositorioDivida repositorioDivida)
        {
            _repositorioDivida = repositorioDivida;
        }

        [HttpGet]
        public async Task<IActionResult> GetDividas()
        {
            try
            {
                var listaDividas = await _repositorioDivida.GetDividasList();
                return Ok(listaDividas);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDivida(int id)
        {
            try
            {
                var divida = await _repositorioDivida.GetDividaById(id);
                return Ok(divida);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostDivida([FromBody] Divida divida)
        {
            try
            {
                var newDivida = await _repositorioDivida.CreateDivida(divida);
                return Ok(newDivida);
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDivida(int id, [FromBody] Divida divida)
        {
            try
            {
                if (id != divida.Id)
                {
                    return BadRequest();
                }
                await _repositorioDivida.UpdateDivida(divida);
                return Ok();
            }
            catch (Exception e)
            {
                return TratarExcepiton(e);
            }
        }

    }
}
