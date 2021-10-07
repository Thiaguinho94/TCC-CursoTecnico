using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pesq.BLL;

namespace Pesq_Caixa
{
    public partial class frmAddProduto : Form
    {
        public frmAddProduto()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();

        private void frmAddProduto_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.ObtemProduto2();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[i].Cells["Descricao_Prod"].Value = ds.Tables[0].Rows[i][""].ToString();
            
               
                
            }

            dgvProdutos.DataSource = ds.Tables[0];
            txtQtd.Select();
        }

        private void lblDescrição_Click(object sender, EventArgs e)
        {

        }

        private void gpbDadoProd_Enter(object sender, EventArgs e)
        {

        }

        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecoTotal_Click(object sender, EventArgs e)
        {

        }

        private void mtxtPrecoUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
