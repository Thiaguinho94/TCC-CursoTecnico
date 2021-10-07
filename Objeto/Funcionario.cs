using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objeto
{
    public class Funcionario : Endereco
    {

        public Funcionario(int cod, string nome_fun, string dt_Nasc, string rg, string cpf, string email_fun, string sexo,
                           string tp_Contrato, int carteira, string dt_Adm, string cargo, string depto, string Sal, string Obs, string Cep,
                           string End, int Num, string Compl, string Bar, string Cidad, string uf)
        {
            Codigo_Funcionario = cod;
            Nome_Funcionario = nome_fun;
            Data_Nascimento = dt_Nasc;
            RG = rg;
            CPF = cpf;
            Email_Funcionario = email_fun;
            Sexo = sexo;
            Tipo_Contrato = tp_Contrato;
            Carteira_Profissional = carteira;
            Data_Admissao = dt_Adm;
            Cargo = cargo;
            Departamento = depto;
            Salario = Sal;
            Observacao = Obs;
            cep = Cep;
            endereco = End;
            Numero = Num;
            Complemto = Compl;
            Bairro = Bar;
            Cidade = Cidad;
            UF = uf;
        }


        public Funcionario(Funcionario f)
        {
            Codigo_Funcionario = f.Codigo_Funcionario;
            Nome_Funcionario = f.Nome_Funcionario;
            Data_Nascimento = f.Data_Nascimento;
            RG = f.RG;
            CPF = f.CPF;
            Email_Funcionario = f.Email_Funcionario;
            Sexo = f.Sexo;
            Tipo_Contrato = f.Tipo_Contrato;
            Carteira_Profissional = f.Carteira_Profissional;
            Data_Admissao = f.Data_Admissao;
            Cargo = f.Cargo;
            Departamento = f.Departamento;
            Salario = f.Salario;
            cep = f.cep;
            endereco = f.endereco;
            Numero = f.Numero;
            Complemto = f.Complemto;
            Bairro = f.Bairro;
            Cidade = f.Cidade;
            UF = f.UF;
            Observacao = f.Observacao;
        }

        public Funcionario()
        { }

        public int Codigo_Funcionario
        { get; set; }

        public string Nome_Funcionario
        { get; set; }

        public string Data_Nascimento
        { get; set; }

        public string RG
        { get; set; }

        public string CPF
        { get; set; }

        public string Email_Funcionario
        { get; set; }

        public string Sexo
        { get; set; }

        public string Tipo_Contrato
        { get; set; }

        public int Carteira_Profissional
        { get; set; }

        public string Data_Admissao
        { get; set; }

        public string Cargo
        { get; set; }

        public string Departamento
        { get; set; }

        public string Salario
        { get; set; }

        public string Observacao
        { get; set; }
    }
}
