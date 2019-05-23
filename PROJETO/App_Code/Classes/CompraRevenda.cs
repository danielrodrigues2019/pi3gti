using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETO.Classes
{

    /// <summary>
    /// Summary description for Cliente
    /// </summary>
    public class CompraRevenda
    {
        //propriedades
        public int Codigo { get; set; }
        public int FornecedorCodigo { get; set; }
        public string Pagamento { get; set; }
        public DateTime Data { get; set; }
        
        
        //construtor
        public CompraRevenda()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}