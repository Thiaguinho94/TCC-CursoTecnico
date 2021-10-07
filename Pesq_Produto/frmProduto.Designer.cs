namespace Pesq_Produto
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblQtdNova = new System.Windows.Forms.Label();
            this.numQtdNova = new System.Windows.Forms.NumericUpDown();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnGerarEstoque = new System.Windows.Forms.Button();
            this.lblPercoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.gpbCadProduto = new System.Windows.Forms.GroupBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.cmbSecao = new System.Windows.Forms.ComboBox();
            this.mtxtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPrecoCusto = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdNova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbCadProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(6, 20);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(69, 13);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Cod.Produto:";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Location = new System.Drawing.Point(6, 36);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(69, 20);
            this.txtCodProd.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(99, 20);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(95, 36);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(224, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblQtdNova
            // 
            this.lblQtdNova.AutoSize = true;
            this.lblQtdNova.Location = new System.Drawing.Point(165, 80);
            this.lblQtdNova.Name = "lblQtdNova";
            this.lblQtdNova.Size = new System.Drawing.Size(56, 13);
            this.lblQtdNova.TabIndex = 4;
            this.lblQtdNova.Text = "Qtd Nova:";
            // 
            // numQtdNova
            // 
            this.numQtdNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtdNova.Location = new System.Drawing.Point(168, 102);
            this.numQtdNova.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numQtdNova.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdNova.Name = "numQtdNova";
            this.numQtdNova.Size = new System.Drawing.Size(65, 22);
            this.numQtdNova.TabIndex = 5;
            this.numQtdNova.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(11, 86);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(9, 102);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(116, 21);
            this.cmbFornecedor.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(698, 171);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 64);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(775, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 64);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(853, 171);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 64);
            this.btnSair.TabIndex = 12;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(62, 339);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(403, 20);
            this.txtPesquisa.TabIndex = 13;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 6);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(462, 330);
            this.dgvProdutos.TabIndex = 14;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            this.dgvProdutos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_CellMouseDoubleClick);
            // 
            // btnGerarEstoque
            // 
            this.btnGerarEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarEstoque.AutoSize = true;
            this.btnGerarEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnGerarEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerarEstoque.BackgroundImage")));
            this.btnGerarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarEstoque.ForeColor = System.Drawing.Color.Transparent;
            this.btnGerarEstoque.Location = new System.Drawing.Point(471, 272);
            this.btnGerarEstoque.Name = "btnGerarEstoque";
            this.btnGerarEstoque.Size = new System.Drawing.Size(65, 64);
            this.btnGerarEstoque.TabIndex = 15;
            this.btnGerarEstoque.UseVisualStyleBackColor = false;
            // 
            // lblPercoCusto
            // 
            this.lblPercoCusto.AutoSize = true;
            this.lblPercoCusto.Location = new System.Drawing.Point(263, 82);
            this.lblPercoCusto.Name = "lblPercoCusto";
            this.lblPercoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPercoCusto.TabIndex = 16;
            this.lblPercoCusto.Text = "Preço de Custo:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(357, 81);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 18;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // gpbCadProduto
            // 
            this.gpbCadProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadProduto.Controls.Add(this.lblSecao);
            this.gpbCadProduto.Controls.Add(this.cmbSecao);
            this.gpbCadProduto.Controls.Add(this.mtxtPrecoVenda);
            this.gpbCadProduto.Controls.Add(this.mtxtPrecoCusto);
            this.gpbCadProduto.Controls.Add(this.txtCodProd);
            this.gpbCadProduto.Controls.Add(this.lblCodProduto);
            this.gpbCadProduto.Controls.Add(this.lblDescricao);
            this.gpbCadProduto.Controls.Add(this.lblPrecoVenda);
            this.gpbCadProduto.Controls.Add(this.txtDescricao);
            this.gpbCadProduto.Controls.Add(this.lblQtdNova);
            this.gpbCadProduto.Controls.Add(this.lblPercoCusto);
            this.gpbCadProduto.Controls.Add(this.numQtdNova);
            this.gpbCadProduto.Controls.Add(this.lblFornecedor);
            this.gpbCadProduto.Controls.Add(this.cmbFornecedor);
            this.gpbCadProduto.Location = new System.Drawing.Point(471, 6);
            this.gpbCadProduto.Name = "gpbCadProduto";
            this.gpbCadProduto.Size = new System.Drawing.Size(447, 159);
            this.gpbCadProduto.TabIndex = 21;
            this.gpbCadProduto.TabStop = false;
            this.gpbCadProduto.Text = "Cadastro Produto";
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(333, 20);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(41, 13);
            this.lblSecao.TabIndex = 25;
            this.lblSecao.Text = "Seção:";
            // 
            // cmbSecao
            // 
            this.cmbSecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecao.FormattingEnabled = true;
            this.cmbSecao.Items.AddRange(new object[] {
            ""});
            this.cmbSecao.Location = new System.Drawing.Point(331, 36);
            this.cmbSecao.Name = "cmbSecao";
            this.cmbSecao.Size = new System.Drawing.Size(116, 21);
            this.cmbSecao.TabIndex = 26;
            // 
            // mtxtPrecoVenda
            // 
            this.mtxtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecoVenda.Location = new System.Drawing.Point(360, 102);
            this.mtxtPrecoVenda.Mask = "$ 0000,00";
            this.mtxtPrecoVenda.Name = "mtxtPrecoVenda";
            this.mtxtPrecoVenda.Size = new System.Drawing.Size(72, 22);
            this.mtxtPrecoVenda.TabIndex = 24;
            this.mtxtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxtPrecoCusto
            // 
            this.mtxtPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecoCusto.Location = new System.Drawing.Point(268, 102);
            this.mtxtPrecoCusto.Mask = "$ 0000,00";
            this.mtxtPrecoCusto.Name = "mtxtPrecoCusto";
            this.mtxtPrecoCusto.Size = new System.Drawing.Size(72, 22);
            this.mtxtPrecoCusto.TabIndex = 23;
            this.mtxtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(0, 342);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 23;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 363);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.gpbCadProduto);
            this.Controls.Add(this.btnGerarEstoque);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCad_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQtdNova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbCadProduto.ResumeLayout(false);
            this.gpbCadProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblQtdNova;
        private System.Windows.Forms.NumericUpDown numQtdNova;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnGerarEstoque;
        private System.Windows.Forms.Label lblPercoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.GroupBox gpbCadProduto;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoVenda;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoCusto;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.ComboBox cmbSecao;
    }
}

