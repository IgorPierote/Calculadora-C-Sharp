using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mult = 1, valor;

            foreach (Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    mult *= valor;
                }
                this.Controls["label8"].Text = mult.ToString();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double div = 1, valor;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    div /= valor;
                }
                this.Controls["label8"].Text = div.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double soma = 0, valor;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }
                this.Controls["label8"].Text = soma.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sub = 1, valor;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    sub -= valor;
                }
                this.Controls["label8"].Text = sub.ToString();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
