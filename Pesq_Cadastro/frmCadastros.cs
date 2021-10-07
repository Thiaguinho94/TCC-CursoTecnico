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
using System.Text.RegularExpressions;
using System.IO;
using System.Net;


namespace Pesq_Cadastro
{
    public partial class frmCadastros : Form
    {

        Funcionario func = null; 
        Fornecedor fornec = null;

        RnCadastro rn = new RnCadastro();
        BLL bll = new BLL();
        DataSet ds_func = null, ds_fornec = null;
        

        public frmCadastros()
        {
            InitializeComponent();
        }

        public frmCadastros(Funcionario f)
        {
            func = f;
            InitializeComponent();
        }

        public frmCadastros(Fornecedor f)
        {
            fornec = f;
            InitializeComponent();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            /*Chama a tela de cadastros de n telefones*/
            frmCadastroFone CadFones = new frmCadastroFone(txtCodigoFunc.Text.ToString(), txtCodFornce.Text.ToString(), cmbTipoCad.Text);
            CadFones.ShowDialog();
        }

        private void frmCadastros_Load(object sender, EventArgs e)
        {
            if (func != null)
                LerFuncionario();

            else if (fornec != null)
                LerFornecedor();

            else
            {
                Pegando_CodigoFF();
                cmbTipoCad.SelectedIndex = 0;
            }

        }

        private void cmbTipoCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCad.Text == "Fornecedor")
            {
                tbcCadastro.SelectedIndex = 1;
                gpbDadosResidencias.Visible = true;
                btnTelefone.Visible = true;
            }
            else if (cmbTipoCad.Text == "Funcionario")
            {
                tbcCadastro.SelectedIndex = 0;
                gpbDadosResidencias.Visible = true;
                btnTelefone.Visible = true;
            }
            else if (cmbTipoCad.Text == "Usuario/Senha")
            {
                tbcCadastro.SelectedIndex = 2;
                /* Colocar todos os funcionario na combobox para Cadastrar Usuario/Senha*/
                ds_func = bll.ObtemFuncionario();
                cmbNomeFunc.Items.Clear();

                for (int i = 0; i < ds_func.Tables[0].Rows.Count; i++)
                    cmbNomeFunc.Items.Add(ds_func.Tables[0].Rows[i]["Nome_Func"]);
                btnTelefone.Visible = false;
                gpbDadosResidencias.Visible = false;
            }
        }

        private void mtxtCep_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCep.Text.ToLower().Length < 9)
            {
                if (txtEnd.Text != "")
                {
                    txtEnd.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    cmbUF.Text = "";
                    txtNum.Text = "";
                    txtCompl.Text = "";
                }
                return;
            }
            if (txtEnd.Text != "")
                return;
           /*
           * Verifica se o cep digitado é válido.
           */
            Match regex = Regex.Match(mtxtCep.Text.ToString().Replace("-", "").Trim(), "^[0-9]{8}$");

            /**
             * Se o CEP digitado for valido...
             */
            if (regex.Success)
            {
                try
                {
                    /*
                    CEP a ser pesquisado 
                    */
                    string cep = mtxtCep.Text.ToString().Replace("-", "").Trim();

                    /**
                     * Cria a requisição
                     */
                    HttpWebRequest Request =
                        (HttpWebRequest)WebRequest.Create("http://www.buscacep.correios.com.br/servicos/dnec/consultaEnderecoAction.do");

                    /**
                     * Define o que será postado
                     */
                    string postData = "relaxation=" + cep + "&TipoCep=ALL&semelhante=N&Metodo=listaLogradouro&TipoConsulta=relaxation&StartRow=1&EndRow=10&cfm=1";

                    /**
                     * Converte a string de post para um ByteStream
                     */
                    byte[] postBytes = Encoding.ASCII.GetBytes(postData);

                    /**
                     * Parâmetros da requisição
                     */
                    Request.Method = "POST";
                    Request.ContentType = "application/x-www-form-urlencoded";
                    Request.ContentLength = postBytes.Length;
                    Stream requestStream = Request.GetRequestStream();
                    /**
                     * Envia Requisição
                     */
                    requestStream.Write(postBytes, 0, postBytes.Length);
                    requestStream.Close();

                    /**
                     * Resposta do servidor dos correios
                     */
                    HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
                    /**
                     * String com a resposta do servidor
                     */
                    string responseText = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();
                    /**
                     * Separa os dados com expressão regular
                     */
                    MatchCollection matches = Regex.Matches(responseText, ">(.*?)</td>");

                    /**
                     * Exibe os dados recebidos
                     */
                    UTF8Encoding utf8 = new UTF8Encoding();

                    /**
                     * Passa o texto convertido para a textBox
                     */
                    txtEnd.Text = matches[0].Groups[1].ToString();
                    txtBairro.Text = matches[1].Groups[1].ToString();
                    txtCidade.Text = matches[2].Groups[1].ToString();
                    cmbUF.Text = matches[3].Groups[1].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("! Erro na execução: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Cep invalido");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Pegando_CodigoFF();

            if (cmbTipoCad.Text == "Fornecedor")
            {
                mtxtCnpj.Text = "";
                txtRazaoSocial.Text = "";
                txtNomeFantasia.Text = "";
                txtRepresentante.Text = "";
                txtEmailFornec.Text = "";
                LimparEnd();
            }
            else if (cmbTipoCad.Text == "Funcionario")
            {
                txtNomeFunc.Text = "";
                mtxtDataNascimento.Text = DateTime.Today.ToString();
                mtxtRg.Text = "";
                mtxtCpf.Text = "";
                txtEmaiFun.Text = "";
                rdMasc.Checked = false;
                rdFemi.Checked = false;
                cmbTipoContratacao.SelectedIndex = 0;
                mtxtCarteira.Text = "";
                cmbCargo.SelectedIndex = 0;
                mtxtSalario.Text = "";
                mtxtDataAdm.Text = DateTime.Today.ToString();
                cmbDepto.SelectedIndex = 0;
                LimparEnd();
            }
            else if (cmbTipoCad.Text == "Usuario/Senha")
            {
                cmbNomeFunc.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtCofirmaSenha.Text = "";

            }
        }

        private void LimparEnd()
        {
            mtxtCep.Text = "";
            txtEnd.Text = "";
            txtNum.Text = "";
            txtCompl.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbUF.Text = "";
        }

        private void mtxtCpf_TextChanged(object sender, EventArgs e)
        {
            if (mtxtCpf.Text.ToString().Replace(",", "").Replace("-", "").Length != 11)
            {
                mtxtCpf.ForeColor = Color.Black;
                return;
            }
            bool CPF = rn.isCPF(mtxtCpf.Text.ToString().Replace(",", "").Replace("-", ""));

            if (mtxtCpf.Text.ToString().Replace(",", "").Replace("-", "") == "")
                mtxtCpf.ForeColor = Color.Black;
            else if (CPF == false)
                mtxtCpf.ForeColor = Color.Red;
            else 
                mtxtCpf.ForeColor = Color.Green;
        }

        private void txtCofirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtCofirmaSenha.Text)
                txtCofirmaSenha.ForeColor = Color.Green;
            else
                txtCofirmaSenha.ForeColor = Color.Red;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();

            
            if (cmbTipoCad.Text != "Usuario/Senha")
            {
                VerificandoVazio("Endereco"); 
                /* Pegando valores da parte Residencial que tem  no Cadastro*/
                end.cep = mtxtCep.Text.ToString().Replace("-", "").ToString();
                end.endereco = txtEnd.Text.ToString();
                end.Numero = int.Parse(txtNum.Text.ToString());
                end.Complemto = txtCompl.Text.ToString();
                end.Bairro = txtBairro.Text.ToString();
                end.Cidade = txtCidade.Text.ToString();
                end.UF = cmbUF.Text.ToString();
            }

                /*Cadastro de Funcionario*/
            if (cmbTipoCad.Text == "Funcionario")
            {
                VerificandoVazio("Funcionario");
                GravandoFuncionario(end);
            }

                /*Cadastro de Usuario e senha*/
            else if (cmbTipoCad.Text == "Usuario/Senha")
            {
                VerificandoVazio("Usuario/Senha");
                GravandoUsuarioSenha();
            }
            /*Cadastro de Fornecedor*/
            else if (cmbTipoCad.Text == "Fornecedor")
            {
                VerificandoVazio("Fornecedor");
                GravandoFornecedor(end);
            }
        }

        private void VerificandoVazio(string nome)
        {
            if (nome == "Funcionario")
            {
                if (txtNomeFunc.Text == "")
                {
                    txtNomeFunc.BackColor = Color.Red;
                }
            }
            else if (nome == "Endereco")
            {
 
            }

            else if (nome == "Usuario/Senha")
            { }
            else if (nome == "Fornecedor")
            { }
        }

        

        private void tbcCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCad.Text != tbcCadastro.SelectedTab.Name)
            {
                if (cmbTipoCad.Text == "Fornecedor")
                {
                    tbcCadastro.SelectedIndex = 1;
                    gpbDadosResidencias.Visible = true;
                }
                else if (cmbTipoCad.Text == "Funcionario")
                {
                    tbcCadastro.SelectedIndex = 0;
                    gpbDadosResidencias.Visible = true;
                }
                else if (cmbTipoCad.Text == "Usuario/Senha")
                {
                    tbcCadastro.SelectedIndex = 2;
                    /* Colocar todos os funcionario na combobox para Cadastrar Usuario/Senha*/
                    ds_func = bll.ObtemFuncionario();
                    cmbNomeFunc.Items.Clear();

                    for (int i = 0; i < ds_func.Tables[0].Rows.Count; i++)
                        cmbNomeFunc.Items.Add(ds_func.Tables[0].Rows[i]["Nome_Func"]);
                    gpbDadosResidencias.Visible = false;
                }

            }
        }

        

        private void LerFornecedor()
        {
            txtCodFornce.Text = fornec.Codigo_Fornecedor.ToString();
            mtxtCnpj.Text = fornec.CNPJ.ToString();
            txtRazaoSocial.Text = fornec.Razao_Social;
            txtNomeFantasia.Text = fornec.Nome_Fantasia;
            txtRepresentante.Text = fornec.Representante;
            txtEmailFornec.Text = fornec.Email_Fornecedor;
            mtxtCep.Text = fornec.cep;
            txtEnd.Text = fornec.endereco;
            txtNum.Text = fornec.Numero.ToString();
            txtCompl.Text = fornec.Complemto;
            txtBairro.Text = fornec.Bairro;
            txtCidade.Text = fornec.Cidade;
            cmbUF.Text = fornec.UF;
            cmbTipoCad.SelectedIndex = 1;

        }

        private void LerFuncionario()
        {
            txtCodigoFunc.Text = func.Codigo_Funcionario.ToString();
            txtNomeFunc.Text = func.Nome_Funcionario;
            mtxtDataNascimento.Text = func.Data_Nascimento;
            mtxtRg.Text = func.RG;
            mtxtCpf.Text = func.CPF;
            txtEmaiFun.Text = func.Email_Funcionario;

            if (func.Sexo == rdMasc.Text)
                rdMasc.Checked = true;
            else
                rdFemi.Checked = true;

            cmbTipoContratacao.Text = func.Tipo_Contrato;
            mtxtCarteira.Text = func.Carteira_Profissional.ToString();
            cmbCargo.Text = func.Cargo;

            VerificandoSalario(func);

            mtxtSalario.Text = func.Salario.ToString();
            mtxtDataAdm.Text = func.Data_Admissao;
            cmbDepto.Text = func.Departamento;
            mtxtCep.Text = func.cep;
            txtEnd.Text = func.endereco;
            txtNum.Text = func.Numero.ToString();
            txtCompl.Text = func.Complemto;
            txtBairro.Text = func.Bairro;
            txtCidade.Text = func.Cidade;
            cmbUF.Text = func.UF;
            cmbTipoCad.SelectedIndex = 0;
        }

        private void VerificandoSalario(Objeto.Funcionario func)
        {
            string[] Salario_func = func.Salario.Split(',');
            if (Salario_func[0].Length == 1)
                func.Salario = "000" + Salario_func[0] + "," + Salario_func[1];
            else if (Salario_func[0].Length == 2)
                func.Salario = "00" + Salario_func[0] + "," + Salario_func[1];
            else if (Salario_func[0].Length == 3)
                func.Salario = "0" + Salario_func[0] + "," + Salario_func[1];
        }

        private void GravandoFornecedor(Endereco end)
        {
            Fornecedor fornec = new Fornecedor(int.Parse(txtCodFornce.Text.ToString())
                                                  , mtxtCnpj.Text.ToString().Replace(",", "").Replace("/", "").Replace("-", "")
                                                  , txtRazaoSocial.Text.ToString()
                                                  , txtNomeFantasia.Text.ToString()
                                                  , txtRepresentante.Text.ToString()
                                                  , txtEmailFornec.Text.ToString()
                                                  , null
                                                  , end.cep
                                                  , end.endereco
                                                  , end.Numero
                                                  , end.Complemto
                                                  , end.Bairro
                                                  , end.Cidade
                                                  , end.UF);
            try
            {
                bll.GravarFornecedor(fornec);
                MessageBox.Show("Fornecedor salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GravandoUsuarioSenha()
        {
            DataSet ds = bll.ObtemFuncionario();
            DataSet ds_lg = bll.ObtemLogin();

            string Telas = "";
            int x = (int.Parse(ds_lg.Tables[0].Rows[ds_lg.Tables[0].Rows.Count - 1]["Cod"].ToString())) + 1;

            ds.Tables[0].DefaultView.RowFilter = "Nome_Func = '" + cmbNomeFunc.Text.ToString() + "'";

           

            if (txtSenha.Text != txtCofirmaSenha.Text)
            {
                MessageBox.Show("Senhas incopativel, Verifique se as duas estão exatamente correta!", "ATENÇÃO!");
                return;
            }

            Login lg = new Login(x
                                , txtUsuario.Text.ToString()
                                , txtSenha.Text.ToString() // parte que tem que ir para criptografar
                                , Telas
                                , int.Parse(ds.Tables[0].DefaultView[0]["Cod_Func"].ToString()));
            try
            {
                bll.GravarLogin(lg);
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GravandoFuncionario(Endereco end)
        {
            if (mtxtCpf.ForeColor.Name != "Green")
            {
                MessageBox.Show("Cpf invalido, Verifique!", "ATENÇÃO", MessageBoxButtons.OK);
                return;
            }

            string Sexo;
            if (rdMasc.Checked == true)
                Sexo = rdMasc.Text;
            else
                Sexo = rdFemi.Text;


            string data_nas = Convert.ToDateTime(mtxtDataNascimento.Text).ToString("yyyy/MM/dd");
            string data_adm = Convert.ToDateTime(mtxtDataAdm.Text).ToString("yyyy/MM/dd");

            /* Pegando valores dos itens que tem  no formulario do funcionario e instanciando para o objeto Funcionario*/
            Funcionario fun = new Funcionario(int.Parse(txtCodigoFunc.Text.ToString())
                                                    , txtNomeFunc.Text.ToString()
                                                    , data_nas
                                                    , mtxtRg.Text.ToString().Replace(",", "").Replace("-", "").ToString()
                                                    , mtxtCpf.Text.ToString().Replace(",", "").Replace("-", "").ToString()
                                                    , txtEmaiFun.Text.ToString()
                                                    , Sexo.ToString()
                                                    , cmbTipoContratacao.Text.ToString()
                                                    , int.Parse(mtxtCarteira.Text.ToString())
                                                    , data_adm
                                                    , cmbCargo.Text.ToString()
                                                    , cmbDepto.Text.ToString()
                                                    , mtxtSalario.Text.ToString().Replace("R$", "")
                                                    , null
                                                    , end.cep
                                                    , end.endereco
                                                    , end.Numero
                                                    , end.Complemto
                                                    , end.Bairro
                                                    , end.Cidade
                                                    , end.UF);

            try
            {
                bll.GravarFuncionario(fun);
                MessageBox.Show("Funcionario salvo com sucesso!", "SALVAR", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Pegando_CodigoFF()
        {
            ds_func = bll.ObtemFuncionario();
            if (ds_func.Tables[0].Rows.Count == 0)
                txtCodigoFunc.Text = "01";
            else
            {
                int value = int.Parse(ds_func.Tables[0].Rows[ds_func.Tables[0].Rows.Count - 1]["Cod_Func"].ToString());
                txtCodigoFunc.Text = (value + 1).ToString();
            }

            ds_fornec = bll.ObtemFornecedor();
            if (ds_func.Tables[0].Rows.Count == 0)
                txtCodFornce.Text = "01";
            else
            {
                int value = int.Parse(ds_fornec.Tables[0].Rows[ds_fornec.Tables[0].Rows.Count - 1]["Cod_Fornec"].ToString());
                txtCodFornce.Text = (value + 1).ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text == txtSenha.Text)
            {
                MessageBox.Show("Senha atual é igual a senha anterior!", "ATENÇÃO");
                return;
            }
            else
            {
                int Cod_Login = 0;
                int Cod_Func = 0;
                string Usuario_velho = txtUsuario.Text;
                BuscarCodigos(ref Cod_Func, ref Cod_Login,ref Usuario_velho);

                Login lg = new Login(Cod_Login,
                                txtUsuario.Text,
                                Usuario_velho,
                                txtSenhaAtual.Text,
                                txtSenha.Text,
                                "",
                                Cod_Func);
                try
                {

                    bll.AtualizarLogin(lg);
                    MessageBox.Show("Alteração feita com sucesso!", "UPDATE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }
        public void BuscarCodigos(ref int cod_func , ref int cod_log, ref string usuario)
        {
            string nome = cmbNomeFunc.SelectedItem.ToString();

            DataSet ds = bll.ObtemFuncionario(nome);
            int cod = int.Parse(ds.Tables[0].Rows[0]["Cod_Func"].ToString());
            ds.Tables.Clear();
            ds = bll.ObtemLogin(cod);

            cod_func = cod;
            cod_log = int.Parse(ds.Tables[0].Rows[0]["Cod"].ToString());
            usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
        }



        private void cmbNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNomeFunc.SelectedItem == null)
            { MessageBox.Show("Selecione o Funcionario para Editar"); return; }
            string nome = cmbNomeFunc.SelectedItem.ToString();

            DataSet ds = bll.ObtemFuncionario(nome);
            int cod = int.Parse(ds.Tables[0].Rows[0]["Cod_Func"].ToString());
            ds.Tables.Clear();
            ds = bll.ObtemLogin(cod);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtUsuario.Text = ds.Tables[0].Rows[0]["Usuario"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["Senha"].ToString();
                txtCofirmaSenha.Text = ds.Tables[0].Rows[0]["Senha"].ToString();
                ckbAlterar.Visible = true;
            }
            else
            {
                ckbAlterar.Visible = false;
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtCofirmaSenha.Text = "";
            }


        }

        private void ckbAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAlterar.Checked == true)
            {
                lblSenha.Text = "Nova Senha:";
                lblSenhaAtual.Visible = true;
                txtSenhaAtual.Visible = true;
                txtSenha.Text = "";
                txtCofirmaSenha.Text = "";
                txtSenhaAtual.Text = "";
                btnSalvar.Visible = false;
                btnEditar.Visible = true;
            }
            else
            {
                lblSenha.Text = "Senha:";
                lblSenhaAtual.Visible = false;
                txtSenhaAtual.Visible = false;
                btnSalvar.Visible = true;
                btnEditar.Visible = false;
                cmbNomeFunc_SelectedIndexChanged(sender, e);
            }

        }

        private void txtSenhaAtual_TextChanged(object sender, EventArgs e)
        {
            string nome = cmbNomeFunc.SelectedItem.ToString();

            DataSet ds = bll.ObtemFuncionario(nome);
            int cod = int.Parse(ds.Tables[0].Rows[0]["Cod_Func"].ToString());
            ds.Tables.Clear();
            ds = bll.ObtemLogin(cod);

            if (txtSenhaAtual.Text == ds.Tables[0].Rows[0]["Senha"].ToString())
            {
                txtSenhaAtual.ForeColor = Color.Green;
            }
            else { txtSenhaAtual.ForeColor = Color.Red; }

        }

        private void lblTipoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void lblCodFunc_Click(object sender, EventArgs e)
        {

        }

        private void gpbInfoPessoal_Enter(object sender, EventArgs e)
        {

        }
    }
}
