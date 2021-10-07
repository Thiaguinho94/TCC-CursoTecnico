using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objeto
{
    public class Endereco
    {
        public Endereco()
        {
            cep = "";
            endereco = "";
            Numero = 0;
            Complemto = "";
            Bairro = "";
            Cidade = "";
            UF = "";
        }


        public string cep
        { get; set; }

        public string endereco
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