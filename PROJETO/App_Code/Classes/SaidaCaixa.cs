using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PROJETO.Classes
{

    /// <summary>
    /// Descrição resumida de SaidaCaixa
    /// </summary>
    public class SaidaCaixa
    {
        public int Codigo { get; set; }
        public string Vendedor { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public SaidaCaixa()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}