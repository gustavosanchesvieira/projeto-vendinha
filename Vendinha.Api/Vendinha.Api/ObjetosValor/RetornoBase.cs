using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendinha.Api.ObjetosValor
{
    public class RetornoBase
    {
        public RetornoBase()
        {
        }

        public RetornoBase(bool sucesso, string codigo, string motivo) : this()
        {
            Codigo = codigo;
            Sucesso = sucesso;
            Motivo = motivo;
        }

        public bool Sucesso { get; set; }
        public string Codigo { get; set; }
        public string Motivo { get; set; }
    }
}
