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
    public class RepositorioDivida : IRepositorioDivida
    {
        public readonly DataContext _context;
        public RepositorioDivida(DataContext context)
        {
            _context = context;
        }

        public async Task<Divida> CreateDivida(Divida divida)
        {
            _context.Dividas.Add(divida);
            await _context.SaveChangesAsync();
            return divida;
        }

        public async Task<Divida> GetDividaById(int id)
        {
            return await _context.Dividas.FindAsync(id);
        }

        public async Task<IEnumerable<Divida>> GetDividasList()
        {
            return await _context.Dividas.ToListAsync();
        }

        public async Task UpdateDivida(Divida divida)
        {
            _context.Entry(divida).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
