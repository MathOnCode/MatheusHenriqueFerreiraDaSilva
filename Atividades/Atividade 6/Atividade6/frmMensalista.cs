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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtMatricula.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtMatricula.Text);

            if (rdbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            MessageBox.Show($"Matrícula: {objMensalista.Matricula}\n" +
                $"Nome: {objMensalista.NomeEmpregado}\n" +
                $"Data Entrada: {objMensalista.DataEntradaEmpresa}\n" +
                $"Salário Bruto: {objMensalista.SalarioBruto().ToString("N2")}\n" +
                $"Tempo Empresa (dias): {objMensalista.TempoTrabalho()}\n" +
                $"{objMensalista.VerificaHome()}");
        }
    }
}
