using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PROJETO.Classes
{
    /// <summary>
    /// Summary description for Funcionario
    /// </summary>
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Datacadastro { get; set; }
        public double PrecoVenda { get; set; }
        //construtor
        public Produto()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}