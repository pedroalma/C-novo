using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();
            ps.setNome(txtNome.Text);
            ps.setEmail(txtEmail.Text);
            ps.setCpf(mtbCpf.Text);
            ps.setTelefone(mtbTelefone.Text);
            ps.setIdade(Convert.ToInt32(txtIdade.Text));

            txtMostraEmail.Text = ps.getEmail();
            txtMostraNome.Text = ps.getNome();
            txtMostraCpf.Text = ps.getCpf();
            txtMostraTelefone.Text = ps.getTelefone();
            txtMostraIdade.Text = ps.getIdade().ToString();
        }

        private void gbpDadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
