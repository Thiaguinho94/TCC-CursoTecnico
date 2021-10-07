namespace Pesq_Financas
{
    partial class frmLucro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLucro));
            this.chkDe = new System.Windows.Forms.CheckBox();
            this.dtComeco = new System.Windows.Forms.DateTimePicker();
            this.chkAte = new System.Windows.Forms.CheckBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grbFiltro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.grbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDe
            // 
            this.chkDe.AutoSize = true;
            this.chkDe.Location = new System.Drawing.Point(6, 19);
            this.chkDe.Name = "chkDe";
            this.chkDe.Size = new System.Drawing.Size(40, 20);
            this.chkDe.TabIndex = 0;
            this.chkDe.Text = "De";
            this.chkDe.UseVisualStyleBackColor = true;
            // 
            // dtComeco
            // 
            this.dtComeco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtComeco.Location = new System.Drawing.Point(52, 19);
            this.dtComeco.Name = "dtComeco";
            this.dtComeco.Size = new System.Drawing.Size(100, 20);
            this.dtComeco.TabIndex = 1;
            // 
            // chkAte
            // 
            this.chkAte.AutoSize = true;
            this.chkAte.Location = new System.Drawing.Point(188, 19);
            this.chkAte.Name = "chkAte";
            this.chkAte.Size = new System.Drawing.Size(44, 20);
            this.chkAte.TabIndex = 2;
            this.chkAte.Text = "Até";
            this.chkAte.UseVisualStyleBackColor = true;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(238, 19);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(96, 20);
            this.dtFim.TabIndex = 3;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(4, 80);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(702, 321);
            this.dgvPesquisa.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(350, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(64, 58);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(647, 407);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grbFiltro
            // 
            this.grbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.grbFiltro.Controls.Add(this.dtFim);
            this.grbFiltro.Controls.Add(this.chkAte);
            this.grbFiltro.Controls.Add(this.dtComeco);
            this.grbFiltro.Controls.Add(this.chkDe);
            this.grbFiltro.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltro.Location = new System.Drawing.Point(4, 12);
            this.grbFiltro.Name = "grbFiltro";
            this.grbFiltro.Size = new System.Drawing.Size(340, 50);
            this.grbFiltro.TabIndex = 9;
            this.grbFiltro.TabStop = false;
            this.grbFiltro.Text = "Filtro";
            // 
            // frmLucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 476);
            this.Controls.Add(this.grbFiltro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLucro";
            this.Text = "Lucro";
            this.Load += new System.EventHandler(this.frmLucro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.grbFiltro.ResumeLayout(false);
            this.grbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDe;
        private System.Windows.Forms.DateTimePicker dtComeco;
        private System.Windows.Forms.CheckBox chkAte;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grbFiltro;
    }
}

