using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{

    /// <summary>
    /// Summary description for Cliente
    /// </summary>
    public class Fornecedor
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }

        //construtor
        public Fornecedor()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}