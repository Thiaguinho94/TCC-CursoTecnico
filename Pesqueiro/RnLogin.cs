using Pesq_MenuPrincipal;
using System.Data;


namespace Pesqueiro
{
    internal class RnLogin
    {
        private readonly FrmMenuPrincipal menuprincipal = new FrmMenuPrincipal();
        private readonly frmMenu menu = new frmMenu();

        public void AcessoCaixa(ref bool Caixa, string Tela_Vez, bool ultimo)
        {
            string telacesso_Caixa = "Caixa";
            if (telacesso_Caixa == Tela_Vez)
            {
                menuprincipal.Abilitando_DesabilitandoCaixa(true);
                Caixa = true;
            }
            else
            {
                if (ultimo && Caixa == false)
                {
                    menuprincipal.Abilitando_DesabilitandoCaixa(false);
                    Caixa = false;
                }
            }
        }

        public void AcessoCadastro(ref bool Cadastro, string Tela_Vez, bool ultimo)
        {
            string telacesso_Cadastro = "Cadastro";
            if (telacesso_Cadastro == Tela_Vez)
            {
                menuprincipal.Abilitando_DesabilitandoCadastro(true);
                Cadastro = true;
            }
            else
            {
                if (ultimo && Cadastro == false)
                {
                    menuprincipal.Abilitando_DesabilitandoCadastro(false);
                    Cadastro = false;
                }

            }
        }

        public void AcessoConsulta(ref bool Consulta, string Tela_Vez, bool ultimo)
        {
            string telacesso_Consulta = "Consultar";

            if (telacesso_Consulta == Tela_Vez)
            {
                menu.Abilitando_DesabilitandoConsultar(true);
                Consulta = true;
            }
            else
            {
                if (ultimo && Consulta == false)
                {
                    menu.Abilitando_DesabilitandoConsultar(false);
                    Consulta = false;
                }
            }


        }

        public void AcessoPedido(ref bool Pedido, string Tela_Vez, bool ultimo)
        {
            string telacesso_Pedido = "Pedido";

            if (telacesso_Pedido == Tela_Vez)
            {
                menu.Abilitando_DesabilitandoPedido(true);
                Pedido = true;
            }
            else
            {
                if (ultimo && Pedido == false)
                {
                    menu.Abilitando_DesabilitandoPedido(false);
                    Pedido = false;
                }
            }
        }

        public void AcessoProduto(ref bool Produto, string Tela_Vez, bool ultimo)
        {
            string telacesso_Produto = "Produto";

            if (telacesso_Produto == Tela_Vez)
            {
                menu.Abilitando_DesabilitandoProduto(true);
                Produto = true;
            }
            else
            {
                if (ultimo && Produto == false)
                {
                    menu.Abilitando_DesabilitandoProduto(false);
                    Produto = false;
                }
            }
        }

        public void AcessoPesquiero(ref bool Pesqueiro, string Tela_Vez, bool ultimo)
        {
            string telacesso_Pesqueiro = "Pesqueiro";

            if (telacesso_Pesqueiro == Tela_Vez)
            {
                menuprincipal.Abilitando_DesabilitandoPesqueiro(true);
                Pesqueiro = true;
            }
            else
            {
                if (ultimo && Pesqueiro == false)
                {
                    menuprincipal.Abilitando_DesabilitandoPesqueiro(false);
                    Pesqueiro = false;
                }
            }
        }

        public void AcessoFinanca(ref bool Financa, string Tela_Vez, bool ultimo)
        {
            string telacesso_Financa = "Financa";

            if (telacesso_Financa == Tela_Vez)
            {
                menu.Abilitando_DesabilitandoFinancas(true);
                Financa = true;

            }
            else
            {
                if (ultimo && Financa == false)
                {
                    menu.Abilitando_DesabilitandoFinancas(false);
                    Financa = false;
                }
            }
        }

        public void AcessoMenu(ref bool menu, string Tela_Vez, bool ultimo)
        {
            string telacesso_Menu = "Menu";

            if (telacesso_Menu == Tela_Vez)
            {
                menuprincipal.Abilitando_DesabilitandoMenu(true);
            }
            else if (ultimo && menu == false)
            {
                menuprincipal.Abilitando_DesabilitandoMenu(false);
            }
        }

        public void Validacao_Login(DataSet ds, ref bool RetornaSenha, string usuario, string senha)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (usuario == ds.Tables[0].Rows[i]["Usuario"].ToString() && senha == ds.Tables[0].Rows[i]["Senha"].ToString())
                { RetornaSenha = true; return; }
                else
                { RetornaSenha = false; continue; }
            }
        }
    }
}
