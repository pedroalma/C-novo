namespace FolhadePagamento
{
    partial class frmFolhadePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhadePagamento));
            gpbfolha = new GroupBox();
            btnSair = new Button();
            btnLimpar = new Button();
            txtliquido = new TextBox();
            lblsalarioliquido = new Label();
            txtrenda = new TextBox();
            lblimposto = new Label();
            txtfolha = new TextBox();
            lblSalariofolha = new Label();
            btnCalcular = new Button();
            ccbClube = new ComboBox();
            lblClube = new Label();
            ccbPlano = new CheckBox();
            txtSalario = new TextBox();
            lblSalario = new Label();
            dtpData = new DateTimePicker();
            lbldata = new Label();
            gpbfolha.SuspendLayout();
            SuspendLayout();
            // 
            // gpbfolha
            // 
            gpbfolha.Controls.Add(btnSair);
            gpbfolha.Controls.Add(btnLimpar);
            gpbfolha.Controls.Add(txtliquido);
            gpbfolha.Controls.Add(lblsalarioliquido);
            gpbfolha.Controls.Add(txtrenda);
            gpbfolha.Controls.Add(lblimposto);
            gpbfolha.Controls.Add(txtfolha);
            gpbfolha.Controls.Add(lblSalariofolha);
            gpbfolha.Controls.Add(btnCalcular);
            gpbfolha.Controls.Add(ccbClube);
            gpbfolha.Controls.Add(lblClube);
            gpbfolha.Controls.Add(ccbPlano);
            gpbfolha.Controls.Add(txtSalario);
            gpbfolha.Controls.Add(lblSalario);
            gpbfolha.Controls.Add(dtpData);
            gpbfolha.Controls.Add(lbldata);
            gpbfolha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbfolha.Location = new Point(12, 12);
            gpbfolha.Name = "gpbfolha";
            gpbfolha.Size = new Size(760, 337);
            gpbfolha.TabIndex = 0;
            gpbfolha.TabStop = false;
            gpbfolha.Enter += gpbfolha_Enter;
            // 
            // btnSair
            // 
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(666, 273);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 58);
            btnSair.TabIndex = 15;
            btnSair.Text = "&Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(666, 209);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(88, 58);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "&Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtliquido
            // 
            txtliquido.Enabled = false;
            txtliquido.Location = new Point(475, 204);
            txtliquido.Name = "txtliquido";
            txtliquido.Size = new Size(123, 29);
            txtliquido.TabIndex = 13;
            // 
            // lblsalarioliquido
            // 
            lblsalarioliquido.AutoSize = true;
            lblsalarioliquido.Location = new Point(345, 212);
            lblsalarioliquido.Name = "lblsalarioliquido";
            lblsalarioliquido.Size = new Size(114, 21);
            lblsalarioliquido.TabIndex = 12;
            lblsalarioliquido.Text = "Salário Liquido";
            // 
            // txtrenda
            // 
            txtrenda.Enabled = false;
            txtrenda.Location = new Point(489, 159);
            txtrenda.Name = "txtrenda";
            txtrenda.Size = new Size(123, 29);
            txtrenda.TabIndex = 11;
            txtrenda.TextChanged += textBox3_TextChanged;
            // 
            // lblimposto
            // 
            lblimposto.AutoSize = true;
            lblimposto.Location = new Point(347, 167);
            lblimposto.Name = "lblimposto";
            lblimposto.Size = new Size(136, 21);
            lblimposto.TabIndex = 10;
            lblimposto.Text = "Imposto de Renda";
            // 
            // txtfolha
            // 
            txtfolha.Enabled = false;
            txtfolha.Location = new Point(453, 112);
            txtfolha.Name = "txtfolha";
            txtfolha.Size = new Size(123, 29);
            txtfolha.TabIndex = 9;
            // 
            // lblSalariofolha
            // 
            lblSalariofolha.AutoSize = true;
            lblSalariofolha.Location = new Point(347, 120);
            lblSalariofolha.Name = "lblSalariofolha";
            lblSalariofolha.Size = new Size(100, 21);
            lblSalariofolha.TabIndex = 8;
            lblSalariofolha.Text = "Salário Folha";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.Menu;
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(347, 67);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // ccbClube
            // 
            ccbClube.FormattingEnabled = true;
            ccbClube.Items.AddRange(new object[] { "sem Clube", "Clube A", "Clube B", "Clube c" });
            ccbClube.Location = new Point(46, 259);
            ccbClube.Name = "ccbClube";
            ccbClube.Size = new Size(121, 29);
            ccbClube.TabIndex = 6;
            // 
            // lblClube
            // 
            lblClube.AutoSize = true;
            lblClube.Location = new Point(44, 235);
            lblClube.Name = "lblClube";
            lblClube.Size = new Size(112, 21);
            lblClube.TabIndex = 5;
            lblClube.Text = "Clube de Lazer";
            // 
            // ccbPlano
            // 
            ccbPlano.AutoSize = true;
            ccbPlano.Location = new Point(44, 191);
            ccbPlano.Name = "ccbPlano";
            ccbPlano.Size = new Size(115, 25);
            ccbPlano.TabIndex = 4;
            ccbPlano.Text = "Plano Saude";
            ccbPlano.UseVisualStyleBackColor = true;
            ccbPlano.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(44, 144);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(123, 29);
            txtSalario.TabIndex = 3;
            txtSalario.TextChanged += txtSalario_TextChanged;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(44, 120);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(58, 21);
            lblSalario.TabIndex = 2;
            lblSalario.Text = "Salário";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(44, 67);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(123, 29);
            dtpData.TabIndex = 1;
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.Location = new Point(44, 43);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(105, 21);
            lbldata.TabIndex = 0;
            lbldata.Text = "Data da Folha";
            // 
            // frmFolhadePagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(gpbfolha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmFolhadePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FolhadePagamento";
            gpbfolha.ResumeLayout(false);
            gpbfolha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbfolha;
        private Label lbldata;
        private Label lblSalario;
        private DateTimePicker dtpData;
        private CheckBox ccbPlano;
        private Label lblClube;
        private ComboBox ccbClube;
        private Button btnCalcular;
        private Label lblSalariofolha;
        private TextBox txtrenda;
        private Label lblimposto;
        private TextBox txtfolha;
        private TextBox txtliquido;
        private Label lblsalarioliquido;
        private Button btnSair;
        private Button btnLimpar;
        private TextBox txtSalario;
    }
}