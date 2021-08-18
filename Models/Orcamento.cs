using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public class Orcamento
    {
        public int IdOrcamento { get; set; }
        public Caminhao Caminhao { get; set; }
        public Carga Carga { get; set; }
        public Empresa Empresa { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorOrcamento { get; set; }
    }
}