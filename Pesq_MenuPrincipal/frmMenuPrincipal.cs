using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pesq_MenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void ptbCaixa_Click(object sender, EventArgs e)
        {
            Pesq_Caixa.frmCaixa caixa = new Pesq_Caixa.frmCaixa();
            caixa.ShowDialog();


        }

        public void Abilitando_DesabilitandoCaixa(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptbCaixa.Visible = true;
                

            }
            else
            {

                ptbCaixa.Visible = false;
            }

        }

        public void Abilitando_DesabilitandoCadastro(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptbMenu.Visible = true;
             

            }
            else
            {

                ptbMenu.Visible = false;
            }

        }

        public void Abilitando_DesabilitandoPesqueiro(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptbPequeiro.Visible = true;

            }
            else
            {
                ptbPequeiro.Visible = false;
            }

        }

        private void ptbPequeiro_Click(object sender, EventArgs e)
        {
            Pesq_Pesqueiro.frmPesqueiro pesq = new Pesq_Pesqueiro.frmPesqueiro();
            pesq.ShowDialog();
        }

        private void ptbGarcon_Click(object sender, EventArgs e)
        {
            Pesq_Garcon.frmGarcon garcon = new Pesq_Garcon.frmGarcon();
            garcon.ShowDialog();
        }

    }
}
