namespace Pesq_MenuPrincipal
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.ptbCaixa = new System.Windows.Forms.PictureBox();
            this.ptbPequeiro = new System.Windows.Forms.PictureBox();
            this.ptbGarcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPequeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGarcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(590, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 32);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.BackColor = System.Drawing.Color.Transparent;
            this.ptbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbMenu.BackgroundImage")));
            this.ptbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMenu.Location = new System.Drawing.Point(377, 43);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(191, 182);
            this.ptbMenu.TabIndex = 2;
            this.ptbMenu.TabStop = false;
            this.ptbMenu.Click += new System.EventHandler(this.ptbMenu_Click);
            // 
            // ptbCaixa
            // 
            this.ptbCaixa.BackColor = System.Drawing.Color.Transparent;
            this.ptbCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbCaixa.BackgroundImage")));
            this.ptbCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCaixa.Location = new System.Drawing.Point(66, 43);
            this.ptbCaixa.Name = "ptbCaixa";
            this.ptbCaixa.Size = new System.Drawing.Size(191, 182);
            this.ptbCaixa.TabIndex = 3;
            this.ptbCaixa.TabStop = false;
            this.ptbCaixa.Click += new System.EventHandler(this.ptbCaixa_Click);
            // 
            // ptbPequeiro
            // 
            this.ptbPequeiro.BackColor = System.Drawing.Color.Transparent;
            this.ptbPequeiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbPequeiro.BackgroundImage")));
            this.ptbPequeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPequeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbPequeiro.Location = new System.Drawing.Point(66, 287);
            this.ptbPequeiro.Name = "ptbPequeiro";
            this.ptbPequeiro.Size = new System.Drawing.Size(191, 182);
            this.ptbPequeiro.TabIndex = 7;
            this.ptbPequeiro.TabStop = false;
            this.ptbPequeiro.Click += new System.EventHandler(this.ptbPequeiro_Click);
            // 
            // ptbGarcon
            // 
            this.ptbGarcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbGarcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbGarcon.BackgroundImage")));
            this.ptbGarcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbGarcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbGarcon.Location = new System.Drawing.Point(377, 287);
            this.ptbGarcon.Name = "ptbGarcon";
            this.ptbGarcon.Size = new System.Drawing.Size(191, 182);
            this.ptbGarcon.TabIndex = 9;
            this.ptbGarcon.TabStop = false;
            this.ptbGarcon.Click += new System.EventHandler(this.ptbGarcon_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 556);
            this.Controls.Add(this.ptbGarcon);
            this.Controls.Add(this.ptbPequeiro);
            this.Controls.Add(this.ptbCaixa);
            this.Controls.Add(this.ptbMenu);
            this.Controls.Add(this.btnSair);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                     Sistema Integrado - Pesqueir" +
    "o e Restaurante Micaxu";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPequeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGarcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.PictureBox ptbCaixa;
        private System.Windows.Forms.PictureBox ptbPequeiro;
        private System.Windows.Forms.PictureBox ptbGarcon;

    }
}

