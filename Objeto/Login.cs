using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objeto
{
    public class Login : Funcionario
    {
        
        public Login(int Cod_Usuario, string usuario,string usuario_v, string senha, string senhanova , string telacesso, int Cod_Fun)
        {
            Codigo_Usuario = Cod_Usuario;
            Usuario = usuario;
            Usuario_ve = usuario_v;
            Senha = senha;
            SenhaNova = senhanova;
            Telas_Acesso = telacesso;
            Codigo_Funcionario = Cod_Fun;
        }

        public Login(int Cod_Usuario, string usuario, string senha, string telacesso, int Cod_Fun)
        {
            Codigo_Usuario = Cod_Usuario;
            Usuario = usuario;
            Senha = senha;
            Telas_Acesso = telacesso;
            Codigo_Funcionario = Cod_Fun;
        }

        public int Codigo_Usuario
        { get; set; }

        public string Usuario
        { get; set; }

        public string Usuario_ve
        { get; set; }

        public string Senha
        { get; set; }

        public string SenhaNova
        { get; set; }
        public string Telas_Acesso
        { get; set; }
    }
}
