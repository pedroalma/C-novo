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
            ca.setValor(Convert.ToDouble(mtbValor.Text));
            ca.setQuatidade(Convert.ToDouble(txtQuantidade.Text));
            //ps.setIdade(Convert.ToInt32(txtIdade.Text));

            txtDescricaoCadastro.Text = ca.getDescricao();
            txtCodigoCadastro.Text = ca.getCodigo();
            mtbValorCadastro.Text = ca.getValor().ToString();
            txtQuantidadeCadastro.Text = ca.getQuantidade().ToString();
            //txtMostraIdade.Text = ps.getIdade().ToString();

            txtTotalCadastro.Text = ca.getTotal().ToString();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void txtTotalCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbValorCadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
