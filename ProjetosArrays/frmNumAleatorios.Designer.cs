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
            btnSair = new Button();
            btnLimpar = new Button();
            lblMostranumero = new ListBox();
            label1 = new Label();
            txtINsiraNumero = new TextBox();
            btnGerar = new Button();
            gpbValores.SuspendLayout();
            SuspendLayout();
            // 
            // gpbValores
            // 
            gpbValores.Controls.Add(btnSair);
            gpbValores.Controls.Add(btnLimpar);
            gpbValores.Controls.Add(lblMostranumero);
            gpbValores.Controls.Add(label1);
            gpbValores.Controls.Add(txtINsiraNumero);
            gpbValores.Controls.Add(btnGerar);
            gpbValores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbValores.Location = new Point(12, 12);
            gpbValores.Name = "gpbValores";
            gpbValores.Size = new Size(683, 426);
            gpbValores.TabIndex = 0;
            gpbValores.TabStop = false;
            gpbValores.Text = "Valores";
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
            lblMostranumero.Location = new Point(380, 28);
            lblMostranumero.Name = "lblMostranumero";
            lblMostranumero.Size = new Size(261, 130);
            lblMostranumero.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 2;
            label1.Text = "Insira o numero";
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
            ClientSize = new Size(707, 450);
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
        private Label label1;
        private TextBox txtINsiraNumero;
        private ListBox lblMostranumero;
        private Button btnSair;
        private Button btnLimpar;
    }
}