using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendinha.Api.Data;
using Vendinha.Api.Interfaces.Repositorios;
using Vendinha.Api.Models;

namespace Vendinha.Api.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        public readonly DataContext _context;
        private int _qtdPaginacao = 10;
        public RepositorioCliente(DataContext context)
        {
            _context = context;
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientesList()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> GetClientesListPaginado(int pagina)
        {
            return await _context.Clientes.Skip((pagina-1) * _qtdPaginacao).Take(_qtdPaginacao).ToListAsync();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
