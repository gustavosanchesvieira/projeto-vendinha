using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendinha.Api.ObjetosValor;

namespace Vendinha.Api.Controllers
{
    public abstract class BaseController : Controller
    {
        protected ObjectResult TratarExcepiton(Exception ex)
        {
            if (ex is ArgumentException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new RetornoBase
                {
                    Codigo = StatusCodes.Status400BadRequest.ToString(),
                    Motivo = ex.Message,
                    Sucesso = false
                });
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new RetornoBase
            {
                Codigo = StatusCodes.Status500InternalServerError.ToString(),
                Motivo = ex.Message,
                Sucesso = false
            });
        }
    }
}
