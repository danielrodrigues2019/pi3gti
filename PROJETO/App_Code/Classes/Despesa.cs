using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{
    /// <summary>
    /// Summary description for Despesa
    /// </summary>
    public class Despesa
    {
        //propriedades
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }

        //construtor
        public Despesa()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}