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


namespace Pesq_Consulta
{
    public partial class frmConsultas : Form
    {
        BLL bll = new BLL();
        public frmConsultas()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds;

            if (cmbConsultar.Text == "Funcionário")
            {
                ds = bll.ObtemFuncionario();
                dgvConsulta.DataSource = null;
                dgvConsulta.DataSource = ds.Tables[0];
            }
            else
            {
                ds = bll.ObtemFornecedor();
                dgvConsulta.DataSource = null;
                dgvConsulta.DataSource = ds.Tables[0];

            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            string pesquisa = txtPesquisar.Text.ToString().Trim();
            DataSet ds = null;
            if (cmbConsultar.Text == "Funcionário")
                ds = bll.ObtemFuncionario(pesquisa);//THIAGO: Pegando a pesquisa que o usuario quer e filtrando os funcionario que foi desejados.
            else
                ds = bll.ObtemFornecedor(pesquisa);//THIAGO: Pegando a pesquisa que o usuario quer e filtrando os fornecedor que foi desejados.

            if (pesquisa == "")
            {
                if (cmbConsultar.Text == "Funcionário")
                {
                    ds = bll.ObtemFuncionario();
                    dgvConsulta.DataSource = ds.Tables[0];
                }
                else
                {
                    ds = bll.ObtemFornecedor();
                    dgvConsulta.DataSource = ds.Tables[0];
                }
            }
            else
                dgvConsulta.DataSource = ds.Tables[0];
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;


            if (cmbConsultar.Text == "Funcionário")
            {
                Funcionario func = new Funcionario(int.Parse(dgvConsulta.Rows[e.RowIndex].Cells["Cod_Func"].Value.ToString())
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Nome_Func"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Data_Nasc"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["RG"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["CPF"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Email_Func"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Sexo"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Tipo_Contrato"].Value.ToString()
                                                   , int.Parse(dgvConsulta.Rows[e.RowIndex].Cells["Carteira_Prof"].Value.ToString())
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Data_Adm"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cargo"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Departamento"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Salario"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Observacao"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cep"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Endereco"].Value.ToString()
                                                   , int.Parse(dgvConsulta.Rows[e.RowIndex].Cells["Numero"].Value.ToString())
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Complemento"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Bairro"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cidade"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["UF"].Value.ToString());

                Pesq_Cadastro.frmCadastros Cadast_func = new Pesq_Cadastro.frmCadastros(func);
                Cadast_func.ShowDialog();
            }
            else if (cmbConsultar.Text == "Fornecedor")
            {

                Fornecedor fornec = new Fornecedor(int.Parse(dgvConsulta.Rows[e.RowIndex].Cells["Cod_Fornec"].Value.ToString())
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cnpj"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Razao_Social"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Nome_Fantasia"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Representante"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Email_Fornec"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Observacao"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cep"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Endereco"].Value.ToString()
                                                   , int.Parse(dgvConsulta.Rows[e.RowIndex].Cells["Numero"].Value.ToString())
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Complemento"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Bairro"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["Cidade"].Value.ToString()
                                                   , dgvConsulta.Rows[e.RowIndex].Cells["UF"].Value.ToString());

                Pesq_Cadastro.frmCadastros Cadast_Fornec = new Pesq_Cadastro.frmCadastros(fornec);
                Cadast_Fornec.ShowDialog();
            }

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            txtPesquisar.Select();
            cmbConsultar.SelectedIndex = 0;
        }

        private void dgvConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (cmbConsultar.Text == "Funcionário")
                {
                    Funcionario func = new Funcionario(int.Parse(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cod_Func"].Value.ToString())
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Nome_Func"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Data_Nasc"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["RG"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["CPF"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Email_Func"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Sexo"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Tipo_Contrato"].Value.ToString()
                                                  , int.Parse(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Carteira_Prof"].Value.ToString())
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Data_Adm"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cargo"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Departamento"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Salario"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Observacao"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cep"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Endereco"].Value.ToString()
                                                  , int.Parse(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Numero"].Value.ToString())
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Complemento"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Bairro"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cidade"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["UF"].Value.ToString());
                    try
                    {
                        DialogResult result = MessageBox.Show("Deseja deletar o funcioanrio " + func.Nome_Funcionario + " ?", "Atenção!", MessageBoxButtons.YesNo);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                {
                                    bll.DeletarFuncionario(func);
                                    MessageBox.Show("Funcionario " + func.Nome_Funcionario + " deletado com sucesso!", "EXCLUIR");
                                    cmbConsultar_SelectedIndexChanged(sender, e);
                                    break;
                                }
                            case DialogResult.No:
                                {
                                    break;
                                }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else if (cmbConsultar.Text == "Fornecedor")
                {
                    Fornecedor fornec = new Fornecedor(int.Parse(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cod_Fornec"].Value.ToString())
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cnpj"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Razao_Social"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Nome_Fantasia"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Representante"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Email_Fornec"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Observacao"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cep"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Endereco"].Value.ToString()
                                                  , int.Parse(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Numero"].Value.ToString())
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Complemento"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Bairro"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["Cidade"].Value.ToString()
                                                  , dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells["UF"].Value.ToString());
                    try
                    {

                        DialogResult result = MessageBox.Show("Deseja deletar o fornecedor " + fornec.Nome_Fantasia + " ?", "Atenção!", MessageBoxButtons.YesNo);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                {
                                    bll.DeletarFornecedor(fornec);
                                    MessageBox.Show("Fornecedor " + fornec.Nome_Fantasia + " deletado com sucesso!", "EXCLUIR");
                                    cmbConsultar_SelectedIndexChanged(sender, e);
                                    break;
                                }
                            case DialogResult.No:
                                {
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }
    }
}