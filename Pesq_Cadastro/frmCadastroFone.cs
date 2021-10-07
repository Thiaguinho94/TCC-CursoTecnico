using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Pesq.BLL;

namespace Pesq_Cadastro
{
    public partial class frmCadastroFone : Form
    {
        private string cod_fun, cod_fornec, Tipo_Cad;
        BLL bll = new BLL();


        public frmCadastroFone()
        {
            InitializeComponent();
        }

        public frmCadastroFone(string Cod_funcionario, string cod_fornecerdor,string TipoCad)
        {
            // TODO: Complete member initializationi
            this.cod_fun = Cod_funcionario;
            this.cod_fornec = cod_fornecerdor;
            this.Tipo_Cad = TipoCad;
            InitializeComponent();
        }

        private void frmCadastroFone_Load(object sender, EventArgs e)
        {
            /*Quando passar o mouse nos botões irar aparecer as descrições de cada um */

            ttText.SetToolTip(btnSalvar, "Salvar Telefone");
            ttText.SetToolTip(btnLimpar, "Limpar Telefone Selecionado");
            ttText.SetToolTip(btnVoltar, "Voltar para Tela Principal");

            if (Tipo_Cad == "Fornecedor")
            {
                txtCodigo.Text = cod_fornec.ToString();
                cod_fun = "null";
            }
            else if (Tipo_Cad == "Funcionario")
            {
                txtCodigo.Text = cod_fun.ToString();
                cod_fornec = "null";
            }

            DataSet ds = bll.ObtemTelefones(cod_fun, cod_fornec);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Cod_Func"].ToString() != "")
                {
                    dgvFone.Rows.Add();
                    dgvFone.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i]["Cod_Func"].ToString();
                    dgvFone.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i]["Telefone"].ToString();

                    
                }
                else if (ds.Tables[0].Rows[i]["Cod_Fornec"].ToString() != "")
                {
                    dgvFone.Rows.Add();
                    dgvFone.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i]["Cod_Fornec"].ToString();
                    dgvFone.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i]["Telefone"].ToString();

                }
            }

            rdbFone.Select();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*Salvar no banco de Dados Todos os telefones que estiverem na datagrid*/

            
            int fone = 0;
            bool fun = false, Salvo = false;

            if (cod_fun != "null")
                fun = true;

            for (int i = 0; i < dgvFone.Rows.Count; i++)
            {
                if (fun == true)
                    cod_fun = dgvFone.Rows[i].Cells[0].Value.ToString();
                else
                    cod_fornec = dgvFone.Rows[i].Cells["Cod"].Value.ToString();

                fone = int.Parse(dgvFone.Rows[i].Cells["Telefone"].Value.ToString().Replace("-", ""));

                try
                {
                    bll.GravarTelefone(cod_fun, cod_fornec, fone);
                    Salvo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Salvo = false;
                    return;
                } 
            }
            if (Salvo == true)
                MessageBox.Show("salvo com sucesso!", "messagem", MessageBoxButtons.OK);
        }

        private void rdbFone_CheckedChanged(object sender, EventArgs e)
        {
            mtxtFone.Mask = "9999-9999";
            mtxtFone.Text = "";
            mtxtFone.Select();
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            mtxtFone.Mask = "99999-9999";
            mtxtFone.Text = "9";
            mtxtFone.Select();
        }

        private void mtxtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (mtxtFone.Text == "    -")
                {
                    MessageBox.Show("Digite Telefone para adicionar!!!", "ATENÇÃO");
                    return;
                }
                if (mtxtFone.Text.ToLower().Length < 9)
                {
                    MessageBox.Show("Telefone incompleto!!!", "ATENÇÃO");
                    mtxtFone.Select();
                    return;
                }
                if (dgvFone.Rows.Count != 0)
                {
                    for (int i = 0; i < dgvFone.Rows.Count; i++)
                    {
                        if (dgvFone.Rows[i].Cells["Telefone"].Value.ToString() == mtxtFone.Text.ToString())
                        {
                            MessageBox.Show("Telefone já Adicionado!!", "ATENÇÃO");
                            if (rdbCelular.Checked == true)
                                rdbCelular_CheckedChanged(sender, e);
                            else
                                rdbFone_CheckedChanged(sender, e);
                            mtxtFone.Select();
                            return;
                        }
                        else
                            continue;
                    }
                }
                dgvFone.Rows.Add();
                dgvFone.Rows[dgvFone.Rows.Count - 1].Cells["Telefone"].Value = mtxtFone.Text.ToString();
                dgvFone.Rows[dgvFone.Rows.Count - 1].Cells["Cod"].Value = txtCodigo.Text.ToString();

                if (rdbCelular.Checked == true)
                    rdbCelular_CheckedChanged(sender, e);
                else
                    rdbFone_CheckedChanged(sender, e);

                mtxtFone.Select();
            }
        }

        private void mtxtFone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
