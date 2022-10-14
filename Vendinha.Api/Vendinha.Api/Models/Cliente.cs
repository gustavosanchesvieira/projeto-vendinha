using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendinha.Api.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
