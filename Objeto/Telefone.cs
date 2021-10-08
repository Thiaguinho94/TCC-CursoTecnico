using System;
using System.Collections.Generic;

namespace Objeto
{
    public class Telefone : Funcionario
    {

        public Telefone(int Cod_Tel, List<string> fone, int cod_Func, int Cod_Fornec)
        {
            if (fone is null)
            {
                throw new ArgumentNullException(nameof(fone));
            }

            Codigo_Telefone = Cod_Tel;
            this.Cod_Fornec = Cod_Fornec;
            _ = Telefones;
            Codigo_Funcionario = cod_Func;
        }

        public int Codigo_Telefone
        { get; set; }
        public int Cod_Fornec { get; }
        public List<string> Telefones
        { get; set; }
    }
}
