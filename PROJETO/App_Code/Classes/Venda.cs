using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{
    /// <summary>
    /// Summary description for Funcionario
    /// </summary>
    public class Venda
    {
        //propriedades
        public int Codigo { get; set; }
        public string Pagamento { get; set; }
        public int ClienteCodigo { get; set; }
        public DateTime Data { get; set; }
        //construtor
        public Venda()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}