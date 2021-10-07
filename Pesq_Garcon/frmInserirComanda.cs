using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pesq_Garcon
{
    public partial class frmInserirComanda : Form
    {
        private string lbl_Nome;
        private string cod_Nomepeixe;
        private string txtnomepeixe;
        private string Valor_Peixe;

        public frmInserirComanda()
        {
            InitializeComponent();
        }
        
        public frmInserirComanda(string lbl_nomePeixe, string str_NomePeixe, string txtNomePeixe, string value_peixe)
        {
            // TODO: Complete member initialization
            this.lbl_Nome = lbl_nomePeixe;
            this.cod_Nomepeixe = str_NomePeixe;
            this.txtnomepeixe = txtNomePeixe;
            this.Valor_Peixe = value_peixe;

            InitializeComponent();

            lblQtdProd.Text = "KILO:";
            lblDescrProduto.Text = lbl_Nome;
            txtNomeProduto.Text = txtnomepeixe;
            txtCodProduto.Text = cod_Nomepeixe;
            mtxtPreco.Text = Valor_Peixe;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Irar salvar em uma bloco de notas todos os produto que foi solicitado
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQdtProd_TextChanged(object sender, EventArgs e)
        {
            if (txtQdtProd.Text != "" && txtQdtProd.Text != "0")
            {   
                string[] Salario_func = mtxtPreco.Text.ToString().Replace("R$", "").Split('.');
                double valor_tot = double.Parse(txtQdtProd.Text.ToString()) * double.Parse(Salario_func[0]);
                Salario_func[0] = valor_tot.ToString();
                if (Salario_func[0].Length == 1)
                    maskedTextBox1.Text = "000" + Salario_func[0] + "." + Salario_func[1];
                else if (Salario_func[0].Length == 2)
                    maskedTextBox1.Text = "00" + Salario_func[0] + "." + Salario_func[1];
                else if (Salario_func[0].Length == 3)
                    maskedTextBox1.Text = "0" + Salario_func[0] + "." + Salario_func[1];
                else
                    maskedTextBox1.Text = Salario_func[0] + "." + Salario_func[1];
            }
        }
    }
}
