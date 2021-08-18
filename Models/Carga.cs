using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public class Carga
    {
        public int IdCarga { get; set; }
        public decimal ValorCarga { get; set; }
        public int Quantidade { get; set; }
        public TipoCarga TipoCarga { get; set; }
        public Endereco Origem { get; set; }
        public Endereco Destino { get; set; }
        public MedidasCarga MedidasCarga { get; set; }
    }
}