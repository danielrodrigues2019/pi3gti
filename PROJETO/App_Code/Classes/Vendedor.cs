using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{

    /// <summary>
    /// Summary description for Cliente
    /// </summary>
    public class Vendedor
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        //construtor
        public Vendedor()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}