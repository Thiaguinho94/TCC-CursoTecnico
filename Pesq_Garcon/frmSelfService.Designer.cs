namespace Pesq_Garcon
{
    partial class frmGarcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGarcon));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txtNumComanda = new System.Windows.Forms.TextBox();
            this.rdAlmoco = new System.Windows.Forms.RadioButton();
            this.rdMarmitex = new System.Windows.Forms.RadioButton();
            this.lblQtdRefeicao = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grbTipoRefeicao = new System.Windows.Forms.GroupBox();
            this.lblValorDoKILO = new System.Windows.Forms.Label();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.chkLstInformacao = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbTipoRefeicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(428, 42);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(364, 329);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisa.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(425, 1);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(103, 16);
            this.lblPesquisa.TabIndex = 1;
            this.lblPesquisa.Text = "Pesquisar Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(752, 377);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 40);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.BackColor = System.Drawing.Color.Transparent;
            this.lblComanda.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(12, 20);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(88, 18);
            this.lblComanda.TabIndex = 4;
            this.lblComanda.Text = "Nº Comanda:";
            // 
            // txtNumComanda
            // 
            this.txtNumComanda.Location = new System.Drawing.Point(12, 41);
            this.txtNumComanda.Name = "txtNumComanda";
            this.txtNumComanda.Size = new System.Drawing.Size(113, 20);
            this.txtNumComanda.TabIndex = 5;
            // 
            // rdAlmoco
            // 
            this.rdAlmoco.AutoSize = true;
            this.rdAlmoco.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdAlmoco.Location = new System.Drawing.Point(15, 22);
            this.rdAlmoco.Name = "rdAlmoco";
            this.rdAlmoco.Size = new System.Drawing.Size(70, 22);
            this.rdAlmoco.TabIndex = 6;
            this.rdAlmoco.TabStop = true;
            this.rdAlmoco.Text = "Almoço";
            this.rdAlmoco.UseVisualStyleBackColor = true;
            // 
            // rdMarmitex
            // 
            this.rdMarmitex.AutoSize = true;
            this.rdMarmitex.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdMarmitex.Location = new System.Drawing.Point(15, 56);
            this.rdMarmitex.Name = "rdMarmitex";
            this.rdMarmitex.Size = new System.Drawing.Size(83, 22);
            this.rdMarmitex.TabIndex = 7;
            this.rdMarmitex.TabStop = true;
            this.rdMarmitex.Text = "Marmitex";
            this.rdMarmitex.UseVisualStyleBackColor = true;
            // 
            // lblQtdRefeicao
            // 
            this.lblQtdRefeicao.AutoSize = true;
            this.lblQtdRefeicao.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdRefeicao.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQtdRefeicao.Location = new System.Drawing.Point(12, 71);
            this.lblQtdRefeicao.Name = "lblQtdRefeicao";
            this.lblQtdRefeicao.Size = new System.Drawing.Size(132, 18);
            this.lblQtdRefeicao.TabIndex = 8;
            this.lblQtdRefeicao.Text = "Qtde. Refeição (Kg):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 9;
            // 
            // grbTipoRefeicao
            // 
            this.grbTipoRefeicao.BackColor = System.Drawing.Color.Transparent;
            this.grbTipoRefeicao.Controls.Add(this.rdAlmoco);
            this.grbTipoRefeicao.Controls.Add(this.rdMarmitex);
            this.grbTipoRefeicao.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.grbTipoRefeicao.Location = new System.Drawing.Point(181, 20);
            this.grbTipoRefeicao.Name = "grbTipoRefeicao";
            this.grbTipoRefeicao.Size = new System.Drawing.Size(120, 82);
            this.grbTipoRefeicao.TabIndex = 10;
            this.grbTipoRefeicao.TabStop = false;
            this.grbTipoRefeicao.Text = "Tipo Refeição:";
            // 
            // lblValorDoKILO
            // 
            this.lblValorDoKILO.AutoSize = true;
            this.lblValorDoKILO.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDoKILO.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValorDoKILO.Location = new System.Drawing.Point(9, 124);
            this.lblValorDoKILO.Name = "lblValorDoKILO";
            this.lblValorDoKILO.Size = new System.Drawing.Size(45, 18);
            this.lblValorDoKILO.TabIndex = 11;
            this.lblValorDoKILO.Text = "Valor:";
            // 
            // mtxtValor
            // 
            this.mtxtValor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtValor.Location = new System.Drawing.Point(15, 146);
            this.mtxtValor.Mask = "$9999,99";
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(85, 23);
            this.mtxtValor.TabIndex = 12;
            // 
            // mtxtValorTotal
            // 
            this.mtxtValorTotal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtValorTotal.Location = new System.Drawing.Point(162, 146);
            this.mtxtValorTotal.Mask = "$9999,99";
            this.mtxtValorTotal.Name = "mtxtValorTotal";
            this.mtxtValorTotal.Size = new System.Drawing.Size(77, 23);
            this.mtxtValorTotal.TabIndex = 13;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.Location = new System.Drawing.Point(159, 125);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(80, 18);
            this.lblValorTotal.TabIndex = 14;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // chkLstInformacao
            // 
            this.chkLstInformacao.BackColor = System.Drawing.SystemColors.Window;
            this.chkLstInformacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkLstInformacao.FormattingEnabled = true;
            this.chkLstInformacao.Items.AddRange(new object[] {
            "Anéis de Lua                10,00",
            "Batata Frita                   6,00",
            "Mandioca                     5,00",
            "Polenta                         7,00",
            "Nuggets c/ 12              14,40"});
            this.chkLstInformacao.Location = new System.Drawing.Point(12, 226);
            this.chkLstInformacao.Name = "chkLstInformacao";
            this.chkLstInformacao.Size = new System.Drawing.Size(165, 105);
            this.chkLstInformacao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Informações Adicionais:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(277, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(277, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 18;
            // 
            // frmGarcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLstInformacao);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.mtxtValorTotal);
            this.Controls.Add(this.mtxtValor);
            this.Controls.Add(this.lblValorDoKILO);
            this.Controls.Add(this.grbTipoRefeicao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblQtdRefeicao);
            this.Controls.Add(this.txtNumComanda);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGarcon";
            this.Text = "Self- Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbTipoRefeicao.ResumeLayout(false);
            this.grbTipoRefeicao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.TextBox txtNumComanda;
        private System.Windows.Forms.RadioButton rdAlmoco;
        private System.Windows.Forms.RadioButton rdMarmitex;
        private System.Windows.Forms.Label lblQtdRefeicao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grbTipoRefeicao;
        private System.Windows.Forms.Label lblValorDoKILO;
        private System.Windows.Forms.MaskedTextBox mtxtValor;
        private System.Windows.Forms.MaskedTextBox mtxtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.CheckedListBox chkLstInformacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;


    }
}

