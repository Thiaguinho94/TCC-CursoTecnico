namespace Objeto
{
    public class Endereco
    {
        public Endereco()
        {
            Cep = "";
            Logradouro = "";
            Numero = 0;
            Complemto = "";
            Bairro = "";
            Cidade = "";
            UF = "";
        }


        public string Cep
        { get; set; }

        public string Logradouro
        { get; set; }

        public int Numero
        { get; set; }

        public string Complemto
        { get; set; }

        public string Bairro
        { get; set; }

        public string Cidade
        { get; set; }

        public string UF
        { get; set; }
    }
}