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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar ca = new Cadastrar();

            ca.setCodigo(txtCodigo.Text);
            ca.setDescricao(txtDescricao.Text);
            //ca.setValor(Convert.ToInt32(mtbValor.Text));
            ca.setQuatidade(Convert.ToInt32(txtQuantidade.Text));
            //ps.setIdade(Convert.ToInt32(txtIdade.Text));
     
            txtDescricaoCadastro.Text = ca.getDescricao();
            txtCodigoCadastro.Text = ca.getCodigo();
            //mtbValor.Text=ca.getValor().ToString();
            txtQuantidadeCadastro.Text = ca.getQuantidade().ToString();
            //txtMostraIdade.Text = ps.getIdade().ToString();
        }
    }
}
