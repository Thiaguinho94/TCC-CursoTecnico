using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objeto
{
    public class Telefone : Funcionario 
    {

        public Telefone(int Cod_Tel , List<string> fone, int cod_Func , int Cod_Fornec)
        {
            Codigo_Telefone = Cod_Tel;
            fone = Telefones;
            Codigo_Funcionario = cod_Func;
        }

        
        public int Codigo_Telefone
        { get; set; }

        public List<string> Telefones
        { get; set; }
    }
}
