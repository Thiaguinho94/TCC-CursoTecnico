namespace Pesq_MenuPrincipal
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ptcCadastro = new System.Windows.Forms.PictureBox();
            this.ptcConsulta = new System.Windows.Forms.PictureBox();
            this.ptcPedido = new System.Windows.Forms.PictureBox();
            this.ptcProd = new System.Windows.Forms.PictureBox();
            this.ptcFinanca = new System.Windows.Forms.PictureBox();
            this.ptcVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFinanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcCadastro
            // 
            this.ptcCadastro.BackColor = System.Drawing.Color.Transparent;
            this.ptcCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptcCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcCadastro.Image = ((System.Drawing.Image)(resources.GetObject("ptcCadastro.Image")));
            this.ptcCadastro.Location = new System.Drawing.Point(12, 114);
            this.ptcCadastro.Name = "ptcCadastro";
            this.ptcCadastro.Size = new System.Drawing.Size(247, 128);
            this.ptcCadastro.TabIndex = 0;
            this.ptcCadastro.TabStop = false;
            this.ptcCadastro.Click += new System.EventHandler(this.llbCadastro_Click);
            // 
            // ptcConsulta
            // 
            this.ptcConsulta.BackColor = System.Drawing.Color.Transparent;
            this.ptcConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptcConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcConsulta.Image = ((System.Drawing.Image)(resources.GetObject("ptcConsulta.Image")));
            this.ptcConsulta.Location = new System.Drawing.Point(343, 135);
            this.ptcConsulta.Name = "ptcConsulta";
            this.ptcConsulta.Size = new System.Drawing.Size(251, 128);
            this.ptcConsulta.TabIndex = 2;
            this.ptcConsulta.TabStop = false;
            this.ptcConsulta.Click += new System.EventHandler(this.ptcConsulta_Click);
            // 
            // ptcPedido
            // 
            this.ptcPedido.BackColor = System.Drawing.Color.Transparent;
            this.ptcPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcPedido.Image = ((System.Drawing.Image)(resources.GetObject("ptcPedido.Image")));
            this.ptcPedido.Location = new System.Drawing.Point(12, 257);
            this.ptcPedido.Name = "ptcPedido";
            this.ptcPedido.Size = new System.Drawing.Size(247, 137);
            this.ptcPedido.TabIndex = 6;
            this.ptcPedido.TabStop = false;
            this.ptcPedido.Click += new System.EventHandler(this.lPedido_Click);
            // 
            // ptcProd
            // 
            this.ptcProd.BackColor = System.Drawing.Color.Transparent;
            this.ptcProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptcProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcProd.Image = ((System.Drawing.Image)(resources.GetObject("ptcProd.Image")));
            this.ptcProd.Location = new System.Drawing.Point(343, 269);
            this.ptcProd.Name = "ptcProd";
            this.ptcProd.Size = new System.Drawing.Size(251, 135);
            this.ptcProd.TabIndex = 8;
            this.ptcProd.TabStop = false;
            this.ptcProd.Click += new System.EventHandler(this.lProduto_Click);
            // 
            // ptcFinanca
            // 
            this.ptcFinanca.BackColor = System.Drawing.Color.Transparent;
            this.ptcFinanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptcFinanca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcFinanca.Image = ((System.Drawing.Image)(resources.GetObject("ptcFinanca.Image")));
            this.ptcFinanca.Location = new System.Drawing.Point(12, 416);
            this.ptcFinanca.Name = "ptcFinanca";
            this.ptcFinanca.Size = new System.Drawing.Size(247, 143);
            this.ptcFinanca.TabIndex = 10;
            this.ptcFinanca.TabStop = false;
            this.ptcFinanca.Click += new System.EventHandler(this.ptcFinanca_Click);
            // 
            // ptcVoltar
            // 
            this.ptcVoltar.BackColor = System.Drawing.Color.Transparent;
            this.ptcVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptcVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcVoltar.Image = ((System.Drawing.Image)(resources.GetObject("ptcVoltar.Image")));
            this.ptcVoltar.Location = new System.Drawing.Point(343, 414);
            this.ptcVoltar.Name = "ptcVoltar";
            this.ptcVoltar.Size = new System.Drawing.Size(251, 143);
            this.ptcVoltar.TabIndex = 13;
            this.ptcVoltar.TabStop = false;
            this.ptcVoltar.Click += new System.EventHandler(this.ptcVoltar_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 574);
            this.ControlBox = false;
            this.Controls.Add(this.ptcVoltar);
            this.Controls.Add(this.ptcFinanca);
            this.Controls.Add(this.ptcProd);
            this.Controls.Add(this.ptcPedido);
            this.Controls.Add(this.ptcConsulta);
            this.Controls.Add(this.ptcCadastro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFinanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcCadastro;
        private System.Windows.Forms.PictureBox ptcConsulta;
        private System.Windows.Forms.PictureBox ptcPedido;
        private System.Windows.Forms.PictureBox ptcProd;
        private System.Windows.Forms.PictureBox ptcFinanca;
        private System.Windows.Forms.PictureBox ptcVoltar;
    }
}