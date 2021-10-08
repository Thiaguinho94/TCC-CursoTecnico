using System;
using System.Data;
using System.Windows.Forms;
using Pesq.BLL;

namespace Pesq_Pedido
{
    public partial class frmConsultaProduto : Form
    {
        private readonly BLL bll = new BLL();
        public string Descricao_Produto = "";

        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.ObtemProduto();
            dgvProduto.DataSource = ds.Tables[0];

            dgvProduto.Columns[0].HeaderText = "Descrição Produtos";
            dgvProduto.Columns[0].Width = 400;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Descricao_Produto = dgvProduto.Rows[e.RowIndex].Cells["Descricao_Prod"].Value.ToString();
            Close();

        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisar = txtPesquisar.Text.ToString();

            DataSet ds = bll.ObtemProduto(pesquisar);
            dgvProduto.DataSource = ds.Tables[0];
        }
    }
}
