using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objeto
{
    public class Pedido : Produto
    {

        public Pedido(int cod_Ped, string Desc_Prod, string Valor_Uni, int Qtde_Ped,
                      string dt_Pedido, string dt_Prev_Entrega, string Obs)
        {
            Codigo_Pedido = cod_Ped;
            Descricao_Produto = Desc_Prod;
            Preco_Custo = Valor_Uni;
            Quantidade_Nova = Qtde_Ped;
            Data_Pedido = dt_Pedido;
            Data_Previa_Entrega = dt_Prev_Entrega;
            Observacao = Obs;
        }

        
      
        public int Codigo_Pedido
        { get; set; }

        public int Quantidade_Pedida
        { get; set; }

        public string Data_Pedido
        { get; set; }

        public string Data_Previa_Entrega
        { get; set; }

        public string Observacao
        { get; set; }


    }
}
