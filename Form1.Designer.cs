namespace SisBanco
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeDoCliente = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.NumeroDaConta = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.cmdDepositar = new System.Windows.Forms.Button();
            this.cmdSaque = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataDeNascimento = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.dadosConta = new System.Windows.Forms.TabControl();
            this.Cliente = new System.Windows.Forms.TabPage();
            this.cmdCriar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoConta = new System.Windows.Forms.ComboBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.cboTitular = new System.Windows.Forms.ComboBox();
            this.dadosConta.SuspendLayout();
            this.Cliente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeDoCliente
            // 
            this.txtNomeDoCliente.Location = new System.Drawing.Point(242, 77);
            this.txtNomeDoCliente.Name = "txtNomeDoCliente";
            this.txtNomeDoCliente.Size = new System.Drawing.Size(195, 20);
            this.txtNomeDoCliente.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(251, 114);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(144, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.lblNumeroDaConta_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(251, 146);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(282, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(251, 178);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(282, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Teal;
            this.txtNome.Location = new System.Drawing.Point(174, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(45, 17);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome";
            // 
            // NumeroDaConta
            // 
            this.NumeroDaConta.AutoSize = true;
            this.NumeroDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDaConta.ForeColor = System.Drawing.Color.Teal;
            this.NumeroDaConta.Location = new System.Drawing.Point(126, 115);
            this.NumeroDaConta.Name = "NumeroDaConta";
            this.NumeroDaConta.Size = new System.Drawing.Size(119, 17);
            this.NumeroDaConta.TabIndex = 5;
            this.NumeroDaConta.Text = "Numero da Conta";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saldo.ForeColor = System.Drawing.Color.Teal;
            this.Saldo.Location = new System.Drawing.Point(201, 146);
            this.Saldo.Name = "Saldo";
            this.Saldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Saldo.Size = new System.Drawing.Size(44, 17);
            this.Saldo.TabIndex = 6;
            this.Saldo.Text = "Saldo";
            this.Saldo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.ForeColor = System.Drawing.Color.Teal;
            this.Valor.Location = new System.Drawing.Point(204, 178);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(41, 17);
            this.Valor.TabIndex = 7;
            this.Valor.Text = "Valor";
            // 
            // cmdDepositar
            // 
            this.cmdDepositar.Location = new System.Drawing.Point(314, 246);
            this.cmdDepositar.Name = "cmdDepositar";
            this.cmdDepositar.Size = new System.Drawing.Size(99, 32);
            this.cmdDepositar.TabIndex = 8;
            this.cmdDepositar.Text = "Depositar";
            this.cmdDepositar.UseVisualStyleBackColor = true;
            this.cmdDepositar.Click += new System.EventHandler(this.cmdDepositar_Click);
            // 
            // cmdSaque
            // 
            this.cmdSaque.Location = new System.Drawing.Point(481, 246);
            this.cmdSaque.Name = "cmdSaque";
            this.cmdSaque.Size = new System.Drawing.Size(100, 32);
            this.cmdSaque.TabIndex = 9;
            this.cmdSaque.Text = "Sacar";
            this.cmdSaque.UseVisualStyleBackColor = true;
            this.cmdSaque.Click += new System.EventHandler(this.cmdSaque_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Teal;
            this.lblCPF.Location = new System.Drawing.Point(185, 148);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 17);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Teal;
            this.lblData.Location = new System.Drawing.Point(181, 117);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // txtDataDeNascimento
            // 
            this.txtDataDeNascimento.Location = new System.Drawing.Point(242, 116);
            this.txtDataDeNascimento.Name = "txtDataDeNascimento";
            this.txtDataDeNascimento.Size = new System.Drawing.Size(195, 20);
            this.txtDataDeNascimento.TabIndex = 11;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(242, 147);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(195, 20);
            this.txtCPF.TabIndex = 10;
            // 
            // dadosConta
            // 
            this.dadosConta.Controls.Add(this.Cliente);
            this.dadosConta.Controls.Add(this.tabPage2);
            this.dadosConta.Location = new System.Drawing.Point(22, 54);
            this.dadosConta.Name = "dadosConta";
            this.dadosConta.SelectedIndex = 0;
            this.dadosConta.Size = new System.Drawing.Size(667, 352);
            this.dadosConta.TabIndex = 11;
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.cmdCriar);
            this.Cliente.Controls.Add(this.lblCPF);
            this.Cliente.Controls.Add(this.txtCPF);
            this.Cliente.Controls.Add(this.txtNome);
            this.Cliente.Controls.Add(this.lblData);
            this.Cliente.Controls.Add(this.txtNomeDoCliente);
            this.Cliente.Controls.Add(this.txtDataDeNascimento);
            this.Cliente.Location = new System.Drawing.Point(4, 22);
            this.Cliente.Name = "Cliente";
            this.Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Cliente.Size = new System.Drawing.Size(659, 326);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            this.Cliente.UseVisualStyleBackColor = true;
            this.Cliente.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmdCriar
            // 
            this.cmdCriar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdCriar.Location = new System.Drawing.Point(479, 249);
            this.cmdCriar.Name = "cmdCriar";
            this.cmdCriar.Size = new System.Drawing.Size(128, 42);
            this.cmdCriar.TabIndex = 14;
            this.cmdCriar.Text = "Criar Cliente";
            this.cmdCriar.UseVisualStyleBackColor = true;
            this.cmdCriar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboTitular);
            this.tabPage2.Controls.Add(this.btnAdicionar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cboTipoConta);
            this.tabPage2.Controls.Add(this.lblTitular);
            this.tabPage2.Controls.Add(this.cmdSaque);
            this.tabPage2.Controls.Add(this.NumeroDaConta);
            this.tabPage2.Controls.Add(this.cmdDepositar);
            this.tabPage2.Controls.Add(this.Saldo);
            this.tabPage2.Controls.Add(this.txtNumero);
            this.tabPage2.Controls.Add(this.txtValor);
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.Valor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(156, 246);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 32);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(401, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo";
            // 
            // cboTipoConta
            // 
            this.cboTipoConta.AutoCompleteCustomSource.AddRange(new string[] {
            "1 - CC",
            "2 - CP"});
            this.cboTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboTipoConta.FormattingEnabled = true;
            this.cboTipoConta.Items.AddRange(new object[] {
            "1 - Conta Corrente",
            "2 - Conta Poupança"});
            this.cboTipoConta.Location = new System.Drawing.Point(435, 113);
            this.cboTipoConta.Name = "cboTipoConta";
            this.cboTipoConta.Size = new System.Drawing.Size(98, 21);
            this.cboTipoConta.TabIndex = 15;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.ForeColor = System.Drawing.Color.Teal;
            this.lblTitular.Location = new System.Drawing.Point(197, 50);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(48, 17);
            this.lblTitular.TabIndex = 11;
            this.lblTitular.Text = "Titular";
            // 
            // cboTitular
            // 
            this.cboTitular.FormattingEnabled = true;
            this.cboTitular.Location = new System.Drawing.Point(251, 50);
            this.cboTitular.Name = "cboTitular";
            this.cboTitular.Size = new System.Drawing.Size(282, 21);
            this.cboTitular.TabIndex = 18;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dadosConta);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.dadosConta.ResumeLayout(false);
            this.Cliente.ResumeLayout(false);
            this.Cliente.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDoCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label NumeroDaConta;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button cmdDepositar;
        private System.Windows.Forms.Button cmdSaque;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDataDeNascimento;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TabControl dadosConta;
        private System.Windows.Forms.TabPage Cliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdCriar;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.ComboBox cboTipoConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cboTitular;
    }
}

