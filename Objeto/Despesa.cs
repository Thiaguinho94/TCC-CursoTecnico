namespace Objeto
{
    public class Despesa
    {

        #region Construtores

        public Despesa(int cod_desp, string descri_desp, string data_pg, string data_venc, string valor_desp, string status_desp, string obs)
        {
            Codigo_Despesa = cod_desp;
            Descricao_Despesa = descri_desp;
            Data_Pagamento = data_pg;
            Data_Vencimento = data_venc;
            Valor_Despesa = valor_desp;
            Status_Despesa = status_desp;
            Observacao_Despesa = obs;
        }

        public Despesa()
        { }

        public Despesa(string descri_desp, string data_pg, string data_venc, string valor_desp, string status_desp, string obs)
        {
            Descricao_Despesa = descri_desp;
            Data_Pagamento = data_pg;
            Data_Vencimento = data_venc;
            Valor_Despesa = valor_desp;
            Status_Despesa = status_desp;
            Observacao_Despesa = obs;
        }

        #endregion



        #region Propriedades

        public int Codigo_Despesa
        { get; set; }

        public string Descricao_Despesa
        { get; set; }

        public string Data_Pagamento
        { get; set; }

        public string Data_Vencimento
        { get; set; }

        public string Valor_Despesa
        { get; set; }

        public string Status_Despesa
        { get; set; }

        public string Observacao_Despesa
        { get; set; }

        #endregion






    }
}
