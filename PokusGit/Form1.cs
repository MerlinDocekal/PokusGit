using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int vysledek = a + b;

            MessageBox.Show("Výsledek je " + vysledek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int vysledek = a - b;

            MessageBox.Show("Výsledek je " + vysledek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int vysledek = a * b;

            MessageBox.Show("Výsledek je " + vysledek);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            double vysledek = (double)a / b;

            MessageBox.Show("Výsledek je " + vysledek);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2 Merlin Dočekal");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);

            int faktorial = 1;
            for(int i = 1; i <= x; i++)
            {
                faktorial *= i;
            }

            MessageBox.Show("Faktoriál je " + faktorial);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Mocnina textbox1 na textbox2

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int mocnina = 1;
            for(int i = 0; i < b; i++)
            {
                mocnina *= a;
            }

            MessageBox.Show("Mocnina je " + mocnina);
        }
    }
}
