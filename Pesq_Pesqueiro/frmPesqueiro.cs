using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pesq_Pesqueiro
{
    public partial class frmPesqueiro : Form
    {
        public frmPesqueiro()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            opfdPeixe.InitialDirectory = @"C:\";
            opfdPeixe.RestoreDirectory = true;

            opfdPeixe.Title = "Localizar Arquivo";
            opfdPeixe.DefaultExt = "png";
            opfdPeixe.Filter = "(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            opfdPeixe.FilterIndex = 2;
            opfdPeixe.CheckFileExists = true;
            opfdPeixe.CheckPathExists = true;

            DialogResult dr = this.opfdPeixe.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string path = opfdPeixe.FileName;

                    Image img = Image.FromFile(path);
                    
                    ptbPeixe.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptbPeixe.Height = 100;
                    ptbPeixe.Width = 100;
                    ptbPeixe.Image = img;
                 
                }
               
                catch (Exception ex)
                {
                    // Não pode carregar a imagem (problemas de permissão)
                    MessageBox.Show("Não é possível exibir a imagem.Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
 
            }

                



        }

        private void ptbPeixe_Click(object sender, EventArgs e)
        {

        }

        private void grpbCadPeixes_Enter(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Pesq_Garcon.frmInserirComanda insert = new Pesq_Garcon.frmInserirComanda(lblNomePeixe.Text.ToString(), txtCodigo.Text.ToString(), txtNomePeixe.Text.ToString(), mtxtValorPeixe.Text.ToString());
            insert.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTipoVara_Click(object sender, EventArgs e)
        {

        }

        private void mtxtValorPeixe_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmPesqueiro_Load(object sender, EventArgs e)
        {

        }
    }
}
