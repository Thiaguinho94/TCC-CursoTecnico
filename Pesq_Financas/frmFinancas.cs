using System;
using System.Windows.Forms;

namespace Pesq_Financas
{
    public partial class frmFinancas : Form
    {
        public frmFinancas()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            frmLucro lucro = new frmLucro();
            lucro.ShowDialog();
        }

        private void PnlDespesa_Click(object sender, EventArgs e)
        {
            frmDespesas desp = new frmDespesas();
            desp.ShowDialog();
        }
    }
}
