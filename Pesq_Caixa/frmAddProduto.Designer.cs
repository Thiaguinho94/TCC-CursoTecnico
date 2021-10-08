namespace Pesq_Caixa
{
    partial class frmAddProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduto));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.gpbDadoProd = new System.Windows.Forms.GroupBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.mtxtPrecoTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Descricao_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbDadoProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao_Prod,
            this.Preco_Uni});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(422, 298);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisa.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(9, 313);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(60, 16);
            this.lblPesquisa.TabIndex = 2;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(71, 310);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(354, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.Location = new System.Drawing.Point(6, 22);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(101, 16);
            this.lblDescrição.TabIndex = 4;
            this.lblDescrição.Text = "Descrição Produto";
            // 
            // gpbDadoProd
            // 
            this.gpbDadoProd.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadoProd.Controls.Add(this.txtQtd);
            this.gpbDadoProd.Controls.Add(this.mtxtPrecoTotal);
            this.gpbDadoProd.Controls.Add(this.mtxtPrecoUnitario);
            this.gpbDadoProd.Controls.Add(this.lblPrecoTotal);
            this.gpbDadoProd.Controls.Add(this.lblPrecoUnitario);
            this.gpbDadoProd.Controls.Add(this.lblQtd);
            this.gpbDadoProd.Controls.Add(this.txtDescProduto);
            this.gpbDadoProd.Controls.Add(this.lblDescrição);
            this.gpbDadoProd.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadoProd.Location = new System.Drawing.Point(435, 7);
            this.gpbDadoProd.Name = "gpbDadoProd";
            this.gpbDadoProd.Size = new System.Drawing.Size(359, 134);
            this.gpbDadoProd.TabIndex = 5;
            this.gpbDadoProd.TabStop = false;
            this.gpbDadoProd.Text = "Dados do Produto";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(9, 97);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(81, 26);
            this.txtQtd.TabIndex = 26;
            this.txtQtd.Text = "01";
            // 
            // mtxtPrecoTotal
            // 
            this.mtxtPrecoTotal.Enabled = false;
            this.mtxtPrecoTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecoTotal.Location = new System.Drawing.Point(224, 97);
            this.mtxtPrecoTotal.Mask = "$ 0000,00";
            this.mtxtPrecoTotal.Name = "mtxtPrecoTotal";
            this.mtxtPrecoTotal.Size = new System.Drawing.Size(101, 26);
            this.mtxtPrecoTotal.TabIndex = 25;
            // 
            // mtxtPrecoUnitario
            // 
            this.mtxtPrecoUnitario.Enabled = false;
            this.mtxtPrecoUnitario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecoUnitario.Location = new System.Drawing.Point(107, 97);
            this.mtxtPrecoUnitario.Mask = "$ 0000,00";
            this.mtxtPrecoUnitario.Name = "mtxtPrecoUnitario";
            this.mtxtPrecoUnitario.Size = new System.Drawing.Size(101, 26);
            this.mtxtPrecoUnitario.TabIndex = 24;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(221, 81);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(69, 16);
            this.lblPrecoTotal.TabIndex = 8;
            this.lblPrecoTotal.Text = "Preço Total:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.Location = new System.Drawing.Point(104, 81);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(85, 16);
            this.lblPrecoUnitario.TabIndex = 7;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(9, 81);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(70, 16);
            this.lblQtd.TabIndex = 6;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Enabled = false;
            this.txtDescProduto.Location = new System.Drawing.Point(9, 38);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(336, 20);
            this.txtDescProduto.TabIndex = 5;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.BackgroundImage")));
            this.btnAddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduto.Location = new System.Drawing.Point(444, 225);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(75, 75);
            this.btnAddProduto.TabIndex = 6;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(542, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 75);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Descricao_Prod
            // 
            this.Descricao_Prod.HeaderText = "Descrição Produto";
            this.Descricao_Prod.Name = "Descricao_Prod";
            // 
            // Preco_Uni
            // 
            this.Preco_Uni.HeaderText = "Preço Unitário";
            this.Preco_Uni.Name = "Preco_Uni";
            // 
            // frmAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.gpbDadoProd);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.FrmAddProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbDadoProd.ResumeLayout(false);
            this.gpbDadoProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.GroupBox gpbDadoProd;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoTotal;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoUnitario;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Uni;
    }
}