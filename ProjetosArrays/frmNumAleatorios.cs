using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosArrays
{
    public partial class frmNumAleatorios : Form
    {
        public frmNumAleatorios()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int tamanho; 
        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rdbInteirosAleatorios.Checked)
            {
                {
                    int num = rnd.Next();
                    lblMostranumero.Items.Add(num);
                    txtINsiraNumero.Clear();
                    txtINsiraNumero.Focus();
                }
                if (rdbVariosInteirosAleatorios.Checked)
                {

                    try
                    {
                        int valor = int.Parse(txtINsiraNumero.Text);
                        int num = rnd.Next(valor);
                        lblMostranumero.Items.Add(num);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor inserir um numero interiro");
                        txtINsiraNumero.Clear();
                        txtINsiraNumero.Focus();
                    }
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMostranumero.Items.Clear();
            txtINsiraNumero.Clear();
            txtINsiraNumero.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpbValores_Enter(object sender, EventArgs e)
        {

        }

        private void rdbinteirosaletorisinteiros_CheckedChanged(object sender, EventArgs e)
        {
            txtnumeromaximo.Enabled = true;
            txtnumerominimo.Enabled = true;
            txtnumerominimo.Focus();
        }

        private void rdbVariosInteirosAleatorios_CheckedChanged(object sender, EventArgs e)
        {
            txtINsiraNumero.Enabled = true;
            txtINsiraNumero.Focus();
        }

        private void rdbgerarfloatsaleatoris_CheckedChanged(object sender, EventArgs e)
        {
            txtnumeromaximo.Enabled = true;
            txtnumerominimo.Enabled = true;
            txtnumerominimo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
