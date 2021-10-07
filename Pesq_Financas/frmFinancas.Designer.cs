namespace Pesq_Financas
{
    partial class frmFinancas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancas));
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlLucro = new System.Windows.Forms.Panel();
            this.pnlDespesa = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(589, 248);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(33, 34);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlLucro
            // 
            this.pnlLucro.BackColor = System.Drawing.Color.Transparent;
            this.pnlLucro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLucro.BackgroundImage")));
            this.pnlLucro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLucro.Location = new System.Drawing.Point(21, 12);
            this.pnlLucro.Name = "pnlLucro";
            this.pnlLucro.Size = new System.Drawing.Size(203, 240);
            this.pnlLucro.TabIndex = 3;
            this.pnlLucro.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnlDespesa
            // 
            this.pnlDespesa.BackColor = System.Drawing.Color.Transparent;
            this.pnlDespesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDespesa.BackgroundImage")));
            this.pnlDespesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDespesa.Location = new System.Drawing.Point(341, 28);
            this.pnlDespesa.Name = "pnlDespesa";
            this.pnlDespesa.Size = new System.Drawing.Size(214, 224);
            this.pnlDespesa.TabIndex = 4;
            this.pnlDespesa.Click += new System.EventHandler(this.pnlDespesa_Click);
            // 
            // frmFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 294);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDespesa);
            this.Controls.Add(this.pnlLucro);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlLucro;
        private System.Windows.Forms.Panel pnlDespesa;
    }
}