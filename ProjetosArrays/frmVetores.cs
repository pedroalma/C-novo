﻿using System;
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
        int i = 0;
        int a = 0;
        int tam = 0;
        string[] nomes = new string[5];
       
        private void btnCarrega_Click(object sender, EventArgs e)
        {
            //double num1;
            //string str1;

            //num1= Convert.ToDouble(txtTamanho.Text);
            //str1= Convert.ToString()

            //string[] nome = new string[10];

            //nome[0] = "Larissa";
            //nome[1] = "Dharla";
            //nome[2] = "cauã";
            //nome[3] = "Eduardo";
            //nome[4] = "leticia";
            //nome[5] = "edna";
            //nome[6] = "hugo";
            //nome[7] = "pedro";
            //nome[8] = "hugo";
            //nome[9] = "giovane";

            //LtbNomes.Items.Clear();
            ////LtbNomes.Items.Add(nome[0]);
            //for (int i = 0; i < 10; i++)
            //{
            //    LtbNomes.Items.Add(nome[i]);
            //}

            //string[] arrayDePalavras = new string[5];

            //for (int i = 0; i < arrayDePalavras.Length; i++)
            //{
            //    LtbNomes.Items.Add($"Digite { i}");

            //}
            //string[] nome = new string[10];
            //for (int i = 0; i < 10; i++) {
            //    nome[i] = txtnomes.Text;
            //}
            nomes[a] = txtnomes.Text;
            tam = int.Parse(txtTamanho.Text);
            txtnomes.Clear();
            txtnomes.Focus();
            if (a == tam)
            {                   
                for (int i = 0; i < nomes.Length; i++)
                {
                    LtbNomes.Items.Add(nomes[i]);
                }
            }
            a++;
        }

        private void txtTamanho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
