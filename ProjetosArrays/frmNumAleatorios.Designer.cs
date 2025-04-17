namespace ProjetosArrays
{
    partial class frmNumAleatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbValores = new GroupBox();
            rdbgerarfloatsaleatoris = new RadioButton();
            lblSelecionar = new Label();
            rdbinteirosaletorisinteiros = new RadioButton();
            rdbVariosInteirosAleatorios = new RadioButton();
            rdbInteirosAleatorios = new RadioButton();
            lblnumeromaximo = new Label();
            txtnumeromaximo = new TextBox();
            lblnumerominimo = new Label();
            txtnumerominimo = new TextBox();
            btnSair = new Button();
            btnLimpar = new Button();
            lblMostranumero = new ListBox();
            lblinsiraonumero = new Label();
            txtINsiraNumero = new TextBox();
            btnGerar = new Button();
            gpbValores.SuspendLayout();
            SuspendLayout();
            // 
            // gpbValores
            // 
            gpbValores.Controls.Add(rdbgerarfloatsaleatoris);
            gpbValores.Controls.Add(lblSelecionar);
            gpbValores.Controls.Add(rdbinteirosaletorisinteiros);
            gpbValores.Controls.Add(rdbVariosInteirosAleatorios);
            gpbValores.Controls.Add(rdbInteirosAleatorios);
            gpbValores.Controls.Add(lblnumeromaximo);
            gpbValores.Controls.Add(txtnumeromaximo);
            gpbValores.Controls.Add(lblnumerominimo);
            gpbValores.Controls.Add(txtnumerominimo);
            gpbValores.Controls.Add(btnSair);
            gpbValores.Controls.Add(btnLimpar);
            gpbValores.Controls.Add(lblMostranumero);
            gpbValores.Controls.Add(lblinsiraonumero);
            gpbValores.Controls.Add(txtINsiraNumero);
            gpbValores.Controls.Add(btnGerar);
            gpbValores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbValores.Location = new Point(12, 12);
            gpbValores.Name = "gpbValores";
            gpbValores.Size = new Size(907, 426);
            gpbValores.TabIndex = 0;
            gpbValores.TabStop = false;
            gpbValores.Text = "Valores";
            gpbValores.Enter += gpbValores_Enter;
            // 
            // rdbgerarfloatsaleatoris
            // 
            rdbgerarfloatsaleatoris.AutoSize = true;
            rdbgerarfloatsaleatoris.Location = new Point(312, 177);
            rdbgerarfloatsaleatoris.Name = "rdbgerarfloatsaleatoris";
            rdbgerarfloatsaleatoris.Size = new Size(186, 25);
            rdbgerarfloatsaleatoris.TabIndex = 16;
            rdbgerarfloatsaleatoris.TabStop = true;
            rdbgerarfloatsaleatoris.Text = "Gerar Floats Aleatorios";
            rdbgerarfloatsaleatoris.UseVisualStyleBackColor = true;
            rdbgerarfloatsaleatoris.CheckedChanged += rdbgerarfloatsaleatoris_CheckedChanged;
            // 
            // lblSelecionar
            // 
            lblSelecionar.AutoSize = true;
            lblSelecionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelecionar.Location = new Point(312, 57);
            lblSelecionar.Name = "lblSelecionar";
            lblSelecionar.Size = new Size(104, 25);
            lblSelecionar.TabIndex = 15;
            lblSelecionar.Text = "Selecionar:";
            // 
            // rdbinteirosaletorisinteiros
            // 
            rdbinteirosaletorisinteiros.AutoSize = true;
            rdbinteirosaletorisinteiros.Location = new Point(312, 146);
            rdbinteirosaletorisinteiros.Name = "rdbinteirosaletorisinteiros";
            rdbinteirosaletorisinteiros.Size = new Size(224, 25);
            rdbinteirosaletorisinteiros.TabIndex = 12;
            rdbinteirosaletorisinteiros.TabStop = true;
            rdbinteirosaletorisinteiros.Text = "Inteiros aleatorios intervalos";
            rdbinteirosaletorisinteiros.UseVisualStyleBackColor = true;
            rdbinteirosaletorisinteiros.CheckedChanged += rdbinteirosaletorisinteiros_CheckedChanged;
            // 
            // rdbVariosInteirosAleatorios
            // 
            rdbVariosInteirosAleatorios.AutoSize = true;
            rdbVariosInteirosAleatorios.Location = new Point(312, 115);
            rdbVariosInteirosAleatorios.Name = "rdbVariosInteirosAleatorios";
            rdbVariosInteirosAleatorios.Size = new Size(199, 25);
            rdbVariosInteirosAleatorios.TabIndex = 11;
            rdbVariosInteirosAleatorios.TabStop = true;
            rdbVariosInteirosAleatorios.Text = "Varios inteiros aleatorios";
            rdbVariosInteirosAleatorios.UseVisualStyleBackColor = true;
            rdbVariosInteirosAleatorios.CheckedChanged += rdbVariosInteirosAleatorios_CheckedChanged;
            // 
            // rdbInteirosAleatorios
            // 
            rdbInteirosAleatorios.AutoSize = true;
            rdbInteirosAleatorios.Location = new Point(312, 84);
            rdbInteirosAleatorios.Name = "rdbInteirosAleatorios";
            rdbInteirosAleatorios.Size = new Size(152, 25);
            rdbInteirosAleatorios.TabIndex = 10;
            rdbInteirosAleatorios.TabStop = true;
            rdbInteirosAleatorios.Text = "Inteiros aleatorios";
            rdbInteirosAleatorios.UseVisualStyleBackColor = true;
            // 
            // lblnumeromaximo
            // 
            lblnumeromaximo.AutoSize = true;
            lblnumeromaximo.Location = new Point(20, 161);
            lblnumeromaximo.Name = "lblnumeromaximo";
            lblnumeromaximo.Size = new Size(125, 21);
            lblnumeromaximo.TabIndex = 9;
            lblnumeromaximo.Text = "numero maximo";
            // 
            // txtnumeromaximo
            // 
            txtnumeromaximo.Location = new Point(20, 185);
            txtnumeromaximo.Name = "txtnumeromaximo";
            txtnumeromaximo.Size = new Size(240, 29);
            txtnumeromaximo.TabIndex = 8;
            // 
            // lblnumerominimo
            // 
            lblnumerominimo.AutoSize = true;
            lblnumerominimo.Location = new Point(20, 99);
            lblnumerominimo.Name = "lblnumerominimo";
            lblnumerominimo.Size = new Size(123, 21);
            lblnumerominimo.TabIndex = 7;
            lblnumerominimo.Text = "numero minimo";
            // 
            // txtnumerominimo
            // 
            txtnumerominimo.Location = new Point(20, 123);
            txtnumerominimo.Name = "txtnumerominimo";
            txtnumerominimo.Size = new Size(240, 29);
            txtnumerominimo.TabIndex = 6;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(279, 345);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(126, 75);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(147, 345);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(126, 75);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblMostranumero
            // 
            lblMostranumero.FormattingEnabled = true;
            lblMostranumero.ItemHeight = 21;
            lblMostranumero.Location = new Point(562, 28);
            lblMostranumero.Name = "lblMostranumero";
            lblMostranumero.Size = new Size(339, 214);
            lblMostranumero.TabIndex = 3;
            // 
            // lblinsiraonumero
            // 
            lblinsiraonumero.AutoSize = true;
            lblinsiraonumero.Location = new Point(20, 37);
            lblinsiraonumero.Name = "lblinsiraonumero";
            lblinsiraonumero.Size = new Size(120, 21);
            lblinsiraonumero.TabIndex = 2;
            lblinsiraonumero.Text = "Insira o numero";
            // 
            // txtINsiraNumero
            // 
            txtINsiraNumero.Location = new Point(20, 61);
            txtINsiraNumero.Name = "txtINsiraNumero";
            txtINsiraNumero.Size = new Size(240, 29);
            txtINsiraNumero.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerar.Location = new Point(6, 345);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(126, 75);
            btnGerar.TabIndex = 0;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // frmNumAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(gpbValores);
            Name = "frmNumAleatorios";
            Text = "Aleatorio";
            gpbValores.ResumeLayout(false);
            gpbValores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbValores;
        private Button btnGerar;
        private Label lblinsiraonumero;
        private TextBox txtINsiraNumero;
        private ListBox lblMostranumero;
        private Button btnSair;
        private Button btnLimpar;
        private Label lblnumerominimo;
        private TextBox txtnumerominimo;
        private RadioButton rdbinteirosaletorisinteiros;
        private RadioButton rdbVariosInteirosAleatorios;
        private RadioButton rdbInteirosAleatorios;
        private Label lblnumeromaximo;
        private TextBox txtnumeromaximo;
        private Label lblSelecionar;
        private RadioButton rdbgerarfloatsaleatoris;
    }
}