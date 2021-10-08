namespace Pesq_Garcon
{
    partial class FrmInserirComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInserirComanda));
            this.txtQdtProd = new System.Windows.Forms.TextBox();
            this.lblQtdProd = new System.Windows.Forms.Label();
            this.txtNumComanda = new System.Windows.Forms.TextBox();
            this.lblNumComanda = new System.Windows.Forms.Label();
            this.grpbProduto = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoToTal = new System.Windows.Forms.Label();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblDescrProduto = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQdtProd
            // 
            this.txtQdtProd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQdtProd.Location = new System.Drawing.Point(413, 35);
            this.txtQdtProd.Name = "txtQdtProd";
            this.txtQdtProd.Size = new System.Drawing.Size(53, 23);
            this.txtQdtProd.TabIndex = 10;
            this.txtQdtProd.Text = "01";
            this.txtQdtProd.TextChanged += new System.EventHandler(this.TxtQdtProd_TextChanged);
            // 
            // lblQtdProd
            // 
            this.lblQtdProd.AutoSize = true;
            this.lblQtdProd.Location = new System.Drawing.Point(410, 20);
            this.lblQtdProd.Name = "lblQtdProd";
            this.lblQtdProd.Size = new System.Drawing.Size(77, 16);
            this.lblQtdProd.TabIndex = 9;
            this.lblQtdProd.Text = "Qtd. Produto:";
            // 
            // txtNumComanda
            // 
            this.txtNumComanda.Location = new System.Drawing.Point(12, 22);
            this.txtNumComanda.Name = "txtNumComanda";
            this.txtNumComanda.Size = new System.Drawing.Size(92, 20);
            this.txtNumComanda.TabIndex = 8;
            // 
            // lblNumComanda
            // 
            this.lblNumComanda.AutoSize = true;
            this.lblNumComanda.Location = new System.Drawing.Point(9, 6);
            this.lblNumComanda.Name = "lblNumComanda";
            this.lblNumComanda.Size = new System.Drawing.Size(95, 13);
            this.lblNumComanda.TabIndex = 7;
            this.lblNumComanda.Text = "Número Comanda:";
            // 
            // grpbProduto
            // 
            this.grpbProduto.BackColor = System.Drawing.Color.Transparent;
            this.grpbProduto.Controls.Add(this.maskedTextBox1);
            this.grpbProduto.Controls.Add(this.lblPrecoToTal);
            this.grpbProduto.Controls.Add(this.mtxtPreco);
            this.grpbProduto.Controls.Add(this.txtQdtProd);
            this.grpbProduto.Controls.Add(this.lblQtdProd);
            this.grpbProduto.Controls.Add(this.lblPreco);
            this.grpbProduto.Controls.Add(this.txtNomeProduto);
            this.grpbProduto.Controls.Add(this.lblDescrProduto);
            this.grpbProduto.Controls.Add(this.txtCodProduto);
            this.grpbProduto.Controls.Add(this.lblCodProduto);
            this.grpbProduto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProduto.Location = new System.Drawing.Point(2, 48);
            this.grpbProduto.Name = "grpbProduto";
            this.grpbProduto.Size = new System.Drawing.Size(586, 74);
            this.grpbProduto.TabIndex = 11;
            this.grpbProduto.TabStop = false;
            this.grpbProduto.Text = "Produto";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(497, 35);
            this.maskedTextBox1.Mask = "$0000,00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(79, 23);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // lblPrecoToTal
            // 
            this.lblPrecoToTal.AutoSize = true;
            this.lblPrecoToTal.Location = new System.Drawing.Point(494, 20);
            this.lblPrecoToTal.Name = "lblPrecoToTal";
            this.lblPrecoToTal.Size = new System.Drawing.Size(66, 16);
            this.lblPrecoToTal.TabIndex = 19;
            this.lblPrecoToTal.Text = " Preço Total";
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Enabled = false;
            this.mtxtPreco.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPreco.Location = new System.Drawing.Point(325, 35);
            this.mtxtPreco.Mask = "$0000,00";
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(79, 23);
            this.mtxtPreco.TabIndex = 18;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(322, 20);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(36, 16);
            this.lblPreco.TabIndex = 17;
            this.lblPreco.Text = "Preço";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(89, 35);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(211, 20);
            this.txtNomeProduto.TabIndex = 16;
            // 
            // lblDescrProduto
            // 
            this.lblDescrProduto.AutoSize = true;
            this.lblDescrProduto.Location = new System.Drawing.Point(85, 20);
            this.lblDescrProduto.Name = "lblDescrProduto";
            this.lblDescrProduto.Size = new System.Drawing.Size(104, 16);
            this.lblDescrProduto.TabIndex = 15;
            this.lblDescrProduto.Text = "Descrição Produto:";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(14, 36);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(65, 20);
            this.txtCodProduto.TabIndex = 14;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(11, 20);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(71, 16);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Código Prod:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(437, 128);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(64, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(524, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmInserirComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 155);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpbProduto);
            this.Controls.Add(this.txtNumComanda);
            this.Controls.Add(this.lblNumComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInserirComanda";
            this.grpbProduto.ResumeLayout(false);
            this.grpbProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQdtProd;
        private System.Windows.Forms.Label lblQtdProd;
        private System.Windows.Forms.TextBox txtNumComanda;
        private System.Windows.Forms.Label lblNumComanda;
        private System.Windows.Forms.GroupBox grpbProduto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblDescrProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblPrecoToTal;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
        private System.Windows.Forms.Label lblPreco;
    }
}