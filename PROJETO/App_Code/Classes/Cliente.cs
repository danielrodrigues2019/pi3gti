using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{

    /// <summary>
    /// Summary description for Cliente
    /// </summary>
    public class Cliente
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public string Datacadastro { get; set; }
        public string Status { get; set; }

        //construtor
        public Cliente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}