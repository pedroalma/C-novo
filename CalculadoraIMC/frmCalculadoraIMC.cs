using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhadePagamento
{
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void lblidade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtidade.Text = "";
            txtpeso.Clear();
            txtimc.Clear();

            txtidade.Focus();
        }

        private void txtidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double num1, num2, num3, resp;
            string classificacao = "";

            num1 = Convert.ToDouble(txtidade.Text);
            num2 = Convert.ToDouble(txtpeso.Text);

            num3 = num1 * num1;

            resp = num2 / num3;

            if (resp < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (resp < 25)
            {
                classificacao = "Peso normal";
            }
            else if (resp < 30)
            {
                classificacao = "Sobrepeso";
            }
            else if (resp < 35)
            {
                classificacao = "Obesidade grau I";
            }
            else if (resp < 40)
            {
                classificacao = "Obesidade grau II";
            }
            txtimc.Text = $"{resp:F2} ({classificacao})";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gpbgrupo_Enter(object sender, EventArgs e)
        {

        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
