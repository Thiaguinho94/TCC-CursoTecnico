using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pesq.BLL;
using Objeto;


namespace Pesq_Pedido
{
    public partial class frmPedido : Form
    {
        private Pedido ped = null;
        private BLL bll = new BLL();

        public frmPedido()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ped = new Pedido(int.Parse(txtCodPedido.Text.ToString())
                             , txtDescricaoProd.Text.ToString()
                             , mtxtValorUnitario.Text.ToString().Replace("R$", "")
                             , int.Parse(numPedido.Value.ToString())
                             , mtxtDataPedido.Text.ToString()
                             , mtxtDataPEntrega.Text.ToString()
                             , txtObs.Text.ToString()
                            );

        }
        private void btnSelcionarProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consulta = new frmConsultaProduto();
            consulta.ShowDialog();
            txtDescricaoProd.Text = consulta.Descricao_Produto;

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            mtxtDataPedido.Text = DateTime.Today.ToString();
        }

        private void lblDataEntrega_Click(object sender, EventArgs e)
        {

        }
    }
}
