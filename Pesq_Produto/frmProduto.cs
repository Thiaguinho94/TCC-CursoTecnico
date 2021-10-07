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

namespace Pesq_Produto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();

        private void frmCad_Produto_Load(object sender, EventArgs e)
        {
            /* na parte de Fornecedor ira carregar todos os fornecedores que 
             * esteja cadastro no banco de dados para salvar o cod deele junto com o Produtos.
             */

            DataSet ds = bll.ObtemFornecedor();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmbFornecedor.Items.Add(ds.Tables[0].Rows[i]["Razao_Social"].ToString());

            ds.Clear();
            //THIAGO: Adicionando Todos os produtos do banco dentro da Datagrid
            ds = bll.ObtemProduto2();
            dgvProdutos.DataSource = ds.Tables[0];


            DataSet dss = bll.ObtemCategoria();
            for (int i = 0; i < dss.Tables[0].Rows.Count; i++)
                cmbSecao.Items.Add(dss.Tables[0].Rows[i]["Categoria"].ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodProd.Text = "";
            txtDescricao.Text = "";
            numQtdNova.Value = 1;
            cmbFornecedor.Text = "";
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;


            Produto prod = new Produto(int.Parse(dgvProdutos.Rows[e.RowIndex].Cells["Cod_Prod"].Value.ToString())
                                 , dgvProdutos.Rows[e.RowIndex].Cells["Descricao_Prod"].Value.ToString()
                                 , int.Parse(dgvProdutos.Rows[e.RowIndex].Cells["Cod_Fornecedor"].Value.ToString())
                                 , int.Parse(dgvProdutos.Rows[e.RowIndex].Cells["Qtde_Prod"].Value.ToString())
                                 , dgvProdutos.Rows[e.RowIndex].Cells["Preco_Custo"].Value.ToString()
                                 , dgvProdutos.Rows[e.RowIndex].Cells["Preco_Venda"].Value.ToString()
                                 );

            cmbSecao.Text = dgvProdutos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            AtribuindoValores(prod);

        }

        private void AtribuindoValores(Produto prod)
        {
            txtCodProd.Text = prod.Codigo_Produto.ToString();
            txtDescricao.Text = prod.Descricao_Produto;
            
            mtxtPrecoVenda.Text = prod.Preco_Venda;
            numQtdNova.Value = prod.Quantidade_Nova;

            string[] Valor_Desp = prod.Preco_Custo.Split(',');
            if (Valor_Desp[0].Length == 1)
            {
                mtxtPrecoCusto.Mask = "$9.99";
                mtxtPrecoCusto.Text = prod.Preco_Custo;    
            }
            else if (Valor_Desp[0].Length == 2)
            {
                mtxtPrecoCusto.Mask = "$99.99";
                mtxtPrecoCusto.Text = prod.Preco_Custo;
            }
            else if (Valor_Desp[0].Length == 3)
            {
                mtxtPrecoCusto.Mask = "$999.99";
                mtxtPrecoCusto.Text = prod.Preco_Custo;
            }
            else if (Valor_Desp[0].Length == 4)
            {
                mtxtPrecoCusto.Mask = "$9999.99";
                mtxtPrecoCusto.Text = prod.Preco_Custo;
            }


            string[] Valor_Desp2 = prod.Preco_Venda.Split(',');
            if (Valor_Desp2[0].Length == 1)
            {
                mtxtPrecoVenda.Mask = "$9.99";
                mtxtPrecoVenda.Text = prod.Preco_Venda;
            }
            else if (Valor_Desp2[0].Length == 2)
            {
                mtxtPrecoVenda.Mask = "$99.99";
                mtxtPrecoVenda.Text = prod.Preco_Venda;
            }
            else if (Valor_Desp2[0].Length == 3)
            {
                mtxtPrecoVenda.Mask = "$999.99";
                mtxtPrecoVenda.Text = prod.Preco_Venda;
            }
            else if (Valor_Desp2[0].Length == 4)
            {
                mtxtPrecoVenda.Mask = "$9999.99";
                mtxtPrecoVenda.Text = prod.Preco_Venda;
            }



            DataSet ds =  bll.ObtemFornecedor(prod.Codigo_Fornecedor.ToString());
            for (int i = 0; i < cmbFornecedor.Items.Count; i++)
			{
                if (cmbFornecedor.Items[i].ToString() == ds.Tables[0].Rows[0]["Razao_Social"].ToString())
                    cmbFornecedor.SelectedIndex = i;
			}
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
