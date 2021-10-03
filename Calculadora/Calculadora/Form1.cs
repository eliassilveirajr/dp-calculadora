using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        char operacao = ' ';
        decimal primeiroValor = 0, segundoValor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btZero_Click(object sender, EventArgs e)
        { 
            if(tbResultado.Text != "")
            {
                tbResultado.Text += "0";
            }             
        }

        private void btUm_Click(object sender, EventArgs e)
        { 
            tbResultado.Text += "1";
        }

        private void btDois_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "3";
        }

        private void btQuatro_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "6";
        }

        private void btSete_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "7";
        }

        private void btOito_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "8";
        }

        private void btNove_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "9";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            operacao = '*';
            tbResultado.Text = "";
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            operacao = '/';
            tbResultado.Text = "";
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            operacao = '-';
            tbResultado.Text = "";
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            operacao = '+';
            tbResultado.Text = "";
        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            tbResultado.Text += ".";
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "") {
                segundoValor = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            }

            switch (operacao)
            {
                case  '+':
                    tbResultado.Text = Convert.ToString(primeiroValor + segundoValor, CultureInfo.InvariantCulture);
                    break;

                case '-':
                    tbResultado.Text = Convert.ToString(primeiroValor - segundoValor);
                    break;

                case '/':
                    tbResultado.Text = Convert.ToString(primeiroValor / segundoValor);
                    break;

                case '*':
                    tbResultado.Text = Convert.ToString(primeiroValor * segundoValor);
                    break;

                default:
                    break;
            }
        }
    }
}
