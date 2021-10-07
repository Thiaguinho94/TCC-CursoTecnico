using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pesq.BLL;


namespace Pesqueiro
{
    public partial class frmLogin : Form
    {
        BLL bll = new BLL();
        RnLogin rn = new RnLogin();

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool RetornaSenha = false;

            DataSet ds = bll.ObtemLogin(); // Pegar todos os usuario e senhas
            rn.Validacao_Login(ds, ref RetornaSenha, cbmUsuario.Text.ToString(), txtSenha.Text.ToString()); // Verifica se a senha com o usuario esta correta

            if (RetornaSenha == true)
            {
                pctbErro.Visible = false;
                Pesq_MenuPrincipal.frmMenuPrincipal menu = new Pesq_MenuPrincipal.frmMenuPrincipal();
                this.Visible = false;
                menu.ShowDialog();
                this.Close();
            }
            else
                pctbErro.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin__Load(object sender, EventArgs e)
        {
            /*Quando passar o mouse nos botões irar aparecer as descrições de cada um */
            ttText.SetToolTip(pctbErro, "Senha incorreta!");
            cbmUsuario.Select();
            try
            {
                DataSet ds = bll.ObtemUsuario(); //Pegar todos os usuario que estão cadastrado

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    cbmUsuario.Items.Add(ds.Tables[0].Rows[i][0]); // colocando na combobox todo os usuario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEntrar_Click(sender, e);
        }

        public void AcessoTelas(string Telas)
        {
            string[] telasacesso = Telas.ToString().Split('-');

            if (telasacesso.Length == 8)
                return;
            else
            {
                bool Caixa = false, Cadastro = false, Consulta = false, Pedido = false, Produto = false, Pesqueiro = false,
                     Financa = false, ultimo = false, Menu = false;


                for (int i = 0; i < telasacesso.Length; i++)
                {
                    if (i == telasacesso.Length - 1)
                        ultimo = true;

                    // Verificando de caso o usuario tem a permissao de ver o item de caixa
                    rn.acessoCaixa(ref Caixa, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Cadastro
                    rn.acessoCadastro(ref Cadastro, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Consulta
                    rn.acessoConsulta(ref Consulta, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Pedido
                    rn.acessoPedido(ref Pedido, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Produto
                    rn.acessoProduto(ref Produto, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Pesqueiro
                    rn.acessoPesquiero(ref Pesqueiro, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Finanças
                    rn.acessoFinanca(ref Financa, telasacesso[i].ToString(), ultimo);

                    // Verificando de caso o usuario tem a permissao de ver o item de Menu
                    rn.acessoMenu(ref Menu, telasacesso[i].ToString(), ultimo);

                }
            }
        }
    }
}