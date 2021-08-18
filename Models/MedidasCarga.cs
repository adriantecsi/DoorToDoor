using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public class MedidasCarga
    {
        public int IdMedida { get; set; }
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }
        public decimal Comprimento { get; set; }
        public decimal Peso { get; set; }
    }
}