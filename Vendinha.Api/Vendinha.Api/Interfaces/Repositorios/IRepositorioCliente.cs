using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendinha.Api.Models;

namespace Vendinha.Api.Interfaces.Repositorios
{
    public interface IRepositorioCliente
    {
        Task<IEnumerable<Cliente>> GetClientesList();
        Task<Cliente> GetClienteById(int id);
        Task<Cliente> CreateCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(int id);
        Task<IEnumerable<Cliente>> GetClientesListPaginado(int pagina);

    }
}
