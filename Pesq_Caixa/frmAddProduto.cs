using System;
using System.Data;
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

        private readonly BLL bll = new BLL();

        private void FrmAddProduto_Load(object sender, EventArgs e)
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
    }
}
