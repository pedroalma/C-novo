using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCamposDesabilitar();
        }
        public void limparCamposDesabilitar()
        {

            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtResposta.Clear();

            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDivisao.Checked = false;

            txtNumero1.Focus();
        }
        private void  btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
      
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            //tipos de variaveis eo nome da variavel
            //int valor1, valor4, resp;
            //double valor2, vslor5; 
            //float valor3;
            //bool flag;
            //string nome;


            //inicializar as variaveis
            //valor1 = 10;
            //valor4 = 30;

            //resp = valor1 + valor4;

            //declarando as variaveis
            double num1, num2, resp=0;


            try
            {

                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                //if(num2 === 0)
                //{

                //}

                //resp = num1 + num2;
                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicar.Checked == false && rdbDivisao.Checked == false)
                {
                    MessageBox.Show("Selecione ema operacão",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    

                }
                else
                {
                    Operacoes operacoes = new Operacoes();

                    if (rdbSomar.Checked)
                    {
                        resp = operacoes.SomaValor(num1,num2);
                    }

                    if (num2 == 0 & rdbDivisao.Checked)
                    {
                        MessageBox.Show("Impossivel dividir por Zero", "mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        resp = 0;
                    }
                    else if (rdbSomar.Checked)
                    {
                        resp = num1 + num2;
                    }
                    else if (rdbSubtrair.Checked)
                    {
                        resp = num1 - num2;
                    }
                    else if (rdbMultiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    else if (rdbDivisao.Checked)
                    {
                        resp = (num1 / num2);
                    }

                    txtResposta.Text = resp.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir somente numeros", "mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //txtNumero1.Clear();
                //txtNumero2.Clear();
                //txtNumero1.Focus();
                limparcampos();
            }

        }
        public void limparcampos()
        { 
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }
        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}