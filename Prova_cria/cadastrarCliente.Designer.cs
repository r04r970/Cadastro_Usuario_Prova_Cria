namespace Prova_cria
{
    partial class Form1
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
            this.lbl_nomeCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataAluguel = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasAluguel = new System.Windows.Forms.TextBox();
            this.lblAlguel = new System.Windows.Forms.Label();
            this.ckCartao = new System.Windows.Forms.CheckBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnDias = new System.Windows.Forms.Button();
            this.diasAluguel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdPessoas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtdPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomeCliente
            // 
            this.lbl_nomeCliente.AutoSize = true;
            this.lbl_nomeCliente.Location = new System.Drawing.Point(13, 12);
            this.lbl_nomeCliente.Name = "lbl_nomeCliente";
            this.lbl_nomeCliente.Size = new System.Drawing.Size(94, 13);
            this.lbl_nomeCliente.TabIndex = 0;
            this.lbl_nomeCliente.Text = "Nome do Cliente : ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 5);
            this.txtNome.MaxLength = 34;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dataAluguel
            // 
            this.dataAluguel.CustomFormat = "dd/mm/yyyy";
            this.dataAluguel.Location = new System.Drawing.Point(132, 83);
            this.dataAluguel.Name = "dataAluguel";
            this.dataAluguel.Size = new System.Drawing.Size(213, 20);
            this.dataAluguel.TabIndex = 5;
            this.dataAluguel.Value = new System.DateTime(2020, 3, 4, 13, 47, 44, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeiro dia do Aluguel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dias do Aluguel:";
            // 
            // txtDiasAluguel
            // 
            this.txtDiasAluguel.Location = new System.Drawing.Point(132, 57);
            this.txtDiasAluguel.Name = "txtDiasAluguel";
            this.txtDiasAluguel.Size = new System.Drawing.Size(213, 20);
            this.txtDiasAluguel.TabIndex = 4;
            this.txtDiasAluguel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasAluguel_KeyPress);
            // 
            // lblAlguel
            // 
            this.lblAlguel.AutoSize = true;
            this.lblAlguel.Location = new System.Drawing.Point(13, 109);
            this.lblAlguel.Name = "lblAlguel";
            this.lblAlguel.Size = new System.Drawing.Size(91, 13);
            this.lblAlguel.TabIndex = 9;
            this.lblAlguel.Text = "Datas do Aluguel:";
            // 
            // ckCartao
            // 
            this.ckCartao.AutoSize = true;
            this.ckCartao.Location = new System.Drawing.Point(351, 5);
            this.ckCartao.Name = "ckCartao";
            this.ckCartao.Size = new System.Drawing.Size(108, 17);
            this.ckCartao.TabIndex = 2;
            this.ckCartao.Text = "Cartão Fidelidade";
            this.ckCartao.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(175, 184);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(123, 23);
            this.btnCadastro.TabIndex = 7;
            this.btnCadastro.Text = "Cadastrar Cliente";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnDias
            // 
            this.btnDias.Location = new System.Drawing.Point(351, 83);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(101, 23);
            this.btnDias.TabIndex = 6;
            this.btnDias.Text = "Total de Dias ";
            this.btnDias.UseVisualStyleBackColor = true;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // diasAluguel
            // 
            this.diasAluguel.FormattingEnabled = true;
            this.diasAluguel.Location = new System.Drawing.Point(132, 109);
            this.diasAluguel.Name = "diasAluguel";
            this.diasAluguel.Size = new System.Drawing.Size(213, 69);
            this.diasAluguel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qtd de Pessoas: ";
            // 
            // qtdPessoas
            // 
            this.qtdPessoas.Location = new System.Drawing.Point(132, 31);
            this.qtdPessoas.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.qtdPessoas.Name = "qtdPessoas";
            this.qtdPessoas.Size = new System.Drawing.Size(213, 20);
            this.qtdPessoas.TabIndex = 12;
            this.qtdPessoas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 219);
            this.Controls.Add(this.qtdPessoas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diasAluguel);
            this.Controls.Add(this.btnDias);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblAlguel);
            this.Controls.Add(this.txtDiasAluguel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAluguel);
            this.Controls.Add(this.ckCartao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_nomeCliente);
            this.Name = "Form1";
            this.Text = "Cadastar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.qtdPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomeCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dataAluguel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiasAluguel;
        private System.Windows.Forms.Label lblAlguel;
        private System.Windows.Forms.CheckBox ckCartao;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnDias;
        private System.Windows.Forms.ListBox diasAluguel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown qtdPessoas;
    }
}

