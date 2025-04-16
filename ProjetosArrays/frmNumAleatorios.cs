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
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtINsiraNumero.Text);
                int num = rnd.Next(valor);
                lblMostranumero.Items.Add(num);
            }
            catch(Exception)
            {
                MessageBox.Show("Favor inserir um numero interiro");
                txtINsiraNumero.Clear();
                txtINsiraNumero.Focus();    
            }
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMostranumero.Items.Clear();
            txtINsiraNumero.Clear();
            txtINsiraNumero.Focus();
        }
    }
}
