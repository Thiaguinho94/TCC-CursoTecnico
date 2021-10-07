using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pesq.BLL;

namespace Pesq_Pedido
{
    public partial class frmConsultaProduto : Form
    {
        BLL bll = new BLL();
        public string Descricao_Produto = "";

        public frmConsultaProduto()
        {
            InitializeComponent();
        }
        
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.ObtemProduto();
            dgvProduto.DataSource = ds.Tables[0];

            dgvProduto.Columns[0].HeaderText = "Descrição Produtos";
            dgvProduto.Columns[0].Width = 400;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Descricao_Produto = dgvProduto.Rows[e.RowIndex].Cells["Descricao_Prod"].Value.ToString();
            this.Close();

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisar = txtPesquisar.Text.ToString();

            DataSet ds = bll.ObtemProduto(pesquisar);
            dgvProduto.DataSource = ds.Tables[0];
        }
    }
}
