using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pesq.DAL;
using Objeto;

namespace Pesq.BLL
{
    public class BLL
    {
        DAL.DAL da = new DAL.DAL(); //THIAGO: Instanciando a camada de dados que é reponsavel da conexão com a fonte de dados.


        #region Obter

        public DataSet ObtemFuncionario()
        {
            return da.Select("Select * from tb_Funcionario"); //THIAGO: Retorna todos os funcionarios cadastrado
        }

        public DataSet ObtemFuncionario(string pesquisa)
        {
            return da.Select(@"Select * from tb_Funcionario
                               WHERE Nome_Func LIKE'%" + pesquisa + @"%' 
                               OR Cod_Func  LIKE '%" + pesquisa + "%'"); //THIAGO: Retorna o funcionario que ele deseja pesquisar.
        }


        public DataSet ObtemProduto()
        {
            return da.Select(@"SELECT Descricao_Prod FROM tb_Produto");
        }

        public DataSet ObtemProduto(string pesquisar)
        {
            return da.Select(@"SELECT Descricao_Prod FROM tb_Produto
                      WHERE Cod_Prod LIKE '%" + pesquisar + @"%'
                      OR Descricao_Prod LIKE '%" + pesquisar + "%'");
        }

        public DataSet ObtemProduto2()
        {
            return da.Select(@"SELECT p.*,c.Categoria
                         FROM tb_Categoria c
                         INNER JOIN tb_Produto p
                         ON c.Codigo = p.Cod_Categoira ");
        }

        public DataSet ObtemFornecedor()
        {
            return da.Select("SELECT * FROM tb_Fornecedor"); //THIAGO: Retorna todos os fornecedores cadastrado
        }

        public DataSet ObtemFornecedor(string pesquisa)
        {
            return da.Select(@"SELECT * FROM tb_Fornecedor
                               WHERE Cod_Fornec LIKE '%" + pesquisa + @"%'
                               OR Representante LIKE '%" + pesquisa + @"%'" +
                               "OR Razao_Social LIKE '%" + pesquisa + "%'" +
                               "OR Nome_Fantasia LIKE '%" + pesquisa + "%'"); //THIAGO: Retorna os fornecedores que o usuario desejar.
        }

        public DataSet ObtemTelefones(string cod_func, string cod_fornec)
        {
            return da.Select(@"SELECT Cod_Func , Cod_Fornec, Telefone
                           FROM tb_Telefone
                           WHERE Cod_Func= " + cod_func +
                           " OR Cod_Fornec= " + cod_fornec); /* uma query para selecionar todos os telefones do funcionarios ou do fornecedor no bd*/
        }

        public DataSet ObtemLogin()
        {
            return da.Select("SELECT Cod,Usuario, Senha FROM tb_Login");/* THIAGO: uma query para selecionar todos os usuarios e senha do cadastrado no bd*/
        }

        public DataSet ObtemLogin(int cod)
        {
            return da.Select(@"SELECT Cod,Usuario, Senha FROM tb_Login
                        WHERE Cod_Func = " + cod);/* THIAGO: uma query para selecionar o usuario e senha desejado do cadastrado no bd*/
        }

        public DataSet ObtemUsuario()
        {
            return da.Select("SELECT Usuario from tb_Login"); /* THIAGO: uma query para selecionar todos os usuario cadastrado no bd*/
        }

        public DataSet ObtemTelasAcessoFunc(string usuario)
        {
            return da.Select(@"SELECT A.Usuario,A.Telas_Acesso
                           FROM tb_Login A
                           WHERE A.Usuario ='" + usuario + "'");
        }

        public DataSet ObtemDespesa(string pesquisa)
        {
            return da.Select(@"SELECT * FROM tb_Despesa
                        WHERE Cod_Desp LIKE '%" + pesquisa + @"%'
                        OR Descricao_Desp LIKE '%" + pesquisa + @"%'
                        OR Status_Conta ='" + pesquisa + @"'");

        
        }

        public DataSet ObtemDespesa()
        {
            return da.Select(@"SELECT * FROM tb_Despesa");
        }

        public DataSet ObtemCategoria()
        {
            return da.Select(@"SELECT * FROM tb_Categoria");
        }

        #endregion

        #region Gravar

        public void GravarFuncionario(Funcionario fun)
        {
            //THIAGO: Insere todos os atributos na tabela funcionarios
            da.Insert(@"INSERT INTO tb_Funcionario(Nome_Func,
                                                            Data_Nasc,
                                                            RG,
                                                            CPF,
                                                            Email_Func,
                                                            Sexo,
                                                            Tipo_Contrato,
                                                            Carteira_Prof,
                                                            Data_Adm,
                                                            Cargo,
                                                            Departamento,
                                                            Cep,
                                                            Endereco,
                                                            Numero,
                                                            Bairro,
                                                            Cidade,
                                                            UF,
                                                            Salario,
                                                            Observacao)
                                                    VALUES ('" + fun.Nome_Funcionario
                                                           + "'," + fun.Data_Nascimento
                                                           + ",'" + fun.RG
                                                           + "','" + fun.CPF
                                                           + "','" + fun.Email_Funcionario
                                                           + "','" + fun.Sexo
                                                           + "','" + fun.Tipo_Contrato
                                                           + "'," + fun.Carteira_Profissional
                                                           + "," + fun.Data_Admissao
                                                           + ",'" + fun.Cargo
                                                           + "','" + fun.Departamento
                                                           + "'," + fun.cep
                                                           + ",'" + fun.endereco
                                                           + "'," + fun.Numero
                                                           + ",'" + fun.Bairro
                                                           + "','" + fun.Cidade
                                                           + "','" + fun.UF
                                                           + "','" + fun.Salario
                                                           + "','" + fun.Observacao + "')");
                
        }

        public void GravarLogin(Login lg)
        {
            //THIAGO: Insere todos os atributos na Tabela Login
            da.Insert(@"INSERT INTO tb_Login (Usuario, Senha,Telas_Acesso,Cod_Func)
                           VALUES('" + lg.Usuario + "' ,'" + lg.Senha + "','" + lg.Telas_Acesso + "'," + lg.Codigo_Funcionario + ")");
        }

        public void GravarLogin(Telefone t)
        {
            //THIAGO: Insere todos os atributos na Tabela Login
            da.Insert(@"INSERT INTO tb_Telefone(Telefone,Cod_Func,Cod_Fornec)
                                                    VALUES (" + t.Telefones + "," + t.Codigo_Funcionario + "," + t.Codigo_Telefone + ")");
        }


        public void GravarFornecedor(Fornecedor fornec)
        {
            //THIAGO: Insere todos os atributos na tabela Fornecedor.
            da.Insert(@"INSERT INTO tb_Fornecedor(Cnpj
                                                  ,Razao_Social
                                                  ,Nome_Fantasia
                                                  ,Representante
                                                  ,Email_Fornec
                                                  ,Cep
                                                  ,Endereco
                                                  ,Numero
                                                  ,Complemento
                                                  ,Bairro
                                                  ,Cidade
                                                  ,UF
                                                  ,Observacao)
                                          VALUES ('" + fornec.CNPJ +
                                                  "','" + fornec.Razao_Social +
                                                  "','" + fornec.Nome_Fantasia +
                                                  "','" + fornec.Representante +
                                                  "','" + fornec.Email_Fornecedor +
                                                  "','" + fornec.cep +
                                                  "','" + fornec.endereco +
                                                  "', " + fornec.Numero +
                                                  " ,'" + fornec.Complemto +
                                                  "','" + fornec.Bairro +
                                                  "','" + fornec.Cidade +
                                                  "','" + fornec.UF +
                                                  "','" + fornec.Observacao +
                                                  "')");
        }

        public void GravarTelefone(string cod_fun, string cod_fornec, int fone)
        {
            da.Insert(@"INSERT INTO tb_Telefone(Telefone
                                                            ,Cod_Func
                                                            ,Cod_Fornec)
                                                    VALUES (" + fone + "," + cod_fun + "," + cod_fornec + ")");

        }

        public void GravarDespesa(Despesa desp)
        {
            //THIAGO: Insere Despesa.
            da.Insert(@"INSERT INTO tb_Despesa(Descricao_Desp
                                              ,Data_Pagamento
                                              ,Data_Vencimento
                                              ,Valor_Despesa
                                              ,Status_Conta
                                              ,Obs)
                                    VALUES('" + desp.Descricao_Despesa +
                                           "','" + desp.Data_Pagamento +
                                           "','" + desp.Data_Vencimento +
                                           "'," + desp.Valor_Despesa +
                                           ",'" + desp.Status_Despesa +
                                           "','" + desp.Observacao_Despesa +
                                           "')");
        }

        #endregion

        #region Deletar

        public void DeletarFuncionario(Funcionario func)
        {
            DeletarUsuarioSenha(func.Codigo_Funcionario);
            DeletarTelefone(func.Codigo_Funcionario);

            da.Delete(@"DELETE FROM tb_Funcionario
                        WHERE Cod_Func = " + func.Codigo_Funcionario);
        }

        public void DeletarUsuarioSenha(int Cod_Funcionario)
        {
            da.Delete(@"DELETE FROM tb_Login
                        WHERE Cod_Func = " + Cod_Funcionario);
        }

        public void DeletarFornecedor(Fornecedor f)
        {
            DeletarTelefone(f.Codigo_Fornecedor);
            da.Delete(@"DELETE FROM tb_Fornecedor
                        WHERE Cod_Fornec = " + f.Codigo_Fornecedor);
        }

        public void DeletarTelefone(int Codigo)
        {
            da.Delete(@"DELETE FROM tb_Telefone
                       WHERE Cod_Func = " + Codigo +
                       "OR Cod_Fornec = " + Codigo);
        }

        public void DeletarDespesa(Despesa dsp)
        {
            da.Delete(@"DELETE FROM tb_Despesa
                  WHERE Cod_Desp = " + dsp.Codigo_Despesa);
        }

        #endregion

        #region Atualizar

        public void AtualizarLogin(Login lg)
        {
            da.Update(@"UPDATE tb_Login
                     SET Usuario = '" + lg.Usuario + @"',Senha='" + lg.SenhaNova + @"'
                     WHERE Usuario = '" + lg.Usuario_ve + @"' AND Senha='" + lg.Senha + @"'");

        }

        public void AtualizarDespesa(Despesa dsp)
        {
            da.Update(@"UPDATE tb_Despesa
                     SET Status_Conta = '" + dsp.Status_Despesa + "', Data_Pagamento = " + dsp.Data_Pagamento + @"
                     WHERE Cod_Desp = " + dsp.Codigo_Despesa);

        }

        #endregion



















        
    }
}

