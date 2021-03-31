namespace AulaRAD01
{
    partial class FrmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radPessoaFisica = new System.Windows.Forms.RadioButton();
            this.radPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(25, 66);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(30, 13);
            this.lblCPFCNPJ.TabIndex = 0;
            this.lblCPFCNPJ.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(101, 140);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(101, 184);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(298, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço:";
            // 
            // radPessoaFisica
            // 
            this.radPessoaFisica.AutoSize = true;
            this.radPessoaFisica.Checked = true;
            this.radPessoaFisica.Location = new System.Drawing.Point(101, 22);
            this.radPessoaFisica.Name = "radPessoaFisica";
            this.radPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.radPessoaFisica.TabIndex = 8;
            this.radPessoaFisica.TabStop = true;
            this.radPessoaFisica.Text = "Pessoa Física";
            this.radPessoaFisica.UseVisualStyleBackColor = true;
            this.radPessoaFisica.CheckedChanged += new System.EventHandler(this.radPessoaFisica_CheckedChanged);
            // 
            // radPessoaJuridica
            // 
            this.radPessoaJuridica.AutoSize = true;
            this.radPessoaJuridica.Location = new System.Drawing.Point(241, 22);
            this.radPessoaJuridica.Name = "radPessoaJuridica";
            this.radPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.radPessoaJuridica.TabIndex = 9;
            this.radPessoaJuridica.Text = "Pessoa Jurídica";
            this.radPessoaJuridica.UseVisualStyleBackColor = true;
            this.radPessoaJuridica.CheckedChanged += new System.EventHandler(this.radPessoaJuridica_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(101, 227);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(101, 59);
            this.txtCPFCNPJ.Mask = "000.000.000-00";
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(136, 20);
            this.txtCPFCNPJ.TabIndex = 11;
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(537, 306);
            this.Controls.Add(this.txtCPFCNPJ);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.radPessoaJuridica);
            this.Controls.Add(this.radPessoaFisica);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCPFCNPJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadCliente";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radPessoaFisica;
        private System.Windows.Forms.RadioButton radPessoaJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtCPFCNPJ;
    }
}

