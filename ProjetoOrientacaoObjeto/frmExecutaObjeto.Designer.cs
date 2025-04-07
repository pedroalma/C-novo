namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaObjeto
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
            btnSomar = new Button();
            lblResposta = new Label();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(12, 12);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(184, 62);
            btnSomar.TabIndex = 0;
            btnSomar.Text = "somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += button1_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResposta.Location = new Point(24, 145);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(73, 21);
            lblResposta.TabIndex = 1;
            lblResposta.Text = "Resposta";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(202, 12);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(184, 62);
            btnSubtrair.TabIndex = 2;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(12, 80);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(184, 62);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(202, 80);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(184, 62);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // frmExecutaObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 373);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(lblResposta);
            Controls.Add(btnSomar);
            Name = "frmExecutaObjeto";
            Text = "frmExecutaObjeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private Label lblResposta;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}