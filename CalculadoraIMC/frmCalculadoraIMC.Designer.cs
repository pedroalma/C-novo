namespace FolhadePagamento
{
    partial class frmCalculadoraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraIMC));
            gpbgrupo = new GroupBox();
            button1 = new Button();
            txtimc = new TextBox();
            lblimc = new Label();
            btnLimpar = new Button();
            btncalcular = new Button();
            txtpeso = new TextBox();
            lblpeso = new Label();
            txtidade = new TextBox();
            lblidade = new Label();
            lblimc1 = new Label();
            gpbgrupo.SuspendLayout();
            SuspendLayout();
            // 
            // gpbgrupo
            // 
            gpbgrupo.Controls.Add(button1);
            gpbgrupo.Controls.Add(txtimc);
            gpbgrupo.Controls.Add(lblimc);
            gpbgrupo.Controls.Add(btnLimpar);
            gpbgrupo.Controls.Add(btncalcular);
            gpbgrupo.Controls.Add(txtpeso);
            gpbgrupo.Controls.Add(lblpeso);
            gpbgrupo.Controls.Add(txtidade);
            gpbgrupo.Controls.Add(lblidade);
            gpbgrupo.Controls.Add(lblimc1);
            gpbgrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbgrupo.Location = new Point(12, 12);
            gpbgrupo.Name = "gpbgrupo";
            gpbgrupo.Size = new Size(656, 333);
            gpbgrupo.TabIndex = 0;
            gpbgrupo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(365, 294);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 9;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtimc
            // 
            txtimc.Enabled = false;
            txtimc.Location = new Point(173, 236);
            txtimc.Name = "txtimc";
            txtimc.Size = new Size(263, 33);
            txtimc.TabIndex = 8;
            // 
            // lblimc
            // 
            lblimc.AutoSize = true;
            lblimc.Location = new Point(286, 208);
            lblimc.Name = "lblimc";
            lblimc.Size = new Size(46, 25);
            lblimc.TabIndex = 7;
            lblimc.Text = "IMC";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(462, 294);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(91, 33);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button2_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(559, 294);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(91, 33);
            btncalcular.TabIndex = 5;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(263, 164);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(100, 33);
            txtpeso.TabIndex = 4;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Location = new Point(286, 136);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(52, 25);
            lblpeso.TabIndex = 3;
            lblpeso.Text = "peso";
            lblpeso.Click += label1_Click;
            // 
            // txtidade
            // 
            txtidade.Location = new Point(263, 97);
            txtidade.Name = "txtidade";
            txtidade.Size = new Size(100, 33);
            txtidade.TabIndex = 2;
            txtidade.TextChanged += txtidade_TextChanged;
            // 
            // lblidade
            // 
            lblidade.AutoSize = true;
            lblidade.Location = new Point(281, 69);
            lblidade.Name = "lblidade";
            lblidade.Size = new Size(61, 25);
            lblidade.TabIndex = 1;
            lblidade.Text = "altura";
            lblidade.Click += lblidade_Click;
            // 
            // lblimc1
            // 
            lblimc1.AutoSize = true;
            lblimc1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblimc1.Location = new Point(281, 25);
            lblimc1.Name = "lblimc1";
            lblimc1.Size = new Size(57, 32);
            lblimc1.TabIndex = 0;
            lblimc1.Text = "IMC";
            // 
            // frmCalculadoraIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 357);
            Controls.Add(gpbgrupo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCalculadoraIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculadoraIMC";
            gpbgrupo.ResumeLayout(false);
            gpbgrupo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbgrupo;
        private Label lblimc1;
        private Label lblidade;
        private TextBox maskedTextBox1;
        private TextBox txtpeso;
        private Label lblpeso;
        private Button btnLimpar;
        private Button btncalcular;
        private TextBox txtimc;
        private Label lblimc;
        private TextBox txtidade;
        private Button button1;
    }
}