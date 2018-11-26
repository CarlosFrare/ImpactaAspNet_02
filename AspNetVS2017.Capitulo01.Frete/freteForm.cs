using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text == string.Empty)
            //if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                erros.Add("Campo cliente é obrigatório !!!");
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione uma UF !!!");
            }

            if (valorTextBox.Text == string.Empty)
            {
                erros.Add("Campo valor é obrigatório !!!");
            }
            else
            {   
                //no visual 2015
                //var valor = 0m
                if (! decimal.TryParse(valorTextBox.Text, out decimal valor)  )
                {
                    erros.Add("Valor esta no formato invalido !!!");
                }
            }


            return erros;
        }

        private void Calcular()
        {
            decimal percentual = 0m;
            decimal valor = Convert.ToDecimal(valorTextBox.Text);

            //modelo VS2017 (recurso novo)
            var nordeste = new List<string> { "BA","PE","AL","PB"};

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "RJ":
                    percentual = 0.3m;
                    break;

                case "MG":
                    percentual = 0.35m;
                    break;

                case "AM":
                    percentual = 0.6m;
                    break;

                // modelo VS2017 (recurso novo)
                case var uf when nordeste.Contains(uf):
                    percentual = 0.5m;
                    break;
                case null:
                    throw new NullReferenceException("Combobox nullo!");
                //

                default:
                    percentual = 0.5m;
                    break;
            }

            freteTextBox.Text = percentual.ToString("P2");
            totalTextBox.Text = (valor * (1 + percentual)).ToString("C2");  
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = string.Empty;
            ufComboBox.SelectedIndex = -1;
            valorTextBox.Text = string.Empty;
            freteTextBox.Text = string.Empty;
            totalTextBox.Clear();

            clienteTextBox.Focus();

            //this.BackColor.Equals("RED");
        }
    }
}
