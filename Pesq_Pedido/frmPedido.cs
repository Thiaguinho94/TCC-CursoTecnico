using System;
using System.Windows.Forms;
using Pesq.BLL;
using Objeto;


namespace Pesq_Pedido
{
    public partial class FrmPedido : Form
    {
        private Pedido ped = null;
        private readonly BLL bll = new BLL();

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
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
        private void BtnSelcionarProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consulta = new frmConsultaProduto();
            consulta.ShowDialog();
            txtDescricaoProd.Text = consulta.Descricao_Produto;

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            mtxtDataPedido.Text = DateTime.Today.ToString();
        }
    }
}
