using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Ex.Assincronismo
{
    public partial class Aplicativo_Financeiro : Form
    {
        public Aplicativo_Financeiro()
        {
            InitializeComponent();
        }

        private void Aplicativo_Financeiro_Load(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            

            await Calcular();
            


        }
        private async Task<double> CalculoFolhaDePagamento(double valor)
        {
            double pagamento = 1104.45;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return valor -= pagamento;
        }
        private async Task<double> CalculoImpostos(double valor2)
        {
            double pagamento = 300;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return valor2 -= pagamento;

        }
        private async Task<double> CalculoReceitas(double valor3)
        {
            double pagamento = 300;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return valor3 -= pagamento;
        }

        private async Task<double> CalculoDespesas(double valor4)
        {
            double pagamento = 300;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return valor4 -= pagamento;

        }

        private async Task Calcular ()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            double FolhaDePagamento;
            double Impostos;
            double Receitas;
            double Despesas;

            btnCalcular.Enabled = false;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Calculando... Aguarde...";

            await Task.Delay(TimeSpan.FromSeconds(3));

            FolhaDePagamento = await CalculoFolhaDePagamento(Convert.ToDouble(txtRecebeValor.Text));
            Impostos = await CalculoImpostos(Convert.ToDouble(txtRecebeValor.Text));
            Receitas = await CalculoReceitas(Convert.ToDouble(txtRecebeValor.Text));
            Despesas = await CalculoDespesas(Convert.ToDouble(txtRecebeValor.Text));

            stopwatch.Stop();

            lblStatus.Text = "Cálculo realizado com sucesso!";
            lblStatus.ForeColor = Color.Green;
            btnCalcular.Enabled = true;
            lblResultado.Visible = true;
            lstBoxResultado.Visible = true; 
            lblTempo.Visible = true;

            lstBoxResultado.Items.Add($"FOLHA DE PAGAMENTO : {FolhaDePagamento}");
            lstBoxResultado.Items.Add($"IMPOSTOS : {Impostos}");
            lstBoxResultado.Items.Add($"RECEITAS : {Receitas}");
            lstBoxResultado.Items.Add($"DESPESAS : {Despesas}");

            lblTempo.Text = $"Todo o processo durou: {stopwatch.ElapsedMilliseconds} ms";

        }

        private void txtFolhaDePagamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
