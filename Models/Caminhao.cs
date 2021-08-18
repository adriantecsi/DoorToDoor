using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public class Caminhao
    {
        public int IdCaminhao { get; set; }
        public string NomeCaminhao { get; set; }
        public TamanhoCaminhao TamanhoCaminhao { get; set; }
        public TipoCarga TipoCarga { get; set; }
        public decimal ValorFrete { get; set; }
    }
}