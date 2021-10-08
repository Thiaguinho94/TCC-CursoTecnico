using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Pesq.BLL;
using Objeto;


namespace Pesq_Financas
{
    public partial class frmDespesas : Form
    {

        private readonly BLL bll = new BLL();
        private Despesa desp = new Despesa();
        private string Status_desp;

        public frmDespesas()
        {
            InitializeComponent();
        }

        #region Enventos do form

        private void RdbStatus_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaDesp.Visible = false;
            cmbStatus.Visible = true;
            cmbStatus.Location = txtPesquisaDesp.Location;
        }

        private void RdbCodDescri_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaDesp.Visible = true;
            cmbStatus.Visible = false;
        }

        private void FrmDespesas_Load(object sender, EventArgs e)
        {
            rdbCodDescri.Checked = true;
            DataSet ds = bll.ObtemDespesa();
            AdicionandoDespesas(ds);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            txtDecriDesp.Text = "";
            txtObs.Text = "";
            txtPesquisaDesp.Text = "";
            mtxtValorDesp.Text = "";
            mtxtDataPagamento.Text = DateTime.Today.ToString();
            mtxtDataVencimento.Text = DateTime.Today.ToString();
            rdbPago.Checked = false;
            rdbNaoPago.Checked = false;


            btnSalvar.Visible = true;
            btnEditar.Visible = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string valor_despesa = mtxtValorDesp.Text.ToString().Replace("R$", "");
            string data_venc = Convert.ToDateTime(mtxtDataVencimento.Text).ToString("yyyy/MM/dd");
            string data_pg = mtxtDataPagamento.Text != "  /  /" ? Convert.ToDateTime(mtxtDataPagamento.Text).ToString("yyyy/MM/dd") : null;
            desp = new Despesa(txtDecriDesp.Text.ToString()
                               , data_pg
                               , data_venc
                               , valor_despesa
                               , Status_desp
                               , txtObs.Text.ToString()
                              );

            try
            {
                bll.GravarDespesa(desp);
                MessageBox.Show("Despesa salva com sucesso!", "SALVAR", MessageBoxButtons.OK);
                FrmDespesas_Load(sender, e);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RdbPago_CheckedChanged(object sender, EventArgs e)
        {
            Status_desp = "PG";

            lblDataVencimento.Location = new Point(311, 78);
            mtxtDataVencimento.Location = new Point(314, 103);

            lblDataPagamento.Visible = true;
            mtxtDataPagamento.Visible = true;

            lblDataPagamento.Location = new Point(158, 78);
            mtxtDataPagamento.Location = new Point(161, 101);

        }

        private void RdbNaoPago_CheckedChanged(object sender, EventArgs e)
        {
            Status_desp = "NPG";

            lblDataPagamento.Visible = false;
            mtxtDataPagamento.Visible = false;

            lblDataVencimento.Location = lblDataPagamento.Location;
            mtxtDataVencimento.Location = mtxtDataPagamento.Location;
        }

        private void TxtPesquisaDesp_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaDesp.Text.ToString().Trim();
            DataSet ds = null;

            if (pesquisa == "")
            {
                ds = bll.ObtemDespesa();
                AdicionandoDespesas(ds);
                return;
            }

            try
            {
                ds = bll.ObtemDespesa(pesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            AdicionandoDespesas(ds);

        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds;
            if (cmbStatus.Text == "Não Pago")
            {
                ds = bll.ObtemDespesa("NPG");
                AdicionandoDespesas(ds);
            }
            else
            {
                ds = bll.ObtemDespesa("PG");
                AdicionandoDespesas(ds);
            }
        }

        private void DgvDespesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            Despesa dsp = new Despesa(int.Parse(dgvDespesas.Rows[e.RowIndex].Cells["Codigo_Despesa"].Value.ToString())
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Descricao_Despesa"].Value.ToString()
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Data_Pagamento"].Value.ToString()
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Data_Vencimento"].Value.ToString()
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Valor_Despesa"].Value.ToString()
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Status_Conta"].Value.ToString()
                                       , dgvDespesas.Rows[e.RowIndex].Cells["Obs"].Value.ToString()
                                       );

            AtribuindoValoresEditar(dsp);
            btnEditar.Location = btnSalvar.Location;
            btnSalvar.Visible = false;
            btnEditar.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //THIAGO: irar pegar a despesa deseja e alterar as informações que o usuario tem para mudar

            Despesa dsp = new Despesa(int.Parse(txtCodigo.Text.ToString())
                                  , txtDecriDesp.Text.ToString()
                                 , mtxtDataPagamento.Text.ToString()
                                 , mtxtDataVencimento.Text.ToString()
                                 , mtxtValorDesp.Text.ToString().Replace("R$", "")
                                 , Status_desp
                                 , txtObs.Text.ToString());

            try
            {
                bll.AtualizarDespesa(dsp);
                MessageBox.Show("Atualizado Despesa " + dsp.Descricao_Despesa + " com sucesso", "UPDATE");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                Despesa dsp = new Despesa(int.Parse(dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Codigo_Despesa"].Value.ToString())
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Descricao_Despesa"].Value.ToString()
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Data_Pagamento"].Value.ToString()
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Data_Vencimento"].Value.ToString()
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Valor_Despesa"].Value.ToString()
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Status_Conta"].Value.ToString()
                                       , dgvDespesas.Rows[dgvDespesas.CurrentRow.Index].Cells["Obs"].Value.ToString()
                                       );
                try
                {
                    DialogResult result = MessageBox.Show("Deseja deletar a despesa " + dsp.Descricao_Despesa + " ?", "Atenção!", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {
                                bll.DeletarDespesa(dsp);
                                MessageBox.Show("Despesa " + dsp.Descricao_Despesa + " foi removida com sucesso!", "EXCLUIR");
                                FrmDespesas_Load(sender, e);
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }

                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Ignore:
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        #endregion


        #region Metodos

        private void AtribuindoValoresEditar(Despesa dsp)
        {
            string[] Valor_Desp = dsp.Valor_Despesa.Split(',');
            switch (Valor_Desp[0].Length)
            {
                case 1:
                    dsp.Valor_Despesa = "   " + Valor_Desp[0] + "," + Valor_Desp[1];
                    break;
                case 2:
                    dsp.Valor_Despesa = "  " + Valor_Desp[0] + "," + Valor_Desp[1];
                    break;
                case 3:
                    dsp.Valor_Despesa = " " + Valor_Desp[0] + "," + Valor_Desp[1];
                    break;
                default:
                    break;
            }

            txtCodigo.Text = dsp.Codigo_Despesa.ToString();
            txtDecriDesp.Text = dsp.Descricao_Despesa;
            mtxtDataPagamento.Text = dsp.Data_Pagamento;
            mtxtDataVencimento.Text = dsp.Data_Vencimento;
            txtObs.Text = dsp.Observacao_Despesa;
            mtxtValorDesp.Text = dsp.Valor_Despesa;

            if (dsp.Status_Despesa == "Não Pago")
            {
                rdbNaoPago.Checked = true;
            }
            else
            {
                rdbPago.Checked = true;
            }
        }

        private void AdicionandoDespesas(DataSet ds)
        {
            dgvDespesas.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Status_Conta"].ToString() == "NPG")
                {
                    AdicionadoDespNaoPaga(i, ds);
                }
                else
                {
                    AdicionadoDespPaga(i, ds);
                }
            }
        }

        private void AdicionadoDespPaga(int i, DataSet ds)
        {
            dgvDespesas.Rows.Add();
            dgvDespesas.Rows[i].Cells["Codigo_Despesa"].Value = ds.Tables[0].Rows[i]["Cod_Desp"].ToString();
            dgvDespesas.Rows[i].Cells["Descricao_Despesa"].Value = ds.Tables[0].Rows[i]["Descricao_Desp"].ToString();
            dgvDespesas.Rows[i].Cells["Valor_Despesa"].Value = ds.Tables[0].Rows[i]["Valor_Despesa"].ToString();
            dgvDespesas.Rows[i].Cells["Data_Pagamento"].Value = Convert.ToDateTime(ds.Tables[0].Rows[i]["Data_Pagamento"]).ToString("dd/MM/yyyy");
            dgvDespesas.Rows[i].Cells["Data_Vencimento"].Value = Convert.ToDateTime(ds.Tables[0].Rows[i]["Data_Vencimento"]).ToString("dd/MM/yyyy");
            dgvDespesas.Rows[i].Cells["Status_Conta"].Value = "Pago";
            dgvDespesas.Rows[i].Cells["Obs"].Value = ds.Tables[0].Rows[i]["Obs"].ToString();

        }

        private void AdicionadoDespNaoPaga(int i, DataSet ds)
        {
            dgvDespesas.Rows.Add();
            dgvDespesas.Rows[i].Cells["Codigo_Despesa"].Value = ds.Tables[0].Rows[i]["Cod_Desp"].ToString();
            dgvDespesas.Rows[i].Cells["Descricao_Despesa"].Value = ds.Tables[0].Rows[i]["Descricao_Desp"].ToString();
            dgvDespesas.Rows[i].Cells["Valor_Despesa"].Value = ds.Tables[0].Rows[i]["Valor_Despesa"].ToString();
            dgvDespesas.Rows[i].Cells["Data_Pagamento"].Value = "-";
            dgvDespesas.Rows[i].Cells["Data_Vencimento"].Value = Convert.ToDateTime(ds.Tables[0].Rows[i]["Data_Vencimento"]).ToString("dd/MM/yyyy");
            dgvDespesas.Rows[i].Cells["Status_Conta"].Value = "Não Pago";
            dgvDespesas.Rows[i].Cells["Obs"].Value = ds.Tables[0].Rows[i]["Obs"].ToString();
        }

        #endregion
    }
}