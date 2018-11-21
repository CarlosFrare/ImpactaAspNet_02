using System;
using System.Windows.Forms;

namespace AspNetVS2017
{
    public partial class VariaveisForm : Form
    {

        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;
        
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;

            //int meuInteiro = 10;
            ////int A = 35;
            //decimal valor = 22.20m;
            //DateTime data = new DateTime(1970, 12, 20);
            //decimal nota;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = " + b));
            resultadoListBox.Items.Add(String.Format("c = {0}", c));
            //resultadoListBox.Items.Add("d = " + d);
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add("-----------------------------------");
            resultadoListBox.Items.Add("c *d = " + (c * d));
            resultadoListBox.Items.Add("c / d = " + (c / d));
            resultadoListBox.Items.Add("d % a = " + (d % a));

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;

            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;

            x -= 3;
            resultadoListBox.Items.Add("x = " + x);

        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;
            resultadoListBox.Items.Add("exemplo pre incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a  = " + (2 + ++a));


            a = 5;
            resultadoListBox.Items.Add("exemplo pós incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++  = " + (2 + a++));
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApresentarValoresVariaveis();

            resultadoListBox.Items.Add("w <= x = " + (w <= x));
            resultadoListBox.Items.Add("x == z = " + (x == z));
            resultadoListBox.Items.Add("x != z = " + (x != z));

        }

        private void ApresentarValoresVariaveis()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("z = " + z);
            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApresentarValoresVariaveis();

            resultadoListBox.Items.Add("w <= x || y == 16 = " + (w <= x || y == 16));
            resultadoListBox.Items.Add("w <= x && y == 16 = " + (x == z && x != z));

            resultadoListBox.Items.Add(" !(y >= w) = " + (!(y >= w)));

        }

        private void TenariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            ano = 2020;

            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                DateTime.IsLeapYear(ano) ? "Sim" : "Não"));


        }
    }
}