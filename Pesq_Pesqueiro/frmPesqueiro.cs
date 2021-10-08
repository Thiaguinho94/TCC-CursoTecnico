using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pesq_Pesqueiro
{
    public partial class frmPesqueiro : Form
    {
        public frmPesqueiro()
        {
            InitializeComponent();
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            opfdPeixe.InitialDirectory = @"C:\";
            opfdPeixe.RestoreDirectory = true;

            opfdPeixe.Title = "Localizar Arquivo";
            opfdPeixe.DefaultExt = "png";
            opfdPeixe.Filter = "(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            opfdPeixe.FilterIndex = 2;
            opfdPeixe.CheckFileExists = true;
            opfdPeixe.CheckPathExists = true;

            DialogResult dr = opfdPeixe.ShowDialog();

            if (dr == DialogResult.OK)
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

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Pesq_Garcon.FrmInserirComanda insert = new Pesq_Garcon.FrmInserirComanda(lblNomePeixe.Text.ToString(), txtCodigo.Text.ToString(), txtNomePeixe.Text.ToString(), mtxtValorPeixe.Text.ToString());
            insert.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
