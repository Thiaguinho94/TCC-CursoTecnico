namespace Pesq_Pesqueiro
{
    partial class frmPesqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesqueiro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.grpbCadPeixes = new System.Windows.Forms.GroupBox();
            this.mtxtPrecoVara = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoVara = new System.Windows.Forms.Label();
            this.cmbTipoVara = new System.Windows.Forms.ComboBox();
            this.lblTipoVara = new System.Windows.Forms.Label();
            this.mtxtValorPeixe = new System.Windows.Forms.MaskedTextBox();
            this.lblValorPeixe = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ptbPeixe = new System.Windows.Forms.PictureBox();
            this.lblNomePeixe = new System.Windows.Forms.Label();
            this.txtNomePeixe = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.opfdPeixe = new System.Windows.Forms.OpenFileDialog();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpAlguelVara = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtValorProd = new System.Windows.Forms.MaskedTextBox();
            this.lblValorProd = new System.Windows.Forms.Label();
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.lblDescricaoProd = new System.Windows.Forms.Label();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.rdPeixe = new System.Windows.Forms.RadioButton();
            this.lblQtdVara = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbCadPeixes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeixe)).BeginInit();
            this.grpAlguelVara.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(1, 13);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(60, 16);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(63, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(359, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // grpbCadPeixes
            // 
            this.grpbCadPeixes.BackColor = System.Drawing.Color.Transparent;
            this.grpbCadPeixes.Controls.Add(this.radioButton1);
            this.grpbCadPeixes.Controls.Add(this.mtxtValorPeixe);
            this.grpbCadPeixes.Controls.Add(this.rdPeixe);
            this.grpbCadPeixes.Controls.Add(this.lblValorPeixe);
            this.grpbCadPeixes.Controls.Add(this.btnCarregar);
            this.grpbCadPeixes.Controls.Add(this.ptbPeixe);
            this.grpbCadPeixes.Controls.Add(this.lblNomePeixe);
            this.grpbCadPeixes.Controls.Add(this.txtNomePeixe);
            this.grpbCadPeixes.Controls.Add(this.txtCodigo);
            this.grpbCadPeixes.Controls.Add(this.lblCodigo);
            this.grpbCadPeixes.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCadPeixes.Location = new System.Drawing.Point(447, 36);
            this.grpbCadPeixes.Name = "grpbCadPeixes";
            this.grpbCadPeixes.Size = new System.Drawing.Size(421, 128);
            this.grpbCadPeixes.TabIndex = 3;
            this.grpbCadPeixes.TabStop = false;
            this.grpbCadPeixes.Text = "Cadastrar Peixe";
            this.grpbCadPeixes.Enter += new System.EventHandler(this.grpbCadPeixes_Enter);
            // 
            // mtxtPrecoVara
            // 
            this.mtxtPrecoVara.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecoVara.Location = new System.Drawing.Point(144, 44);
            this.mtxtPrecoVara.Mask = "$99,99";
            this.mtxtPrecoVara.Name = "mtxtPrecoVara";
            this.mtxtPrecoVara.Size = new System.Drawing.Size(67, 26);
            this.mtxtPrecoVara.TabIndex = 12;
            // 
            // lblPrecoVara
            // 
            this.lblPrecoVara.AutoSize = true;
            this.lblPrecoVara.Location = new System.Drawing.Point(141, 28);
            this.lblPrecoVara.Name = "lblPrecoVara";
            this.lblPrecoVara.Size = new System.Drawing.Size(70, 13);
            this.lblPrecoVara.TabIndex = 11;
            this.lblPrecoVara.Text = "Aluguel Vara:";
            // 
            // cmbTipoVara
            // 
            this.cmbTipoVara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVara.FormattingEnabled = true;
            this.cmbTipoVara.Items.AddRange(new object[] {
            "Molinete",
            "Bambu",
            "Carretilha"});
            this.cmbTipoVara.Location = new System.Drawing.Point(10, 44);
            this.cmbTipoVara.Name = "cmbTipoVara";
            this.cmbTipoVara.Size = new System.Drawing.Size(110, 21);
            this.cmbTipoVara.TabIndex = 10;
            // 
            // lblTipoVara
            // 
            this.lblTipoVara.AutoSize = true;
            this.lblTipoVara.Location = new System.Drawing.Point(7, 28);
            this.lblTipoVara.Name = "lblTipoVara";
            this.lblTipoVara.Size = new System.Drawing.Size(71, 13);
            this.lblTipoVara.TabIndex = 9;
            this.lblTipoVara.Text = "Tipo de Vara:";
            this.lblTipoVara.Click += new System.EventHandler(this.lblTipoVara_Click);
            // 
            // mtxtValorPeixe
            // 
            this.mtxtValorPeixe.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorPeixe.Location = new System.Drawing.Point(10, 82);
            this.mtxtValorPeixe.Mask = "$9999,99";
            this.mtxtValorPeixe.Name = "mtxtValorPeixe";
            this.mtxtValorPeixe.Size = new System.Drawing.Size(83, 25);
            this.mtxtValorPeixe.TabIndex = 8;
            this.mtxtValorPeixe.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtValorPeixe_MaskInputRejected);
            // 
            // lblValorPeixe
            // 
            this.lblValorPeixe.AutoSize = true;
            this.lblValorPeixe.Location = new System.Drawing.Point(7, 68);
            this.lblValorPeixe.Name = "lblValorPeixe";
            this.lblValorPeixe.Size = new System.Drawing.Size(68, 16);
            this.lblValorPeixe.TabIndex = 7;
            this.lblValorPeixe.Text = "Valor Peixe:";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(267, 89);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(24, 23);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "...";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ptbPeixe
            // 
            this.ptbPeixe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPeixe.Location = new System.Drawing.Point(297, 20);
            this.ptbPeixe.Name = "ptbPeixe";
            this.ptbPeixe.Size = new System.Drawing.Size(106, 92);
            this.ptbPeixe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPeixe.TabIndex = 4;
            this.ptbPeixe.TabStop = false;
            this.ptbPeixe.Click += new System.EventHandler(this.ptbPeixe_Click);
            // 
            // lblNomePeixe
            // 
            this.lblNomePeixe.AutoSize = true;
            this.lblNomePeixe.Location = new System.Drawing.Point(74, 20);
            this.lblNomePeixe.Name = "lblNomePeixe";
            this.lblNomePeixe.Size = new System.Drawing.Size(69, 16);
            this.lblNomePeixe.TabIndex = 3;
            this.lblNomePeixe.Text = "Nome Peixe:";
            // 
            // txtNomePeixe
            // 
            this.txtNomePeixe.Location = new System.Drawing.Point(73, 36);
            this.txtNomePeixe.Name = "txtNomePeixe";
            this.txtNomePeixe.Size = new System.Drawing.Size(201, 20);
            this.txtNomePeixe.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(44, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // opfdPeixe
            // 
            this.opfdPeixe.FileName = "C:\\Users\\Thiago\\Desktop\\Pesqueiro\\Pesqueiro\\Imagem";
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComprar.BackgroundImage")));
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.Location = new System.Drawing.Point(591, 415);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(64, 64);
            this.btnComprar.TabIndex = 30;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(804, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 64);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(733, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 64);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(663, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 64);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grpAlguelVara
            // 
            this.grpAlguelVara.BackColor = System.Drawing.Color.Transparent;
            this.grpAlguelVara.Controls.Add(this.radioButton2);
            this.grpAlguelVara.Controls.Add(this.lblQtdVara);
            this.grpAlguelVara.Controls.Add(this.mtxtPrecoVara);
            this.grpAlguelVara.Controls.Add(this.textBox1);
            this.grpAlguelVara.Controls.Add(this.cmbTipoVara);
            this.grpAlguelVara.Controls.Add(this.lblPrecoVara);
            this.grpAlguelVara.Controls.Add(this.lblTipoVara);
            this.grpAlguelVara.Location = new System.Drawing.Point(447, 175);
            this.grpAlguelVara.Name = "grpAlguelVara";
            this.grpAlguelVara.Size = new System.Drawing.Size(421, 82);
            this.grpAlguelVara.TabIndex = 31;
            this.grpAlguelVara.TabStop = false;
            this.grpAlguelVara.Text = "Aluguel Vara";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.lblDescricaoProd);
            this.groupBox1.Controls.Add(this.txtDescricaoProd);
            this.groupBox1.Controls.Add(this.txtCodigoProd);
            this.groupBox1.Controls.Add(this.mtxtValorProd);
            this.groupBox1.Controls.Add(this.lblValorProd);
            this.groupBox1.Controls.Add(this.lblCodigoProd);
            this.groupBox1.Location = new System.Drawing.Point(447, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 82);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Adiconais";
            // 
            // mtxtValorProd
            // 
            this.mtxtValorProd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorProd.Location = new System.Drawing.Point(220, 38);
            this.mtxtValorProd.Mask = "$99,99";
            this.mtxtValorProd.Name = "mtxtValorProd";
            this.mtxtValorProd.Size = new System.Drawing.Size(71, 26);
            this.mtxtValorProd.TabIndex = 12;
            // 
            // lblValorProd
            // 
            this.lblValorProd.AutoSize = true;
            this.lblValorProd.Location = new System.Drawing.Point(217, 22);
            this.lblValorProd.Name = "lblValorProd";
            this.lblValorProd.Size = new System.Drawing.Size(74, 13);
            this.lblValorProd.TabIndex = 11;
            this.lblValorProd.Text = "Valor Produto:";
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Location = new System.Drawing.Point(7, 28);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProd.TabIndex = 9;
            this.lblCodigoProd.Text = "Codigo:";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(10, 44);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(44, 20);
            this.txtCodigoProd.TabIndex = 9;
            // 
            // lblDescricaoProd
            // 
            this.lblDescricaoProd.AutoSize = true;
            this.lblDescricaoProd.Location = new System.Drawing.Point(61, 28);
            this.lblDescricaoProd.Name = "lblDescricaoProd";
            this.lblDescricaoProd.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoProd.TabIndex = 14;
            this.lblDescricaoProd.Text = "Descrição:";
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(60, 44);
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(151, 20);
            this.txtDescricaoProd.TabIndex = 13;
            // 
            // rdPeixe
            // 
            this.rdPeixe.AutoSize = true;
            this.rdPeixe.BackColor = System.Drawing.Color.Transparent;
            this.rdPeixe.Location = new System.Drawing.Point(137, 68);
            this.rdPeixe.Name = "rdPeixe";
            this.rdPeixe.Size = new System.Drawing.Size(102, 20);
            this.rdPeixe.TabIndex = 33;
            this.rdPeixe.TabStop = true;
            this.rdPeixe.Text = "Cadastar Peixe";
            this.rdPeixe.UseVisualStyleBackColor = false;
            // 
            // lblQtdVara
            // 
            this.lblQtdVara.AutoSize = true;
            this.lblQtdVara.Location = new System.Drawing.Point(215, 28);
            this.lblQtdVara.Name = "lblQtdVara";
            this.lblQtdVara.Size = new System.Drawing.Size(55, 13);
            this.lblQtdVara.TabIndex = 10;
            this.lblQtdVara.Text = "Qtd. Vara:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.textBox1.Location = new System.Drawing.Point(214, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(137, 90);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 20);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Adicionar Comanda";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(286, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 17);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Adicionar Comanda";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Location = new System.Drawing.Point(298, 51);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 17);
            this.radioButton4.TabIndex = 36;
            this.radioButton4.Text = "Adicionar Comanda";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Location = new System.Drawing.Point(298, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(113, 17);
            this.radioButton5.TabIndex = 37;
            this.radioButton5.Text = "Cadastar Prodtudo";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // frmPesqueiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAlguelVara);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpbCadPeixes);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesqueiro";
            this.Text = "Pesqueiro";
            this.Load += new System.EventHandler(this.frmPesqueiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbCadPeixes.ResumeLayout(false);
            this.grpbCadPeixes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeixe)).EndInit();
            this.grpAlguelVara.ResumeLayout(false);
            this.grpAlguelVara.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox grpbCadPeixes;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNomePeixe;
        private System.Windows.Forms.TextBox txtNomePeixe;
        private System.Windows.Forms.MaskedTextBox mtxtValorPeixe;
        private System.Windows.Forms.Label lblValorPeixe;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox ptbPeixe;
        private System.Windows.Forms.OpenFileDialog opfdPeixe;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipoVara;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoVara;
        private System.Windows.Forms.Label lblPrecoVara;
        private System.Windows.Forms.ComboBox cmbTipoVara;
        private System.Windows.Forms.GroupBox grpAlguelVara;
        private System.Windows.Forms.Label lblQtdVara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescricaoProd;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.MaskedTextBox mtxtValorProd;
        private System.Windows.Forms.Label lblValorProd;
        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.RadioButton rdPeixe;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

