using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pesq_Financas
{
    public partial class frmFinancas : Form
    {
        public frmFinancas()
        {
            InitializeComponent();
        }

        private void btnLucro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmLucro lucro = new frmLucro();
            lucro.ShowDialog();
        }

        private void pnlDespesa_Click(object sender, EventArgs e)
        {
            frmDespesas desp = new frmDespesas();
            desp.ShowDialog();

        }
    }
}
