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
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
        }

        private void lblListaDesejos_Click(object sender, EventArgs e)
        {

        }

        private void frmEstruturaRepeticao_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão");
            cbbEstado.Items.Add("Sao Luiz");
            cbbEstado.Items.Add("Campo grande");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("largo treze");
            cbbEstado.Items.Add("jardim Nakamura");
        }

        private void ltbListaDesejos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ltbListaDesejos.Items.Add("Santo Amaro");
        }

        private void btnCarregaListaDesejos_Click(object sender, EventArgs e)
        {
            ltbListaDesejos.Items.Add(txtInserirEstado.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbEstado.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();

        }

        private void txtInserirEstado_TextChanged(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                inserirEstado();
            }
        }
    }
}
