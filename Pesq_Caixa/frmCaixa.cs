using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void frmCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmTipoPagamento pag = new frmTipoPagamento();
            pag.ShowDialog();

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddProduto Adicionar_Prod = new frmAddProduto();
            Adicionar_Prod.ShowDialog();
        }
    }
}
