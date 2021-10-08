namespace Objeto
{
    public class Produto
    {

        public Produto(int Cod_Prod, string Desc_Prod, int Cod_Fornec, int Qtde_Nova,
                       string Prc_Custo, string Prc_Venda)
        {
            Codigo_Produto = Cod_Prod;
            Descricao_Produto = Desc_Prod;
            Codigo_Fornecedor = Cod_Fornec;
            Quantidade_Nova = Qtde_Nova;
            Preco_Custo = Prc_Custo;
            Preco_Venda = Prc_Venda;
        }

        public Produto(Produto p)
        {
            Codigo_Produto = p.Codigo_Produto;
            Descricao_Produto = p.Descricao_Produto;
            Codigo_Fornecedor = p.Codigo_Fornecedor;
            Quantidade_Nova = p.Quantidade_Nova;
            Preco_Custo = p.Preco_Custo;
            Preco_Venda = p.Preco_Venda;
        }

        public Produto()
        { }

        public int Codigo_Produto
        { get; set; }

        public string Descricao_Produto
        { get; set; }

        public int Codigo_Fornecedor
        { get; set; }

        public int Quantidade
        { get; set; }

        public int Quantidade_Nova
        { get; set; }

        public string Preco_Custo
        { get; set; }

        public string Preco_Venda
        { get; set; }



        /// <summary>
        /// Calcula a quantidade que esteja cadastra e
        /// adiciona o que esta chegando
        /// </summary>
        /// <returns></returns>
        public int Quantidade_Total()
        {
            return Quantidade + Quantidade_Nova;
        }


    }
}
