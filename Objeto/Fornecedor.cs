namespace Objeto
{
    public class Fornecedor : Endereco
    {
        public Fornecedor(int cod_fornec, string cnpj, string rz_Social, string nome_Fant, string repre, string Email_Fornec,
                              string Obs, string Cep, string End, int Num, string Compl, string Bar, string Cidad, string uf)
        {
            Codigo_Fornecedor = cod_fornec;
            CNPJ = cnpj;
            Razao_Social = rz_Social;
            Nome_Fantasia = nome_Fant;
            Representante = repre;
            Email_Fornecedor = Email_Fornec;
            Observacao = Obs;
            base.Cep = Cep;
            Logradouro = End;
            Numero = Num;
            Complemto = Compl;
            Bairro = Bar;
            Cidade = Cidad;
            UF = uf;
        }

        public Fornecedor(Fornecedor f)
        {
            Codigo_Fornecedor = f.Codigo_Fornecedor;
            CNPJ = f.CNPJ;
            Razao_Social = f.Razao_Social;
            Nome_Fantasia = f.Nome_Fantasia;
            Email_Fornecedor = f.Email_Fornecedor;
            Observacao = f.Observacao;
            Cep = f.Cep;
            Logradouro = f.Logradouro;
            Numero = f.Numero;
            Complemto = f.Complemto;
            Bairro = f.Bairro;
            Cidade = f.Cidade;
            UF = f.UF;
        }

        public Fornecedor()
        { }

        public int Codigo_Fornecedor
        { get; set; }

        public string CNPJ
        { get; set; }

        public string Razao_Social
        { get; set; }

        public string Nome_Fantasia
        { get; set; }

        public string Representante
        { get; set; }

        public string Email_Fornecedor
        { get; set; }

        public string Observacao
        { get; set; }
    }
}