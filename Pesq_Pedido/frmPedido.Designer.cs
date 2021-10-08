namespace Pesq_Pedido
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.lblDescriProduto = new System.Windows.Forms.Label();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.numPedido = new System.Windows.Forms.NumericUpDown();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.grpPrazoEntrega = new System.Windows.Forms.GroupBox();
            this.rdMes = new System.Windows.Forms.RadioButton();
            this.rdDia = new System.Windows.Forms.RadioButton();
            this.numPrazoEntrega = new System.Windows.Forms.NumericUpDown();
            this.btnSelcionarProd = new System.Windows.Forms.Button();
            this.mtxtDataPEntrega = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValorUnitario = new System.Windows.Forms.MaskedTextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPedido)).BeginInit();
            this.gpbCadastro.SuspendLayout();
            this.grpPrazoEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrazoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Location = new System.Drawing.Point(18, 25);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(68, 16);
            this.lblCodPedido.TabIndex = 0;
            this.lblCodPedido.Text = "Cod.Pedido:";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Enabled = false;
            this.txtCodPedido.Location = new System.Drawing.Point(21, 42);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(79, 20);
            this.txtCodPedido.TabIndex = 1;
            // 
            // lblDescriProduto
            // 
            this.lblDescriProduto.AutoSize = true;
            this.lblDescriProduto.Location = new System.Drawing.Point(122, 25);
            this.lblDescriProduto.Name = "lblDescriProduto";
            this.lblDescriProduto.Size = new System.Drawing.Size(105, 16);
            this.lblDescriProduto.TabIndex = 2;
            this.lblDescriProduto.Text = "Descrição Produto:";
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Enabled = false;
            this.txtDescricaoProd.Location = new System.Drawing.Point(125, 42);
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(235, 20);
            this.txtDescricaoProd.TabIndex = 3;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(18, 135);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(82, 16);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(18, 76);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(68, 16);
            this.lblQtde.TabIndex = 6;
            this.lblQtde.Text = "Qtd.Pedido:";
            // 
            // numPedido
            // 
            this.numPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPedido.Location = new System.Drawing.Point(21, 95);
            this.numPedido.Name = "numPedido";
            this.numPedido.Size = new System.Drawing.Size(79, 22);
            this.numPedido.TabIndex = 7;
            this.numPedido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(122, 76);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(93, 16);
            this.lblDataPedido.TabIndex = 8;
            this.lblDataPedido.Text = "Data da Emissão:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(18, 206);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(77, 16);
            this.lblObservacao.TabIndex = 10;
            this.lblObservacao.Text = "Observações:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(21, 225);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(472, 141);
            this.txtObs.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(914, 460);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 64);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(984, 460);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 64);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(1054, 460);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 64);
            this.btnSair.TabIndex = 14;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(232, 75);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(94, 16);
            this.lblDataEntrega.TabIndex = 15;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadastro.Controls.Add(this.lblFornecedor);
            this.gpbCadastro.Controls.Add(this.txtFornecedor);
            this.gpbCadastro.Controls.Add(this.grpPrazoEntrega);
            this.gpbCadastro.Controls.Add(this.btnSelcionarProd);
            this.gpbCadastro.Controls.Add(this.mtxtDataPEntrega);
            this.gpbCadastro.Controls.Add(this.mtxtDataPedido);
            this.gpbCadastro.Controls.Add(this.mtxtValorUnitario);
            this.gpbCadastro.Controls.Add(this.lblCodPedido);
            this.gpbCadastro.Controls.Add(this.txtCodPedido);
            this.gpbCadastro.Controls.Add(this.lblDataEntrega);
            this.gpbCadastro.Controls.Add(this.lblDescriProduto);
            this.gpbCadastro.Controls.Add(this.txtDescricaoProd);
            this.gpbCadastro.Controls.Add(this.lblValorUnitario);
            this.gpbCadastro.Controls.Add(this.txtObs);
            this.gpbCadastro.Controls.Add(this.lblQtde);
            this.gpbCadastro.Controls.Add(this.lblObservacao);
            this.gpbCadastro.Controls.Add(this.numPedido);
            this.gpbCadastro.Controls.Add(this.lblDataPedido);
            this.gpbCadastro.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastro.Location = new System.Drawing.Point(623, 12);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(506, 393);
            this.gpbCadastro.TabIndex = 17;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastrar Pedido";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(122, 135);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(70, 16);
            this.lblFornecedor.TabIndex = 33;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(125, 153);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(235, 20);
            this.txtFornecedor.TabIndex = 32;
            // 
            // grpPrazoEntrega
            // 
            this.grpPrazoEntrega.Controls.Add(this.rdMes);
            this.grpPrazoEntrega.Controls.Add(this.rdDia);
            this.grpPrazoEntrega.Controls.Add(this.numPrazoEntrega);
            this.grpPrazoEntrega.Location = new System.Drawing.Point(369, 76);
            this.grpPrazoEntrega.Name = "grpPrazoEntrega";
            this.grpPrazoEntrega.Size = new System.Drawing.Size(101, 106);
            this.grpPrazoEntrega.TabIndex = 31;
            this.grpPrazoEntrega.TabStop = false;
            this.grpPrazoEntrega.Text = "Prazo Entrega";
            // 
            // rdMes
            // 
            this.rdMes.AutoSize = true;
            this.rdMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMes.Location = new System.Drawing.Point(7, 77);
            this.rdMes.Name = "rdMes";
            this.rdMes.Size = new System.Drawing.Size(52, 20);
            this.rdMes.TabIndex = 32;
            this.rdMes.TabStop = true;
            this.rdMes.Text = "Mês";
            this.rdMes.UseVisualStyleBackColor = true;
            // 
            // rdDia
            // 
            this.rdDia.AutoSize = true;
            this.rdDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDia.Location = new System.Drawing.Point(7, 52);
            this.rdDia.Name = "rdDia";
            this.rdDia.Size = new System.Drawing.Size(47, 20);
            this.rdDia.TabIndex = 31;
            this.rdDia.TabStop = true;
            this.rdDia.Text = "Dia";
            this.rdDia.UseVisualStyleBackColor = true;
            // 
            // numPrazoEntrega
            // 
            this.numPrazoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrazoEntrega.Location = new System.Drawing.Point(7, 19);
            this.numPrazoEntrega.Name = "numPrazoEntrega";
            this.numPrazoEntrega.Size = new System.Drawing.Size(60, 22);
            this.numPrazoEntrega.TabIndex = 30;
            this.numPrazoEntrega.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSelcionarProd
            // 
            this.btnSelcionarProd.Location = new System.Drawing.Point(369, 40);
            this.btnSelcionarProd.Name = "btnSelcionarProd";
            this.btnSelcionarProd.Size = new System.Drawing.Size(107, 23);
            this.btnSelcionarProd.TabIndex = 28;
            this.btnSelcionarProd.Text = "Selecionar Produto";
            this.btnSelcionarProd.UseVisualStyleBackColor = true;
            this.btnSelcionarProd.Click += new System.EventHandler(this.BtnSelcionarProd_Click);
            // 
            // mtxtDataPEntrega
            // 
            this.mtxtDataPEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataPEntrega.Location = new System.Drawing.Point(235, 94);
            this.mtxtDataPEntrega.Mask = "00/00/0000";
            this.mtxtDataPEntrega.Name = "mtxtDataPEntrega";
            this.mtxtDataPEntrega.Size = new System.Drawing.Size(69, 22);
            this.mtxtDataPEntrega.TabIndex = 27;
            this.mtxtDataPEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDataPedido
            // 
            this.mtxtDataPedido.Enabled = false;
            this.mtxtDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataPedido.Location = new System.Drawing.Point(125, 95);
            this.mtxtDataPedido.Mask = "00/00/0000";
            this.mtxtDataPedido.Name = "mtxtDataPedido";
            this.mtxtDataPedido.Size = new System.Drawing.Size(69, 22);
            this.mtxtDataPedido.TabIndex = 26;
            this.mtxtDataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtValorUnitario
            // 
            this.mtxtValorUnitario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorUnitario.Location = new System.Drawing.Point(21, 153);
            this.mtxtValorUnitario.Mask = "$ 9999,99";
            this.mtxtValorUnitario.Name = "mtxtValorUnitario";
            this.mtxtValorUnitario.Size = new System.Drawing.Size(79, 26);
            this.mtxtValorUnitario.TabIndex = 25;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(2, 3);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(615, 507);
            this.dgvPesquisa.TabIndex = 18;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(61, 515);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(556, 20);
            this.txtPesquisar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar:";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPedido)).EndInit();
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.grpPrazoEntrega.ResumeLayout(false);
            this.grpPrazoEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrazoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label lblDescriProduto;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.NumericUpDown numPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.MaskedTextBox mtxtValorUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtDataPEntrega;
        private System.Windows.Forms.MaskedTextBox mtxtDataPedido;
        private System.Windows.Forms.Button btnSelcionarProd;
        private System.Windows.Forms.GroupBox grpPrazoEntrega;
        private System.Windows.Forms.RadioButton rdMes;
        private System.Windows.Forms.RadioButton rdDia;
        private System.Windows.Forms.NumericUpDown numPrazoEntrega;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}

