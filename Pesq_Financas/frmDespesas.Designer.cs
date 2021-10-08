namespace Pesq_Financas
{
    partial class frmDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesas));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDecriDesp = new System.Windows.Forms.TextBox();
            this.lblDescDespesa = new System.Windows.Forms.Label();
            this.lblValorDesp = new System.Windows.Forms.Label();
            this.rdbPago = new System.Windows.Forms.RadioButton();
            this.rdbNaoPago = new System.Windows.Forms.RadioButton();
            this.gpbPagamento = new System.Windows.Forms.GroupBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbCadDespesa = new System.Windows.Forms.GroupBox();
            this.mtxtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValorDesp = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisaDesp = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.Codigo_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbStatus = new System.Windows.Forms.RadioButton();
            this.rdbCodDescri = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbPagamento.SuspendLayout();
            this.gpbCadDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDecriDesp
            // 
            this.txtDecriDesp.Location = new System.Drawing.Point(103, 32);
            this.txtDecriDesp.Name = "txtDecriDesp";
            this.txtDecriDesp.Size = new System.Drawing.Size(280, 20);
            this.txtDecriDesp.TabIndex = 3;
            // 
            // lblDescDespesa
            // 
            this.lblDescDespesa.AutoSize = true;
            this.lblDescDespesa.Location = new System.Drawing.Point(100, 16);
            this.lblDescDespesa.Name = "lblDescDespesa";
            this.lblDescDespesa.Size = new System.Drawing.Size(106, 16);
            this.lblDescDespesa.TabIndex = 2;
            this.lblDescDespesa.Text = "Descrição Despesa:";
            // 
            // lblValorDesp
            // 
            this.lblValorDesp.AutoSize = true;
            this.lblValorDesp.Location = new System.Drawing.Point(9, 78);
            this.lblValorDesp.Name = "lblValorDesp";
            this.lblValorDesp.Size = new System.Drawing.Size(82, 16);
            this.lblValorDesp.TabIndex = 4;
            this.lblValorDesp.Text = "Valor Despesa:";
            // 
            // rdbPago
            // 
            this.rdbPago.AutoSize = true;
            this.rdbPago.ForeColor = System.Drawing.Color.Green;
            this.rdbPago.Location = new System.Drawing.Point(11, 19);
            this.rdbPago.Name = "rdbPago";
            this.rdbPago.Size = new System.Drawing.Size(50, 20);
            this.rdbPago.TabIndex = 6;
            this.rdbPago.TabStop = true;
            this.rdbPago.Text = "Pago";
            this.rdbPago.UseVisualStyleBackColor = true;
            this.rdbPago.CheckedChanged += new System.EventHandler(this.RdbPago_CheckedChanged);
            // 
            // rdbNaoPago
            // 
            this.rdbNaoPago.AutoSize = true;
            this.rdbNaoPago.ForeColor = System.Drawing.Color.Red;
            this.rdbNaoPago.Location = new System.Drawing.Point(67, 18);
            this.rdbNaoPago.Name = "rdbNaoPago";
            this.rdbNaoPago.Size = new System.Drawing.Size(72, 20);
            this.rdbNaoPago.TabIndex = 7;
            this.rdbNaoPago.TabStop = true;
            this.rdbNaoPago.Text = "Não Pago";
            this.rdbNaoPago.UseVisualStyleBackColor = true;
            this.rdbNaoPago.CheckedChanged += new System.EventHandler(this.RdbNaoPago_CheckedChanged);
            // 
            // gpbPagamento
            // 
            this.gpbPagamento.Controls.Add(this.rdbPago);
            this.gpbPagamento.Controls.Add(this.rdbNaoPago);
            this.gpbPagamento.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPagamento.Location = new System.Drawing.Point(389, 18);
            this.gpbPagamento.Name = "gpbPagamento";
            this.gpbPagamento.Size = new System.Drawing.Size(144, 42);
            this.gpbPagamento.TabIndex = 8;
            this.gpbPagamento.TabStop = false;
            this.gpbPagamento.Text = "Status";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(158, 78);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(94, 16);
            this.lblDataPagamento.TabIndex = 9;
            this.lblDataPagamento.Text = "Data Pagamento:";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(311, 78);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(98, 16);
            this.lblDataVencimento.TabIndex = 11;
            this.lblDataVencimento.Text = "Data Vencimento:";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs.Location = new System.Drawing.Point(9, 160);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(524, 181);
            this.txtObs.TabIndex = 14;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(6, 144);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(77, 16);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Observações:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(848, 446);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 64);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(932, 446);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 64);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1013, 446);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 64);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // gpbCadDespesa
            // 
            this.gpbCadDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadDespesa.Controls.Add(this.mtxtDataVencimento);
            this.gpbCadDespesa.Controls.Add(this.mtxtDataPagamento);
            this.gpbCadDespesa.Controls.Add(this.mtxtValorDesp);
            this.gpbCadDespesa.Controls.Add(this.lblCodigo);
            this.gpbCadDespesa.Controls.Add(this.txtCodigo);
            this.gpbCadDespesa.Controls.Add(this.lblDescDespesa);
            this.gpbCadDespesa.Controls.Add(this.txtDecriDesp);
            this.gpbCadDespesa.Controls.Add(this.txtObs);
            this.gpbCadDespesa.Controls.Add(this.lblValorDesp);
            this.gpbCadDespesa.Controls.Add(this.lblObservacao);
            this.gpbCadDespesa.Controls.Add(this.gpbPagamento);
            this.gpbCadDespesa.Controls.Add(this.lblDataVencimento);
            this.gpbCadDespesa.Controls.Add(this.lblDataPagamento);
            this.gpbCadDespesa.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadDespesa.Location = new System.Drawing.Point(543, 12);
            this.gpbCadDespesa.Name = "gpbCadDespesa";
            this.gpbCadDespesa.Size = new System.Drawing.Size(539, 376);
            this.gpbCadDespesa.TabIndex = 18;
            this.gpbCadDespesa.TabStop = false;
            this.gpbCadDespesa.Text = "Cadastro de Despesas";
            // 
            // mtxtDataVencimento
            // 
            this.mtxtDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataVencimento.Location = new System.Drawing.Point(314, 97);
            this.mtxtDataVencimento.Mask = "00/00/0000";
            this.mtxtDataVencimento.Name = "mtxtDataVencimento";
            this.mtxtDataVencimento.Size = new System.Drawing.Size(89, 26);
            this.mtxtDataVencimento.TabIndex = 26;
            this.mtxtDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDataPagamento
            // 
            this.mtxtDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataPagamento.Location = new System.Drawing.Point(161, 97);
            this.mtxtDataPagamento.Mask = "00/00/0000";
            this.mtxtDataPagamento.Name = "mtxtDataPagamento";
            this.mtxtDataPagamento.Size = new System.Drawing.Size(89, 26);
            this.mtxtDataPagamento.TabIndex = 25;
            this.mtxtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtValorDesp
            // 
            this.mtxtValorDesp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorDesp.Location = new System.Drawing.Point(9, 94);
            this.mtxtValorDesp.Mask = "$ 9999,99";
            this.mtxtValorDesp.Name = "mtxtValorDesp";
            this.mtxtValorDesp.Size = new System.Drawing.Size(101, 26);
            this.mtxtValorDesp.TabIndex = 24;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(165, 474);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(60, 16);
            this.lblPesquisa.TabIndex = 19;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisaDesp
            // 
            this.txtPesquisaDesp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaDesp.Location = new System.Drawing.Point(168, 490);
            this.txtPesquisaDesp.Name = "txtPesquisaDesp";
            this.txtPesquisaDesp.Size = new System.Drawing.Size(371, 20);
            this.txtPesquisaDesp.TabIndex = 20;
            this.txtPesquisaDesp.TextChanged += new System.EventHandler(this.TxtPesquisaDesp_TextChanged);
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Despesa,
            this.Descricao_Despesa,
            this.Valor_Despesa,
            this.Data_Pagamento,
            this.Data_Vencimento,
            this.Status_Conta,
            this.Obs});
            this.dgvDespesas.Location = new System.Drawing.Point(4, 13);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.RowHeadersVisible = false;
            this.dgvDespesas.Size = new System.Drawing.Size(535, 458);
            this.dgvDespesas.TabIndex = 21;
            this.dgvDespesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDespesas_CellDoubleClick);
            this.dgvDespesas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDespesas_CellDoubleClick);
            this.dgvDespesas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvDespesas_KeyDown);
            // 
            // Codigo_Despesa
            // 
            this.Codigo_Despesa.HeaderText = "Código ";
            this.Codigo_Despesa.Name = "Codigo_Despesa";
            this.Codigo_Despesa.ReadOnly = true;
            this.Codigo_Despesa.Width = 50;
            // 
            // Descricao_Despesa
            // 
            this.Descricao_Despesa.HeaderText = "Descrição Despesa";
            this.Descricao_Despesa.Name = "Descricao_Despesa";
            this.Descricao_Despesa.ReadOnly = true;
            this.Descricao_Despesa.Width = 150;
            // 
            // Valor_Despesa
            // 
            this.Valor_Despesa.HeaderText = "Valor Despesa";
            this.Valor_Despesa.Name = "Valor_Despesa";
            this.Valor_Despesa.ReadOnly = true;
            // 
            // Data_Pagamento
            // 
            this.Data_Pagamento.HeaderText = "Data Pagamento";
            this.Data_Pagamento.Name = "Data_Pagamento";
            this.Data_Pagamento.ReadOnly = true;
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data Vencimento";
            this.Data_Vencimento.Name = "Data_Vencimento";
            this.Data_Vencimento.ReadOnly = true;
            // 
            // Status_Conta
            // 
            this.Status_Conta.HeaderText = "Status";
            this.Status_Conta.Name = "Status_Conta";
            this.Status_Conta.ReadOnly = true;
            this.Status_Conta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status_Conta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Obs
            // 
            this.Obs.HeaderText = "Observação";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            // 
            // rdbStatus
            // 
            this.rdbStatus.AutoSize = true;
            this.rdbStatus.Location = new System.Drawing.Point(12, 20);
            this.rdbStatus.Name = "rdbStatus";
            this.rdbStatus.Size = new System.Drawing.Size(58, 20);
            this.rdbStatus.TabIndex = 22;
            this.rdbStatus.TabStop = true;
            this.rdbStatus.Text = "Status";
            this.rdbStatus.UseVisualStyleBackColor = true;
            this.rdbStatus.CheckedChanged += new System.EventHandler(this.RdbStatus_CheckedChanged);
            // 
            // rdbCodDescri
            // 
            this.rdbCodDescri.AutoSize = true;
            this.rdbCodDescri.Location = new System.Drawing.Point(82, 13);
            this.rdbCodDescri.Name = "rdbCodDescri";
            this.rdbCodDescri.Size = new System.Drawing.Size(76, 36);
            this.rdbCodDescri.TabIndex = 23;
            this.rdbCodDescri.TabStop = true;
            this.rdbCodDescri.Text = "Código\r\nDescrição\r\n";
            this.rdbCodDescri.UseVisualStyleBackColor = true;
            this.rdbCodDescri.CheckedChanged += new System.EventHandler(this.RdbCodDescri_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rdbCodDescri);
            this.groupBox1.Controls.Add(this.rdbStatus);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 44);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Consulta";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pago",
            "Não Pago"});
            this.cmbStatus.Location = new System.Drawing.Point(168, 517);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(111, 21);
            this.cmbStatus.TabIndex = 25;
            this.cmbStatus.Visible = false;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(762, 446);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 64);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 515);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.txtPesquisaDesp);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.gpbCadDespesa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDespesas";
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.FrmDespesas_Load);
            this.gpbPagamento.ResumeLayout(false);
            this.gpbPagamento.PerformLayout();
            this.gpbCadDespesa.ResumeLayout(false);
            this.gpbCadDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDecriDesp;
        private System.Windows.Forms.Label lblDescDespesa;
        private System.Windows.Forms.Label lblValorDesp;
        private System.Windows.Forms.RadioButton rdbPago;
        private System.Windows.Forms.RadioButton rdbNaoPago;
        private System.Windows.Forms.GroupBox gpbPagamento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbCadDespesa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaDesp;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.MaskedTextBox mtxtValorDesp;
        private System.Windows.Forms.RadioButton rdbStatus;
        private System.Windows.Forms.RadioButton rdbCodDescri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mtxtDataPagamento;
        private System.Windows.Forms.MaskedTextBox mtxtDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.Button btnEditar;
    }
}