namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaPessoa
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
            btnCadastrar = new Button();
            gbpDadosPessoais = new GroupBox();
            mtbCpf = new MaskedTextBox();
            mtbTelefone = new MaskedTextBox();
            txtIdade = new TextBox();
            lblIdade = new Label();
            lblTelefone = new Label();
            lblCpf = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            gpbMostraregistros = new GroupBox();
            txtMostraTelefone = new TextBox();
            lblMostraTelefone = new Label();
            txtMostraIdade = new TextBox();
            lblMostraIdade = new Label();
            txtMostraCpf = new TextBox();
            lblMostraCpf = new Label();
            txtMostraEmail = new TextBox();
            lblMostraEmail = new Label();
            txtMostraNome = new TextBox();
            lblMostraNome = new Label();
            gbpDadosPessoais.SuspendLayout();
            gpbMostraregistros.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(12, 12);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 57);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // gbpDadosPessoais
            // 
            gbpDadosPessoais.Controls.Add(mtbCpf);
            gbpDadosPessoais.Controls.Add(mtbTelefone);
            gbpDadosPessoais.Controls.Add(txtIdade);
            gbpDadosPessoais.Controls.Add(lblIdade);
            gbpDadosPessoais.Controls.Add(lblTelefone);
            gbpDadosPessoais.Controls.Add(lblCpf);
            gbpDadosPessoais.Controls.Add(txtEmail);
            gbpDadosPessoais.Controls.Add(lblEmail);
            gbpDadosPessoais.Controls.Add(txtNome);
            gbpDadosPessoais.Controls.Add(lblNome);
            gbpDadosPessoais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbpDadosPessoais.Location = new Point(155, 12);
            gbpDadosPessoais.Name = "gbpDadosPessoais";
            gbpDadosPessoais.Size = new Size(633, 176);
            gbpDadosPessoais.TabIndex = 1;
            gbpDadosPessoais.TabStop = false;
            gbpDadosPessoais.Text = "Dados Pessoais";
            gbpDadosPessoais.Enter += gbpDadosPessoais_Enter;
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(460, 34);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(122, 29);
            mtbCpf.TabIndex = 11;
            mtbCpf.ValidatingType = typeof(int);
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(86, 94);
            mtbTelefone.Mask = "(00)00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(116, 29);
            mtbTelefone.TabIndex = 10;
            mtbTelefone.ValidatingType = typeof(int);
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(284, 97);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 29);
            txtIdade.TabIndex = 9;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(225, 100);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(48, 21);
            lblIdade.TabIndex = 8;
            lblIdade.Text = "idade";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(14, 97);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 21);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "telefone";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(423, 37);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 21);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "cpf";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 29);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(208, 34);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "email";
            lblEmail.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 29);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(14, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // gpbMostraregistros
            // 
            gpbMostraregistros.Controls.Add(txtMostraTelefone);
            gpbMostraregistros.Controls.Add(lblMostraTelefone);
            gpbMostraregistros.Controls.Add(txtMostraIdade);
            gpbMostraregistros.Controls.Add(lblMostraIdade);
            gpbMostraregistros.Controls.Add(txtMostraCpf);
            gpbMostraregistros.Controls.Add(lblMostraCpf);
            gpbMostraregistros.Controls.Add(txtMostraEmail);
            gpbMostraregistros.Controls.Add(lblMostraEmail);
            gpbMostraregistros.Controls.Add(txtMostraNome);
            gpbMostraregistros.Controls.Add(lblMostraNome);
            gpbMostraregistros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbMostraregistros.Location = new Point(155, 194);
            gpbMostraregistros.Name = "gpbMostraregistros";
            gpbMostraregistros.Size = new Size(633, 176);
            gpbMostraregistros.TabIndex = 2;
            gpbMostraregistros.TabStop = false;
            gpbMostraregistros.Text = "Mostra registros";
            // 
            // txtMostraTelefone
            // 
            txtMostraTelefone.Location = new Point(86, 89);
            txtMostraTelefone.Name = "txtMostraTelefone";
            txtMostraTelefone.Size = new Size(116, 29);
            txtMostraTelefone.TabIndex = 11;
            // 
            // lblMostraTelefone
            // 
            lblMostraTelefone.AutoSize = true;
            lblMostraTelefone.Location = new Point(14, 92);
            lblMostraTelefone.Name = "lblMostraTelefone";
            lblMostraTelefone.Size = new Size(66, 21);
            lblMostraTelefone.TabIndex = 10;
            lblMostraTelefone.Text = "telefone";
            // 
            // txtMostraIdade
            // 
            txtMostraIdade.Location = new Point(284, 92);
            txtMostraIdade.Name = "txtMostraIdade";
            txtMostraIdade.Size = new Size(100, 29);
            txtMostraIdade.TabIndex = 15;
            // 
            // lblMostraIdade
            // 
            lblMostraIdade.AutoSize = true;
            lblMostraIdade.Location = new Point(225, 95);
            lblMostraIdade.Name = "lblMostraIdade";
            lblMostraIdade.Size = new Size(48, 21);
            lblMostraIdade.TabIndex = 14;
            lblMostraIdade.Text = "idade";
            // 
            // txtMostraCpf
            // 
            txtMostraCpf.Location = new Point(460, 34);
            txtMostraCpf.Name = "txtMostraCpf";
            txtMostraCpf.Size = new Size(122, 29);
            txtMostraCpf.TabIndex = 13;
            // 
            // lblMostraCpf
            // 
            lblMostraCpf.AutoSize = true;
            lblMostraCpf.Location = new Point(423, 37);
            lblMostraCpf.Name = "lblMostraCpf";
            lblMostraCpf.Size = new Size(31, 21);
            lblMostraCpf.TabIndex = 12;
            lblMostraCpf.Text = "cpf";
            // 
            // txtMostraEmail
            // 
            txtMostraEmail.Location = new Point(267, 31);
            txtMostraEmail.Name = "txtMostraEmail";
            txtMostraEmail.Size = new Size(100, 29);
            txtMostraEmail.TabIndex = 11;
            // 
            // lblMostraEmail
            // 
            lblMostraEmail.AutoSize = true;
            lblMostraEmail.Location = new Point(208, 34);
            lblMostraEmail.Name = "lblMostraEmail";
            lblMostraEmail.Size = new Size(48, 21);
            lblMostraEmail.TabIndex = 10;
            lblMostraEmail.Text = "email";
            // 
            // txtMostraNome
            // 
            txtMostraNome.Location = new Point(73, 28);
            txtMostraNome.Name = "txtMostraNome";
            txtMostraNome.Size = new Size(100, 29);
            txtMostraNome.TabIndex = 1;
            // 
            // lblMostraNome
            // 
            lblMostraNome.AutoSize = true;
            lblMostraNome.Location = new Point(14, 31);
            lblMostraNome.Name = "lblMostraNome";
            lblMostraNome.Size = new Size(53, 21);
            lblMostraNome.TabIndex = 0;
            lblMostraNome.Text = "Nome";
            // 
            // frmExecutaPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpbMostraregistros);
            Controls.Add(gbpDadosPessoais);
            Controls.Add(btnCadastrar);
            Name = "frmExecutaPessoa";
            Text = "frmExecutaPessoa";
            gbpDadosPessoais.ResumeLayout(false);
            gbpDadosPessoais.PerformLayout();
            gpbMostraregistros.ResumeLayout(false);
            gpbMostraregistros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private GroupBox gbpDadosPessoais;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpbMostraregistros;
        private TextBox txtMostraNome;
        private Label lblMostraNome;
        private Label lblCpf;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtIdade;
        private Label lblIdade;
        private TextBox txtMostraTelefone;
        private Label lblMostraTelefone;
        private TextBox txtMostraIdade;
        private Label lblMostraIdade;
        private TextBox txtMostraCpf;
        private Label lblMostraCpf;
        private TextBox txtMostraEmail;
        private Label lblMostraEmail;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbTelefone;
    }
}