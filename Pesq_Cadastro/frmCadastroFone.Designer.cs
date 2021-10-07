namespace Pesq_Cadastro
{
    partial class frmCadastroFone
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFone));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.dgvFone = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ttText = new System.Windows.Forms.ToolTip(this.components);
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.rdbFone = new System.Windows.Forms.RadioButton();
            this.lblObservação = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.BackColor = System.Drawing.Color.Transparent;
            this.lblFone.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.Location = new System.Drawing.Point(71, 6);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(61, 18);
            this.lblFone.TabIndex = 2;
            this.lblFone.Text = "Telefone:";
            // 
            // mtxtFone
            // 
            this.mtxtFone.Location = new System.Drawing.Point(74, 24);
            this.mtxtFone.Mask = "99999-9999";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.Size = new System.Drawing.Size(65, 20);
            this.mtxtFone.TabIndex = 3;
            this.mtxtFone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFone_MaskInputRejected);
            this.mtxtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtFone_KeyPress);
            // 
            // dgvFone
            // 
            this.dgvFone.AllowUserToAddRows = false;
            this.dgvFone.AllowUserToDeleteRows = false;
            this.dgvFone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Telefone});
            this.dgvFone.Location = new System.Drawing.Point(6, 52);
            this.dgvFone.Name = "dgvFone";
            this.dgvFone.ReadOnly = true;
            this.dgvFone.RowHeadersVisible = false;
            this.dgvFone.Size = new System.Drawing.Size(274, 229);
            this.dgvFone.TabIndex = 4;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 50;
            // 
            // Telefone
            // 
            dataGridViewCellStyle1.Format = "99999-9999";
            dataGridViewCellStyle1.NullValue = null;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle1;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 220;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(292, 207);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(55, 55);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(292, 146);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 55);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(292, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 55);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rdbCelular
            // 
            this.rdbCelular.AutoSize = true;
            this.rdbCelular.BackColor = System.Drawing.Color.Transparent;
            this.rdbCelular.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelular.Location = new System.Drawing.Point(240, 20);
            this.rdbCelular.Name = "rdbCelular";
            this.rdbCelular.Size = new System.Drawing.Size(64, 22);
            this.rdbCelular.TabIndex = 9;
            this.rdbCelular.TabStop = true;
            this.rdbCelular.Text = "Celular";
            this.rdbCelular.UseVisualStyleBackColor = false;
            this.rdbCelular.CheckedChanged += new System.EventHandler(this.rdbCelular_CheckedChanged);
            // 
            // rdbFone
            // 
            this.rdbFone.AutoSize = true;
            this.rdbFone.BackColor = System.Drawing.Color.Transparent;
            this.rdbFone.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFone.Location = new System.Drawing.Point(159, 20);
            this.rdbFone.Name = "rdbFone";
            this.rdbFone.Size = new System.Drawing.Size(75, 22);
            this.rdbFone.TabIndex = 10;
            this.rdbFone.TabStop = true;
            this.rdbFone.Text = "Telefone";
            this.rdbFone.UseVisualStyleBackColor = false;
            this.rdbFone.CheckedChanged += new System.EventHandler(this.rdbFone_CheckedChanged);
            // 
            // lblObservação
            // 
            this.lblObservação.AutoSize = true;
            this.lblObservação.BackColor = System.Drawing.Color.Transparent;
            this.lblObservação.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservação.ForeColor = System.Drawing.Color.Red;
            this.lblObservação.Location = new System.Drawing.Point(3, 293);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(183, 18);
            this.lblObservação.TabIndex = 11;
            this.lblObservação.Text = "Enter - Adicionar novo telefone";
            // 
            // frmCadastroFone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 312);
            this.ControlBox = false;
            this.Controls.Add(this.lblObservação);
            this.Controls.Add(this.rdbFone);
            this.Controls.Add(this.rdbCelular);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvFone);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastroFone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastroFone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.DataGridView dgvFone;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip ttText;
        private System.Windows.Forms.RadioButton rdbCelular;
        private System.Windows.Forms.RadioButton rdbFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Label lblObservação;
    }
}