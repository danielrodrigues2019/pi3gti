using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Encomenda
/// </summary>
public class Encomenda
{

    public int Codigo { get; set; }
    public string Produto { get; set; }
    public DateTime DataPedido { get; set; }
    public DateTime DataChegada { get; set; }
    public double Valor { get; set; }
    public string Cliente { get; set; }

    public Encomenda()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}