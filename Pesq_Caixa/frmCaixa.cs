using System;
using System.Windows.Forms;
using Pesq_Produto;

namespace Pesq_Caixa
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            FrmTipoPagamento pag = new FrmTipoPagamento();
            pag.ShowDialog();

        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            frmAddProduto Adicionar_Prod = new frmAddProduto();
            Adicionar_Prod.ShowDialog();
        }
    }
}
