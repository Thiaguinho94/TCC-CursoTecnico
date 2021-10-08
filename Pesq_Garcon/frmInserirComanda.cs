using System;
using System.Windows.Forms;

namespace Pesq_Garcon
{
    public partial class FrmInserirComanda : Form
    {
        private readonly string lbl_Nome;
        private readonly string cod_Nomepeixe;
        private readonly string txtnomepeixe;
        private readonly string Valor_Peixe;

        public FrmInserirComanda()
        {
            InitializeComponent();
        }

        public FrmInserirComanda(string lbl_nomePeixe, string str_NomePeixe, string txtNomePeixe, string value_peixe)
        {
            // TODO: Complete member initialization
            lbl_Nome = lbl_nomePeixe;
            cod_Nomepeixe = str_NomePeixe;
            txtnomepeixe = txtNomePeixe;
            Valor_Peixe = value_peixe;

            InitializeComponent();

            lblQtdProd.Text = "KILO:";
            lblDescrProduto.Text = lbl_Nome;
            txtNomeProduto.Text = txtnomepeixe;
            txtCodProduto.Text = cod_Nomepeixe;
            mtxtPreco.Text = Valor_Peixe;

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            //Irar salvar em uma bloco de notas todos os produto que foi solicitado
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtQdtProd_TextChanged(object sender, EventArgs e)
        {
            if (txtQdtProd.Text != "" && txtQdtProd.Text != "0")
            {
                string[] Salario_func = mtxtPreco.Text.ToString().Replace("R$", "").Split('.');
                double valor_tot = double.Parse(txtQdtProd.Text.ToString()) * double.Parse(Salario_func[0]);
                Salario_func[0] = valor_tot.ToString();

                maskedTextBox1.Text = Salario_func[0].Length == 1
                    ? "000" + Salario_func[0] + "." + Salario_func[1]
                    : Salario_func[0].Length == 2
                        ? "00" + Salario_func[0] + "." + Salario_func[1]
                        : Salario_func[0].Length == 3 ? "0" + Salario_func[0] + "." + Salario_func[1] : Salario_func[0] + "." + Salario_func[1];
            }
        }
    }
}
