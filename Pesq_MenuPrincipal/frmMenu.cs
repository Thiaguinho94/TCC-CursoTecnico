using System;
using System.Windows.Forms;

namespace Pesq_MenuPrincipal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void LlbCadastro_Click(object sender, EventArgs e)
        {
            Pesq_Cadastro.frmCadastros Cad = new Pesq_Cadastro.frmCadastros();
            Cad.ShowDialog();
        }

        private void PtcConsulta_Click(object sender, EventArgs e)
        {
            Pesq_Consulta.frmConsultas Consulta = new Pesq_Consulta.frmConsultas();
            Consulta.ShowDialog();
        }

        private void PtcVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void LProduto_Click(object sender, EventArgs e)
        {
            Pesq_Produto.frmProduto prod = new Pesq_Produto.frmProduto();
            prod.ShowDialog();
        }

        private void PtcFinanca_Click(object sender, EventArgs e)
        {
            Visible = false;
            Pesq_Financas.frmFinancas financa = new Pesq_Financas.frmFinancas();
            financa.ShowDialog();
            Visible = true;

        }

        private void LPedido_Click(object sender, EventArgs e)
        {
            Pesq_Pedido.FrmPedido pedido = new Pesq_Pedido.FrmPedido();
            pedido.ShowDialog();
        }


        public void Abilitando_DesabilitandoConsultar(bool Abilitar)
        {
            ptcConsulta.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoCadastro(bool Abilitar)
        {
            ptcCadastro.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoPedido(bool Abilitar)
        {
            ptcPedido.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoFinancas(bool Abilitar)
        {
            ptcFinanca.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoProduto(bool Abilitar)
        {
            ptcProd.Visible = Abilitar;
        }
    }
}
