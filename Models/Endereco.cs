using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}