namespace Atividade6
{
    partial class frmMensalista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntradaNaEmpresa = new System.Windows.Forms.TextBox();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstanciarMensalistaParametro = new System.Windows.Forms.Button();
            this.gtxTrabalhoHomeOffice = new System.Windows.Forms.GroupBox();
            this.rdbtnSim = new System.Windows.Forms.RadioButton();
            this.rdbtnNao = new System.Windows.Forms.RadioButton();
            this.gtxTrabalhoHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(40, 47);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(184, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(40, 126);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(184, 20);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntradaNaEmpresa
            // 
            this.txtDataEntradaNaEmpresa.Location = new System.Drawing.Point(40, 167);
            this.txtDataEntradaNaEmpresa.Name = "txtDataEntradaNaEmpresa";
            this.txtDataEntradaNaEmpresa.Size = new System.Drawing.Size(184, 20);
            this.txtDataEntradaNaEmpresa.TabIndex = 7;
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(40, 193);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(184, 36);
            this.btnInstanciarMensalista.TabIndex = 8;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.BtnInstanciarMensalista_Click);
            // 
            // btnInstanciarMensalistaParametro
            // 
            this.btnInstanciarMensalistaParametro.Location = new System.Drawing.Point(40, 235);
            this.btnInstanciarMensalistaParametro.Name = "btnInstanciarMensalistaParametro";
            this.btnInstanciarMensalistaParametro.Size = new System.Drawing.Size(184, 36);
            this.btnInstanciarMensalistaParametro.TabIndex = 9;
            this.btnInstanciarMensalistaParametro.Text = "Instanciar Mensalista Passando Parâmetros";
            this.btnInstanciarMensalistaParametro.UseVisualStyleBackColor = true;
            // 
            // gtxTrabalhoHomeOffice
            // 
            this.gtxTrabalhoHomeOffice.Controls.Add(this.rdbtnNao);
            this.gtxTrabalhoHomeOffice.Controls.Add(this.rdbtnSim);
            this.gtxTrabalhoHomeOffice.Location = new System.Drawing.Point(307, 31);
            this.gtxTrabalhoHomeOffice.Name = "gtxTrabalhoHomeOffice";
            this.gtxTrabalhoHomeOffice.Size = new System.Drawing.Size(206, 140);
            this.gtxTrabalhoHomeOffice.TabIndex = 10;
            this.gtxTrabalhoHomeOffice.TabStop = false;
            this.gtxTrabalhoHomeOffice.Text = "Trabalho Home Office";
            this.gtxTrabalhoHomeOffice.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rdbtnSim
            // 
            this.rdbtnSim.AutoSize = true;
            this.rdbtnSim.Location = new System.Drawing.Point(37, 50);
            this.rdbtnSim.Name = "rdbtnSim";
            this.rdbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rdbtnSim.TabIndex = 0;
            this.rdbtnSim.TabStop = true;
            this.rdbtnSim.Text = "Sim";
            this.rdbtnSim.UseVisualStyleBackColor = true;
            // 
            // rdbtnNao
            // 
            this.rdbtnNao.AutoSize = true;
            this.rdbtnNao.Location = new System.Drawing.Point(37, 79);
            this.rdbtnNao.Name = "rdbtnNao";
            this.rdbtnNao.Size = new System.Drawing.Size(45, 17);
            this.rdbtnNao.TabIndex = 1;
            this.rdbtnNao.TabStop = true;
            this.rdbtnNao.Text = "Não";
            this.rdbtnNao.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gtxTrabalhoHomeOffice);
            this.Controls.Add(this.btnInstanciarMensalistaParametro);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtDataEntradaNaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gtxTrabalhoHomeOffice.ResumeLayout(false);
            this.gtxTrabalhoHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaNaEmpresa;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstanciarMensalistaParametro;
        private System.Windows.Forms.GroupBox gtxTrabalhoHomeOffice;
        private System.Windows.Forms.RadioButton rdbtnNao;
        private System.Windows.Forms.RadioButton rdbtnSim;
    }
}