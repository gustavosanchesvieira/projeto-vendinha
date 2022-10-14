using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendinha.Api.Models;

namespace Vendinha.Api.Interfaces.Repositorios
{
    public interface IRepositorioDivida
    {
        Task<IEnumerable<Divida>> GetDividasList();
        Task<Divida> GetDividaById(int id);
        Task<Divida> CreateDivida(Divida divida);
        Task UpdateDivida(Divida divida);
    }
}
