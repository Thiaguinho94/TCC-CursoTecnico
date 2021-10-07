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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void llbCadastro_Click(object sender, EventArgs e)
        {
            Pesq_Cadastro.frmCadastros Cad = new Pesq_Cadastro.frmCadastros();
            Cad.ShowDialog();
        }

        private void ptcConsulta_Click(object sender, EventArgs e)
        {
            Pesq_Consulta.frmConsultas Consulta = new Pesq_Consulta.frmConsultas();
            Consulta.ShowDialog();
        }

        private void ptcVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void lProduto_Click(object sender, EventArgs e)
        {
            Pesq_Produto.frmProduto prod = new Pesq_Produto.frmProduto();
            prod.ShowDialog();
        }

        private void ptcFinanca_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pesq_Financas.frmFinancas financa = new Pesq_Financas.frmFinancas();
            financa.ShowDialog();
            this.Visible = true;

        }

        private void lPedido_Click(object sender, EventArgs e)
        {
            Pesq_Pedido.frmPedido pedido = new Pesq_Pedido.frmPedido();
            pedido.ShowDialog();
        }


        public void Abilitando_DesabilitandoConsultar(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptcConsulta.Visible = true;
            }
            else
            {
                ptcConsulta.Visible = false;
            }
        }

        public void Abilitando_DesabilitandoCadastro(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptcCadastro.Visible = true;
            }
            else
            {
                ptcCadastro.Visible = false;
            }
        }

        public void Abilitando_DesabilitandoPedido(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptcPedido.Visible = true;
            }
            else 
            {
                ptcPedido.Visible = false;
            }
        }

        public void Abilitando_DesabilitandoFinancas(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptcFinanca.Visible = true;
            }
            else
            {
                ptcFinanca.Visible = false;
            }
        }

        public void Abilitando_DesabilitandoProduto(bool Abilitar)
        {
            if (Abilitar == true)
            {
                ptcProd.Visible = true;
            }
            else
            {
                ptcProd.Visible = false;
            }
        }

        private void lblMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
