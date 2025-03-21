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
            //declarando variaveis
            //tipos de variaveis eo nome da variavel
            int valor1, valor4, resp;
            double valor2, vslor5; 
            float valor3;
            bool flag;
            string nome;


            //inicializar as variaveis
            valor1 = 10;
            valor4 = 30;

            resp = valor1 + valor4;
        }                             
    }
}
