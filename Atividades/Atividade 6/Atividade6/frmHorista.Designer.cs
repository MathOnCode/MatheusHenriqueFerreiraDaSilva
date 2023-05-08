namespace Atividade6
{
    partial class frmHorista
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
            this.gtxTrabalhoHomeOffice = new System.Windows.Forms.GroupBox();
            this.rdbtnNao = new System.Windows.Forms.RadioButton();
            this.rdbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtDataEntradaNaEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumeroHora = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gtxTrabalhoHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gtxTrabalhoHomeOffice
            // 
            this.gtxTrabalhoHomeOffice.Controls.Add(this.rdbtnNao);
            this.gtxTrabalhoHomeOffice.Controls.Add(this.rdbtnSim);
            this.gtxTrabalhoHomeOffice.Location = new System.Drawing.Point(302, 40);
            this.gtxTrabalhoHomeOffice.Name = "gtxTrabalhoHomeOffice";
            this.gtxTrabalhoHomeOffice.Size = new System.Drawing.Size(206, 140);
            this.gtxTrabalhoHomeOffice.TabIndex = 21;
            this.gtxTrabalhoHomeOffice.TabStop = false;
            this.gtxTrabalhoHomeOffice.Text = "Trabalho Home Office";
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
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(43, 305);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(184, 36);
            this.btnInstanciarHorista.TabIndex = 19;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.BtnInstanciarHorista_Click);
            // 
            // txtDataEntradaNaEmpresa
            // 
            this.txtDataEntradaNaEmpresa.Location = new System.Drawing.Point(43, 160);
            this.txtDataEntradaNaEmpresa.Name = "txtDataEntradaNaEmpresa";
            this.txtDataEntradaNaEmpresa.Size = new System.Drawing.Size(184, 20);
            this.txtDataEntradaNaEmpresa.TabIndex = 18;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(43, 119);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(184, 20);
            this.txtSalarioMensal.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(43, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(184, 20);
            this.txtMatricula.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Salário Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Matrícula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 27;
            // 
            // txtNumeroHora
            // 
            this.txtNumeroHora.Location = new System.Drawing.Point(43, 240);
            this.txtNumeroHora.Name = "txtNumeroHora";
            this.txtNumeroHora.Size = new System.Drawing.Size(184, 20);
            this.txtNumeroHora.TabIndex = 26;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(43, 200);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(184, 20);
            this.txtSalarioHora.TabIndex = 25;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.AutoSize = true;
            this.txtDiasFalta.Location = new System.Drawing.Point(40, 263);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(69, 13);
            this.txtDiasFalta.TabIndex = 24;
            this.txtDiasFalta.Text = "Dias de Falta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Número de Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Salário por Hora";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNumeroHora);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gtxTrabalhoHomeOffice);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtDataEntradaNaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "formHorista";
            this.gtxTrabalhoHomeOffice.ResumeLayout(false);
            this.gtxTrabalhoHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gtxTrabalhoHomeOffice;
        private System.Windows.Forms.RadioButton rdbtnNao;
        private System.Windows.Forms.RadioButton rdbtnSim;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtDataEntradaNaEmpresa;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumeroHora;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.Label txtDiasFalta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}