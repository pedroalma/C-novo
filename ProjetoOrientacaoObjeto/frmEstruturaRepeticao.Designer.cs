namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            lblEstado = new Label();
            cbbEstado = new ComboBox();
            lblListaDesejos = new Label();
            ltbListaDesejos = new ListBox();
            btnCarregaEstado = new Button();
            btnCarregaListaDesejos = new Button();
            btnInserirEstado = new Button();
            label1 = new Label();
            txtInserirEstado = new TextBox();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(57, 42);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 21);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado";
            // 
            // cbbEstado
            // 
            cbbEstado.FormattingEnabled = true;
            cbbEstado.Location = new Point(57, 66);
            cbbEstado.Name = "cbbEstado";
            cbbEstado.Size = new Size(121, 23);
            cbbEstado.TabIndex = 1;
            // 
            // lblListaDesejos
            // 
            lblListaDesejos.AutoSize = true;
            lblListaDesejos.Font = new Font("Segoe UI", 12F);
            lblListaDesejos.Location = new Point(221, 64);
            lblListaDesejos.Name = "lblListaDesejos";
            lblListaDesejos.Size = new Size(123, 21);
            lblListaDesejos.TabIndex = 2;
            lblListaDesejos.Text = "Lista De Desejos";
            lblListaDesejos.Click += lblListaDesejos_Click;
            // 
            // ltbListaDesejos
            // 
            ltbListaDesejos.Font = new Font("Segoe UI", 12F);
            ltbListaDesejos.FormattingEnabled = true;
            ltbListaDesejos.ItemHeight = 21;
            ltbListaDesejos.Location = new Point(221, 88);
            ltbListaDesejos.Name = "ltbListaDesejos";
            ltbListaDesejos.Size = new Size(120, 88);
            ltbListaDesejos.TabIndex = 3;
            ltbListaDesejos.SelectedIndexChanged += ltbListaDesejos_SelectedIndexChanged;
            // 
            // btnCarregaEstado
            // 
            btnCarregaEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCarregaEstado.Location = new Point(55, 265);
            btnCarregaEstado.Name = "btnCarregaEstado";
            btnCarregaEstado.Size = new Size(123, 31);
            btnCarregaEstado.TabIndex = 4;
            btnCarregaEstado.Text = "Carrega Estado";
            btnCarregaEstado.UseVisualStyleBackColor = true;
            btnCarregaEstado.Click += btnCarregaEstado_Click;
            // 
            // btnCarregaListaDesejos
            // 
            btnCarregaListaDesejos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCarregaListaDesejos.Location = new Point(271, 265);
            btnCarregaListaDesejos.Name = "btnCarregaListaDesejos";
            btnCarregaListaDesejos.Size = new Size(192, 31);
            btnCarregaListaDesejos.TabIndex = 5;
            btnCarregaListaDesejos.Text = "Carrega Lista Estado";
            btnCarregaListaDesejos.UseVisualStyleBackColor = true;
            btnCarregaListaDesejos.Click += btnCarregaListaDesejos_Click;
            // 
            // btnInserirEstado
            // 
            btnInserirEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserirEstado.Location = new Point(55, 195);
            btnInserirEstado.Name = "btnInserirEstado";
            btnInserirEstado.Size = new Size(123, 31);
            btnInserirEstado.TabIndex = 6;
            btnInserirEstado.Text = "Inserir Estato";
            btnInserirEstado.UseVisualStyleBackColor = true;
            btnInserirEstado.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 141);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Digite Estado";
            // 
            // txtInserirEstado
            // 
            txtInserirEstado.Location = new Point(57, 159);
            txtInserirEstado.Name = "txtInserirEstado";
            txtInserirEstado.Size = new Size(100, 23);
            txtInserirEstado.TabIndex = 8;
            txtInserirEstado.TextChanged += txtInserirEstado_TextChanged;
            // 
            // frmEstruturaRepeticao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 329);
            Controls.Add(txtInserirEstado);
            Controls.Add(label1);
            Controls.Add(btnInserirEstado);
            Controls.Add(btnCarregaListaDesejos);
            Controls.Add(btnCarregaEstado);
            Controls.Add(ltbListaDesejos);
            Controls.Add(lblListaDesejos);
            Controls.Add(cbbEstado);
            Controls.Add(lblEstado);
            Name = "frmEstruturaRepeticao";
            Text = "frmEstruturaRepeticao";
            Load += frmEstruturaRepeticao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private ComboBox cbbEstado;
        private Label lblListaDesejos;
        private ListBox ltbListaDesejos;
        private Button btnCarregaEstado;
        private Button btnCarregaListaDesejos;
        private Button btnInserirEstado;
        private Label label1;
        private TextBox txtInserirEstado;
    }
}