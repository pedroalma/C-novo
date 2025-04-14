using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosArrays
{
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            string[] nome = new string[10];

            nome[0] = "Larissa";
            nome[1] = "Dharla";
            nome[2] = "cauã";
            nome[3] =  "Eduardo";
            nome[4] = "leticia";
            nome[5] = "edna";
            nome[6] = "hugo";
            nome[7] = "pedro";
            nome[8] = "hugo";
            nome[9] = "giovane";

            LtbNomes.Items.Clear();
            //LtbNomes.Items.Add(nome[0]);
           for(int i = 0; i < 10 ; i++)
            {
                LtbNomes.Items.Add(nome[i]);
            }
        }
    }
}
