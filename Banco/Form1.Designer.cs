using System;
using System.Windows.Forms;

namespace Banco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ddlDia = new System.Windows.Forms.ComboBox();
            this.ddlMes = new System.Windows.Forms.ComboBox();
            this.ddlAno = new System.Windows.Forms.ComboBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(341, 20);
            this.txtNome.TabIndex = 7;
            // 
            // ddlDia
            // 
            this.ddlDia.FormattingEnabled = true;
            this.ddlDia.Location = new System.Drawing.Point(130, 57);
            this.ddlDia.Name = "ddlDia";
            this.ddlDia.Size = new System.Drawing.Size(42, 21);
            this.ddlDia.TabIndex = 8;
            // 
            // ddlMes
            // 
            this.ddlMes.FormattingEnabled = true;
            this.ddlMes.Location = new System.Drawing.Point(178, 57);
            this.ddlMes.Name = "ddlMes";
            this.ddlMes.Size = new System.Drawing.Size(42, 21);
            this.ddlMes.TabIndex = 10;
            // 
            // ddlAno
            // 
            this.ddlAno.FormattingEnabled = true;
            this.ddlAno.Location = new System.Drawing.Point(226, 57);
            this.ddlAno.Name = "ddlAno";
            this.ddlAno.Size = new System.Drawing.Size(62, 21);
            this.ddlAno.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(130, 93);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 20);
            this.txtCpf.TabIndex = 13;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(130, 123);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(158, 20);
            this.txtRg.TabIndex = 15;
            // 
            // txtCadastrar
            // 
            this.txtCadastrar.Location = new System.Drawing.Point(26, 184);
            this.txtCadastrar.Name = "txtCadastrar";
            this.txtCadastrar.Size = new System.Drawing.Size(126, 29);
            this.txtCadastrar.TabIndex = 16;
            this.txtCadastrar.Text = "Cadastrar";
            this.txtCadastrar.UseVisualStyleBackColor = true;
            this.txtCadastrar.Click += new System.EventHandler(this.txtCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Clientes Cadastrados:";
            // 
            // ddlClientes
            // 
            this.ddlClientes.FormattingEnabled = true;
            this.ddlClientes.Location = new System.Drawing.Point(310, 184);
            this.ddlClientes.Name = "ddlClientes";
            this.ddlClientes.Size = new System.Drawing.Size(161, 21);
            this.ddlClientes.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.ddlClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCadastrar);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.ddlAno);
            this.Controls.Add(this.ddlMes);
            this.Controls.Add(this.ddlDia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComboData();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox ddlDia;
        private System.Windows.Forms.ComboBox ddlMes;
        private System.Windows.Forms.ComboBox ddlAno;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Button txtCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlClientes;

        public void InitializeComboData()
        {
            PreencheComboData(ddlDia, 1, 31);
            PreencheComboData(ddlMes, 1, 12);
            PreencheComboData(ddlAno, 1900, DateTime.Today.Year);
        }

        public void PreencheComboData(ComboBox pobjCombo, int pintInicio, int pintFim)
        {
            pobjCombo.Items.Clear();

            for (var lintCont = pintInicio; lintCont <= pintFim; lintCont++)
                pobjCombo.Items.Add(lintCont);

            pobjCombo.SelectedIndex = 0;
        }
    }
}

