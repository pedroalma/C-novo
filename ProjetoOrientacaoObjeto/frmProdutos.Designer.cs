namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
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
            gpbProdutos = new GroupBox();
            lblDataDeEntrada = new Label();
            dtpDataDeEntrada = new DateTimePicker();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            mtbValor = new MaskedTextBox();
            lblValor = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            gpbProdutosCadastrados = new GroupBox();
            lblDataDeSaida = new Label();
            mtbValorCadastro = new MaskedTextBox();
            dtmDataSaida = new DateTimePicker();
            lblCodigoCadastro = new Label();
            txtTotalCadastro = new TextBox();
            txtCodigoCadastro = new TextBox();
            lblTotalCadastro = new Label();
            lblDescricaoCadastro = new Label();
            txtQuantidadeCadastro = new TextBox();
            txtDescricaoCadastro = new TextBox();
            lblQuantidadeTotal = new Label();
            lblValorCadastro = new Label();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            gpbProdutos.SuspendLayout();
            gpbProdutosCadastrados.SuspendLayout();
            SuspendLayout();
            // 
            // gpbProdutos
            // 
            gpbProdutos.Controls.Add(lblDataDeEntrada);
            gpbProdutos.Controls.Add(dtpDataDeEntrada);
            gpbProdutos.Controls.Add(txtQuantidade);
            gpbProdutos.Controls.Add(lblQuantidade);
            gpbProdutos.Controls.Add(mtbValor);
            gpbProdutos.Controls.Add(lblValor);
            gpbProdutos.Controls.Add(txtDescricao);
            gpbProdutos.Controls.Add(lblDescricao);
            gpbProdutos.Controls.Add(txtCodigo);
            gpbProdutos.Controls.Add(lblCodigo);
            gpbProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbProdutos.Location = new Point(12, 12);
            gpbProdutos.Name = "gpbProdutos";
            gpbProdutos.Size = new Size(304, 252);
            gpbProdutos.TabIndex = 0;
            gpbProdutos.TabStop = false;
            gpbProdutos.Text = "Produtos";
         
            // 
            // lblDataDeEntrada
            // 
            lblDataDeEntrada.AutoSize = true;
            lblDataDeEntrada.Location = new Point(27, 217);
            lblDataDeEntrada.Name = "lblDataDeEntrada";
            lblDataDeEntrada.Size = new Size(147, 25);
            lblDataDeEntrada.TabIndex = 12;
            lblDataDeEntrada.Text = "Data de Entrada";
            // 
            // dtpDataDeEntrada
            // 
            dtpDataDeEntrada.Format = DateTimePickerFormat.Short;
            dtpDataDeEntrada.Location = new Point(180, 211);
            dtpDataDeEntrada.Name = "dtpDataDeEntrada";
            dtpDataDeEntrada.Size = new Size(116, 33);
            dtpDataDeEntrada.TabIndex = 11;
           
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(140, 133);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 33);
            txtQuantidade.TabIndex = 8;
      
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(23, 136);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(111, 25);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // mtbValor
            // 
            mtbValor.Location = new Point(89, 98);
            mtbValor.Mask = "$00.00";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(100, 33);
            mtbValor.TabIndex = 6;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(23, 98);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(56, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(120, 63);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 33);
            txtDescricao.TabIndex = 3;
          
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 66);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(94, 25);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descricao";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(102, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 33);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(23, 31);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 25);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
        
            // 
            // gpbProdutosCadastrados
            // 
            gpbProdutosCadastrados.Controls.Add(lblDataDeSaida);
            gpbProdutosCadastrados.Controls.Add(mtbValorCadastro);
            gpbProdutosCadastrados.Controls.Add(dtmDataSaida);
            gpbProdutosCadastrados.Controls.Add(lblCodigoCadastro);
            gpbProdutosCadastrados.Controls.Add(txtTotalCadastro);
            gpbProdutosCadastrados.Controls.Add(txtCodigoCadastro);
            gpbProdutosCadastrados.Controls.Add(lblTotalCadastro);
            gpbProdutosCadastrados.Controls.Add(lblDescricaoCadastro);
            gpbProdutosCadastrados.Controls.Add(txtQuantidadeCadastro);
            gpbProdutosCadastrados.Controls.Add(txtDescricaoCadastro);
            gpbProdutosCadastrados.Controls.Add(lblQuantidadeTotal);
            gpbProdutosCadastrados.Controls.Add(lblValorCadastro);
            gpbProdutosCadastrados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbProdutosCadastrados.Location = new Point(391, 12);
            gpbProdutosCadastrados.Name = "gpbProdutosCadastrados";
            gpbProdutosCadastrados.Size = new Size(288, 252);
            gpbProdutosCadastrados.TabIndex = 1;
            gpbProdutosCadastrados.TabStop = false;
            gpbProdutosCadastrados.Text = "Cadastro";
            // 
            // lblDataDeSaida
            // 
            lblDataDeSaida.AutoSize = true;
            lblDataDeSaida.Location = new Point(13, 217);
            lblDataDeSaida.Name = "lblDataDeSaida";
            lblDataDeSaida.Size = new Size(128, 25);
            lblDataDeSaida.TabIndex = 24;
            lblDataDeSaida.Text = "Data de Saida";
            // 
            // mtbValorCadastro
            // 
            mtbValorCadastro.Location = new Point(75, 98);
            mtbValorCadastro.Mask = "$00.00";
            mtbValorCadastro.Name = "mtbValorCadastro";
            mtbValorCadastro.Size = new Size(100, 33);
            mtbValorCadastro.TabIndex = 18;
            // 
            // dtmDataSaida
            // 
            dtmDataSaida.Format = DateTimePickerFormat.Short;
            dtmDataSaida.Location = new Point(166, 211);
            dtmDataSaida.Name = "dtmDataSaida";
            dtmDataSaida.Size = new Size(116, 33);
            dtmDataSaida.TabIndex = 23;
            // 
            // lblCodigoCadastro
            // 
            lblCodigoCadastro.AutoSize = true;
            lblCodigoCadastro.Location = new Point(9, 31);
            lblCodigoCadastro.Name = "lblCodigoCadastro";
            lblCodigoCadastro.Size = new Size(73, 25);
            lblCodigoCadastro.TabIndex = 13;
            lblCodigoCadastro.Text = "Codigo";
            // 
            // txtTotalCadastro
            // 
            txtTotalCadastro.Location = new Point(75, 171);
            txtTotalCadastro.Name = "txtTotalCadastro";
            txtTotalCadastro.Size = new Size(100, 33);
            txtTotalCadastro.TabIndex = 22;
            // 
            // txtCodigoCadastro
            // 
            txtCodigoCadastro.Location = new Point(88, 28);
            txtCodigoCadastro.Name = "txtCodigoCadastro";
            txtCodigoCadastro.Size = new Size(100, 33);
            txtCodigoCadastro.TabIndex = 14;
            // 
            // lblTotalCadastro
            // 
            lblTotalCadastro.AutoSize = true;
            lblTotalCadastro.Location = new Point(13, 174);
            lblTotalCadastro.Name = "lblTotalCadastro";
            lblTotalCadastro.Size = new Size(52, 25);
            lblTotalCadastro.TabIndex = 21;
            lblTotalCadastro.Text = "Total";
            // 
            // lblDescricaoCadastro
            // 
            lblDescricaoCadastro.AutoSize = true;
            lblDescricaoCadastro.Location = new Point(9, 66);
            lblDescricaoCadastro.Name = "lblDescricaoCadastro";
            lblDescricaoCadastro.Size = new Size(94, 25);
            lblDescricaoCadastro.TabIndex = 15;
            lblDescricaoCadastro.Text = "Descricao";
            // 
            // txtQuantidadeCadastro
            // 
            txtQuantidadeCadastro.Location = new Point(126, 133);
            txtQuantidadeCadastro.Name = "txtQuantidadeCadastro";
            txtQuantidadeCadastro.Size = new Size(100, 33);
            txtQuantidadeCadastro.TabIndex = 20;
            // 
            // txtDescricaoCadastro
            // 
            txtDescricaoCadastro.Location = new Point(106, 63);
            txtDescricaoCadastro.Name = "txtDescricaoCadastro";
            txtDescricaoCadastro.Size = new Size(100, 33);
            txtDescricaoCadastro.TabIndex = 16;
            // 
            // lblQuantidadeTotal
            // 
            lblQuantidadeTotal.AutoSize = true;
            lblQuantidadeTotal.Location = new Point(9, 136);
            lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            lblQuantidadeTotal.Size = new Size(111, 25);
            lblQuantidadeTotal.TabIndex = 19;
            lblQuantidadeTotal.Text = "Quantidade";
            // 
            // lblValorCadastro
            // 
            lblValorCadastro.AutoSize = true;
            lblValorCadastro.Location = new Point(9, 98);
            lblValorCadastro.Name = "lblValorCadastro";
            lblValorCadastro.Size = new Size(56, 25);
            lblValorCadastro.TabIndex = 17;
            lblValorCadastro.Text = "Valor";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(10, 404);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 34);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(114, 404);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(98, 34);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(218, 404);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(98, 34);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(gpbProdutosCadastrados);
            Controls.Add(gpbProdutos);
            Name = "frmProdutos";
            Text = "Produto";
            
            gpbProdutos.ResumeLayout(false);
            gpbProdutos.PerformLayout();
            gpbProdutosCadastrados.ResumeLayout(false);
            gpbProdutosCadastrados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbProdutos;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblValor;
        private MaskedTextBox mtbValor;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private DateTimePicker dtpDataDeEntrada;
        private Label lblDataDeEntrada;
        private GroupBox gpbProdutosCadastrados;
        private Label lblDataDeSaida;
        private MaskedTextBox mtbValorCadastro;
        private DateTimePicker dtmDataSaida;
        private Label lblCodigoCadastro;
        private TextBox txtTotalCadastro;
        private TextBox txtCodigoCadastro;
        private Label lblTotalCadastro;
        private Label lblDescricaoCadastro;
        private TextBox txtQuantidadeCadastro;
        private TextBox txtDescricaoCadastro;
        private Label lblQuantidadeTotal;
        private Label lblValorCadastro;
        private Button btnCadastrar;
        private Button btnLimpar;
        private Button btnSair;
    }
}