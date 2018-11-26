using System;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {


            int moed = 0;
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text); 
            decimal valorTroco = (valorPago - valorCompra);

            trocoTextBox.Text = valorTroco.ToString("c2");

            //ToDo: Refatorar para utilização de vetor com ForEach
            var moedas = new decimal[] { 1, 05m, 25m, 10m, 0.05m, 0.01m };

            for (int i = 0; i < moedas.Length; i++)
            {

                moedasListView.Items[i].Text = ((int)(valorTroco / moedas[i])).ToString();
                valorTroco %= moedas[i];
            }


            /*int moedas1 = (int)(valorTroco/1);
            valorTroco %= 1;

            int moedas050 = (int)(valorTroco / .05m);
            valorTroco %= .05m;

            int moedas025 = (int)(valorTroco / .25m);
            valorTroco %= .25m;

            int moedas010 = (int)(valorTroco / .10m);
            valorTroco %= .10m;

            int moedas005 = (int)(valorTroco / 0.05m);
            valorTroco %= 0.05m;

            int moedas001 = (int)(valorTroco / 0.01m);
            valorTroco %= 0.01m;

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();
            */


        }

        private void moedasListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
