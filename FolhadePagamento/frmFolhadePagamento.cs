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
    public partial class frmFolhadePagamento : Form
    {
        public frmFolhadePagamento()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtSalario.Text = "";
            txtSalario.Focus();
            txtfolha.Clear();
            txtrenda.Clear();
            txtliquido.Clear();

            ccbPlano.Checked = false;
            ccbClube.TabIndex = 0;





            //double num7;

            //num7 = Convert.ToDouble(txtSalario.Text);
            //txtfolha.Text = num7.ToString();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //double num1,num2,num3,num4,num5, resp;


            //    //ccbClube.SelectedIndex = 0;
            //    //ccbClube.SelectedIndex = 1;
            //    //ccbClube.SelectedIndex = 2;
            //    num1 = Convert.ToDouble(txtSalario.Text);
            //    ccbPlano.Checked = false;
            //if (ccbClube.SelectedIndex == 0)
            //{
            //    num2 = 100;
            //}
            //if (ccbClube.SelectedIndex == 1)
            //{
            //    num2 = 50;
            //}
            //if (ccbClube.SelectedIndex == 2)
            //{
            //    num2 = 30;
            //}
            //if(ccbPlano.Checked == true)
            //{
            //    num3 = 400;
            //}
            //if (num1 > 0)
            //{
            //    resp = num1;
            //    txtfolha.Text = resp.ToString();
            //}
            double num1, num2 = 0, num3 = 0, num4 = 0, num5 = 0, resp;



            //ccbClube.SelectedIndex = 0;
            //ccbClube.SelectedIndex = 1;
            //ccbClube.SelectedIndex = 2;
            num1 = Convert.ToDouble(txtSalario.Text);



            if (ccbClube.SelectedIndex == 0)
            {
                num2 = 0;
            }
            if (ccbClube.SelectedIndex == 1)
            {
                num2 = 100;
            }
            if (ccbClube.SelectedIndex == 2)
            {
                num2 = 50;
            }
            if (ccbClube.SelectedIndex == 3)
            {
                num2 = 30;
            }
            if (ccbPlano.Checked || false)
            {
                num3 = 400;
            }
            if (num1 > 0)
            {
                //resp = num1 - num2 - num3;
                //txtfolha.Text = resp.ToString();
                if (num1 > 2259.21 && num1 < 2826.65)
                {
                    num4 = num1 * 7.5 / 100;
                    num5 = num1 - num4;
                }
                else if (num1 > 2826.66 && num1 < 3751.05)
                {
                    num4 = num1 * 15 / 100;
                    num5 = num1 - num4;
                }
                else if (num1 > 3751.06 && num1 < 4664.68)
                {
                    num4 = num1 * 22.5 / 100;
                    num5 = num1 - num4;
                }
                else if (num1 > 4664.68)
                {
                    num4 = num1 * 27.5 / 100;
                    num5 = num1 - num4;
                }
                else if (num1 > 400)
                {
                    num5 = num1;
                }
                resp = num5 - num3 - num2;
                txtrenda.Text = num4.ToString();
                txtliquido.Text = resp.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtfolha.Text = txtSalario.Text;
        }

        private void gpbfolha_Enter(object sender, EventArgs e)
        {

        }
    }
}
