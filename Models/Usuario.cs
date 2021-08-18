using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Door2Door.Models
{
    public abstract class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public Funcao UsuarioFuncao { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public Endereco Endereco { get; set; }
        public decimal Telefone { get; set; }

    }
    public class Empresa : Usuario
    {
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public decimal CNPJ { get; set; }
        public Caminhao Caminhao { get; set; }
        public Licenca Licenca { get; set; }
    }
    public class Cliente : Usuario
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public decimal CNPJCPF { get; set; }
        public Carga Carga { get; set; }
    }
    public class Administrador : Usuario
    {
        public int IdADM { get; set; }
    }
}