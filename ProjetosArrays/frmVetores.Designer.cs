namespace ProjetosArrays
{
    partial class frmVetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetores));
            groupBox1 = new GroupBox();
            txtnomes = new TextBox();
            lblNomes = new Label();
            txtTamanho = new TextBox();
            lblTamanho = new Label();
            LtbNomes = new ListBox();
            lblLista = new Label();
            btnCarrega = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtnomes);
            groupBox1.Controls.Add(lblNomes);
            groupBox1.Controls.Add(txtTamanho);
            groupBox1.Controls.Add(lblTamanho);
            groupBox1.Controls.Add(LtbNomes);
            groupBox1.Controls.Add(lblLista);
            groupBox1.Controls.Add(btnCarrega);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDark;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nomes";
            // 
            // txtnomes
            // 
            txtnomes.Location = new Point(25, 146);
            txtnomes.Name = "txtnomes";
            txtnomes.Size = new Size(100, 29);
            txtnomes.TabIndex = 7;
            // 
            // lblNomes
            // 
            lblNomes.AutoSize = true;
            lblNomes.ForeColor = SystemColors.ActiveCaptionText;
            lblNomes.Location = new Point(40, 122);
            lblNomes.Name = "lblNomes";
            lblNomes.Size = new Size(60, 21);
            lblNomes.TabIndex = 6;
            lblNomes.Text = "Nomes";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(25, 59);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(100, 29);
            txtTamanho.TabIndex = 5;
            txtTamanho.TextChanged += txtTamanho_TextChanged;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.ForeColor = SystemColors.ActiveCaptionText;
            lblTamanho.Location = new Point(40, 35);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(73, 21);
            lblTamanho.TabIndex = 4;
            lblTamanho.Text = "Tamanho";
            // 
            // LtbNomes
            // 
            LtbNomes.FormattingEnabled = true;
            LtbNomes.ItemHeight = 21;
            LtbNomes.Location = new Point(221, 45);
            LtbNomes.Name = "LtbNomes";
            LtbNomes.Size = new Size(206, 193);
            LtbNomes.TabIndex = 3;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.ForeColor = SystemColors.ActiveCaptionText;
            lblLista.Location = new Point(221, 21);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(107, 21);
            lblLista.TabIndex = 2;
            lblLista.Text = "Lista de nome";
            // 
            // btnCarrega
            // 
            btnCarrega.ForeColor = SystemColors.ActiveCaptionText;
            btnCarrega.Location = new Point(6, 241);
            btnCarrega.Name = "btnCarrega";
            btnCarrega.Size = new Size(154, 44);
            btnCarrega.TabIndex = 0;
            btnCarrega.Text = "Carrega";
            btnCarrega.UseVisualStyleBackColor = true;
            btnCarrega.Click += btnCarrega_Click;
            // 
            // frmVetores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 324);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVetores";
            Text = "frmVetores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCarrega;
        private Label lblLista;
        private ListBox LtbNomes;
        private Label lblTamanho;
        private TextBox txtTamanho;
        private TextBox txtnomes;
        private Label lblNomes;
    }
}