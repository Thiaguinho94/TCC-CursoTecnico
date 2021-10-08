namespace Pesq_Caixa
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.txtNumComanda = new System.Windows.Forms.TextBox();
            this.lblNumComanda = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.btnFormadePagar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumComanda
            // 
            this.txtNumComanda.Location = new System.Drawing.Point(143, 22);
            this.txtNumComanda.Multiline = true;
            this.txtNumComanda.Name = "txtNumComanda";
            this.txtNumComanda.Size = new System.Drawing.Size(154, 24);
            this.txtNumComanda.TabIndex = 0;
            // 
            // lblNumComanda
            // 
            this.lblNumComanda.AutoSize = true;
            this.lblNumComanda.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComanda.Location = new System.Drawing.Point(12, 22);
            this.lblNumComanda.Name = "lblNumComanda";
            this.lblNumComanda.Size = new System.Drawing.Size(125, 24);
            this.lblNumComanda.TabIndex = 1;
            this.lblNumComanda.Text = "Nº Comanda:";
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(3, 49);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(466, 324);
            this.dgvCaixa.TabIndex = 2;
            // 
            // btnFormadePagar
            // 
            this.btnFormadePagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormadePagar.BackgroundImage")));
            this.btnFormadePagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormadePagar.Location = new System.Drawing.Point(475, 171);
            this.btnFormadePagar.Name = "btnFormadePagar";
            this.btnFormadePagar.Size = new System.Drawing.Size(75, 75);
            this.btnFormadePagar.TabIndex = 4;
            this.btnFormadePagar.UseVisualStyleBackColor = true;
            this.btnFormadePagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(573, 171);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(12, 384);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(112, 24);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProd.BackgroundImage")));
            this.btnRemoveProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProd.Location = new System.Drawing.Point(573, 62);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(75, 75);
            this.btnRemoveProd.TabIndex = 8;
            this.btnRemoveProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProd.BackgroundImage")));
            this.btnAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProd.Location = new System.Drawing.Point(475, 62);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 75);
            this.btnAddProd.TabIndex = 9;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Enabled = false;
            this.mtxtPreco.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPreco.Location = new System.Drawing.Point(130, 379);
            this.mtxtPreco.Mask = "$ 9999,99";
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(89, 26);
            this.mtxtPreco.TabIndex = 10;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 420);
            this.Controls.Add(this.mtxtPreco);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnRemoveProd);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFormadePagar);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.lblNumComanda);
            this.Controls.Add(this.txtNumComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaixa";
            this.Text = "CAIXA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumComanda;
        private System.Windows.Forms.Label lblNumComanda;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Button btnFormadePagar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnRemoveProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
    }
}

