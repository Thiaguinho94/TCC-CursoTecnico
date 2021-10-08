using System;
using System.Windows.Forms;

namespace Pesq_MenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PtbMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void PtbCaixa_Click(object sender, EventArgs e)
        {
            Pesq_Caixa.frmCaixa caixa = new Pesq_Caixa.frmCaixa();
            caixa.ShowDialog();
        }

        public void Abilitando_DesabilitandoCaixa(bool Abilitar)
        {
            ptbCaixa.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoCadastro(bool Abilitar)
        {
            ptbMenu.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoPesqueiro(bool Abilitar)
        {
            ptbPequeiro.Visible = Abilitar;
        }

        public void Abilitando_DesabilitandoMenu(bool Abilitar)
        {
            ptbMenu.Visible = Abilitar;
        }

        private void PtbPequeiro_Click(object sender, EventArgs e)
        {
            Pesq_Pesqueiro.frmPesqueiro pesq = new Pesq_Pesqueiro.frmPesqueiro();
            pesq.ShowDialog();
        }

        private void PtbGarcon_Click(object sender, EventArgs e)
        {
            Pesq_Garcon.frmGarcon garcon = new Pesq_Garcon.frmGarcon();
            garcon.ShowDialog();
        }

    }
}
