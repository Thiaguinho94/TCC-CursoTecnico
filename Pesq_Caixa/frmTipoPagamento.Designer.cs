namespace Pesq_Produto
{
    partial class FrmTipoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoPagamento));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConfimarPg = new System.Windows.Forms.Button();
            this.tbPDinheiro = new System.Windows.Forms.TabPage();
            this.mtxtTroco = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValorPago = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.tbcTipoPagamento = new System.Windows.Forms.TabControl();
            this.tbPDinheiro.SuspendLayout();
            this.tbcTipoPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(415, 236);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 70);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnConfimarPg
            // 
            this.btnConfimarPg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfimarPg.BackgroundImage")));
            this.btnConfimarPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfimarPg.Location = new System.Drawing.Point(1, 236);
            this.btnConfimarPg.Name = "btnConfimarPg";
            this.btnConfimarPg.Size = new System.Drawing.Size(70, 70);
            this.btnConfimarPg.TabIndex = 14;
            this.btnConfimarPg.UseVisualStyleBackColor = true;
            // 
            // tbPDinheiro
            // 
            this.tbPDinheiro.Controls.Add(this.mtxtTroco);
            this.tbPDinheiro.Controls.Add(this.mtxtValorPago);
            this.tbPDinheiro.Controls.Add(this.mtxtValorTotal);
            this.tbPDinheiro.Controls.Add(this.lblValorTotal);
            this.tbPDinheiro.Controls.Add(this.lblValorPago);
            this.tbPDinheiro.Controls.Add(this.lblTroco);
            this.tbPDinheiro.Location = new System.Drawing.Point(23, 4);
            this.tbPDinheiro.Name = "tbPDinheiro";
            this.tbPDinheiro.Padding = new System.Windows.Forms.Padding(3);
            this.tbPDinheiro.Size = new System.Drawing.Size(461, 211);
            this.tbPDinheiro.TabIndex = 0;
            this.tbPDinheiro.Text = "Dinheiro";
            this.tbPDinheiro.UseVisualStyleBackColor = true;
            // 
            // mtxtTroco
            // 
            this.mtxtTroco.Enabled = false;
            this.mtxtTroco.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTroco.Location = new System.Drawing.Point(141, 111);
            this.mtxtTroco.Mask = "$ 0000,00";
            this.mtxtTroco.Name = "mtxtTroco";
            this.mtxtTroco.Size = new System.Drawing.Size(101, 30);
            this.mtxtTroco.TabIndex = 10;
            // 
            // mtxtValorPago
            // 
            this.mtxtValorPago.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorPago.Location = new System.Drawing.Point(141, 59);
            this.mtxtValorPago.Mask = "$ 0000,00";
            this.mtxtValorPago.Name = "mtxtValorPago";
            this.mtxtValorPago.Size = new System.Drawing.Size(101, 30);
            this.mtxtValorPago.TabIndex = 9;
            // 
            // mtxtValorTotal
            // 
            this.mtxtValorTotal.Enabled = false;
            this.mtxtValorTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtValorTotal.Location = new System.Drawing.Point(141, 8);
            this.mtxtValorTotal.Mask = "$ 0000,00";
            this.mtxtValorTotal.Name = "mtxtValorTotal";
            this.mtxtValorTotal.Size = new System.Drawing.Size(101, 30);
            this.mtxtValorTotal.TabIndex = 8;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(11, 14);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(114, 24);
            this.lblValorTotal.TabIndex = 1;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(11, 62);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(110, 24);
            this.lblValorPago.TabIndex = 0;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(54, 111);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(67, 24);
            this.lblTroco.TabIndex = 2;
            this.lblTroco.Text = "Troco:";
            // 
            // tbcTipoPagamento
            // 
            this.tbcTipoPagamento.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcTipoPagamento.Controls.Add(this.tbPDinheiro);
            this.tbcTipoPagamento.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcTipoPagamento.Location = new System.Drawing.Point(1, 1);
            this.tbcTipoPagamento.Multiline = true;
            this.tbcTipoPagamento.Name = "tbcTipoPagamento";
            this.tbcTipoPagamento.SelectedIndex = 0;
            this.tbcTipoPagamento.Size = new System.Drawing.Size(488, 219);
            this.tbcTipoPagamento.TabIndex = 11;
            // 
            // frmTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.btnConfimarPg);
            this.Controls.Add(this.tbcTipoPagamento);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPagamento";
            this.Text = "Forma de Pagamento";
            this.tbPDinheiro.ResumeLayout(false);
            this.tbPDinheiro.PerformLayout();
            this.tbcTipoPagamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfimarPg;
        private System.Windows.Forms.TabPage tbPDinheiro;
        private System.Windows.Forms.MaskedTextBox mtxtTroco;
        private System.Windows.Forms.MaskedTextBox mtxtValorPago;
        private System.Windows.Forms.MaskedTextBox mtxtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TabControl tbcTipoPagamento;
    }
}