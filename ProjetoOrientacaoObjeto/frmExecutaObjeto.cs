using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmExecutaObjeto : Form
    {
        public frmExecutaObjeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calculadora = new Calculadora();

            resp = calculadora.somar(num1, num2);

            lblResposta.Text = resp.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calculadora = new Calculadora();

            resp = calculadora.subtrair(num1, num2);

            lblResposta.Text = resp.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calculadora = new Calculadora();

            resp = calculadora.multiplicar(num1, num2);

            lblResposta.Text = resp.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = 40.50, num2 = 20.50, resp = 0;

            Calculadora calculadora = new Calculadora();

            resp = calculadora.dividir(num1, num2);

            lblResposta.Text = resp.ToString();
        }
    }
}
