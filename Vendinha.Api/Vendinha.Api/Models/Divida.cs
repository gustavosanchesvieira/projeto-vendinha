using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendinha.Api.Models
{
    public class Divida 
    {
        public int Id { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataPagamento { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
