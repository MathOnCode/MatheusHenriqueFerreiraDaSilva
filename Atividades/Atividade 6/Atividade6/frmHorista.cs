using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.Matricula = Convert.ToInt32(txtMatricula);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtMatricula);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            if (rdbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show($"Matrícula: {objHorista.Matricula}\n" +
                $"Nome: {objHorista.NomeEmpregado}\n" +
                $"Data Entrada: {objHorista.DataEntradaEmpresa}\n" +
                $"Salário Bruto: {objHorista.SalarioBruto().ToString("N2")}\n" +
                $"Tempo Empresa (dias): {objHorista.TempoTrabalho()}\n" +
                $"{objHorista.VerificaHome()}\n" +
                $"Salário por Hora: {objHorista.SalarioHora}\n" +
                $"Número de Horas: {objHorista.SalarioHora}\n" +
                $"Dias Falta: {objHorista.DiasFalta}");
        }
    }
}
