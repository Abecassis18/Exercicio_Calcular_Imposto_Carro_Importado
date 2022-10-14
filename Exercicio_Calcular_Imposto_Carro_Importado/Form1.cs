using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Calcular_Imposto_Carro_Importado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double calculoImposto(DateTime data1, int cilindrada, int co2, string combustivel )
        {
            double resultadoImposto, impCilindrada, impAmbiental, desconto;
            int idade, totalDias;

            resultadoImposto = impCilindrada = impAmbiental = desconto = 0; //Inicialiando Variáveis.

            //Calculo das clindradas
            if (cilindrada <= 1250) impCilindrada = cilindrada * 1.0 - 740.50;
            else impCilindrada = impCilindrada * 4.70 - 5362.67;

            //Calculo do imposto ambiental
            if(combustivel == "Gasolina")
            {
                if (co2 <= 115) impAmbiental = co2 * 4.15 - 390.35;
                else if (co2 <= 145) impAmbiental = co2 * 37.91 - 4281.66;
                else if (co2 <= 175) impAmbiental = co2 * 44 - 5161.20;
                else if (co2 <= 195) impAmbiental = co2 * 111.85 - 17047.04;
                else if (co2 > 195) impAmbiental = co2 * 147.69 - 24021.60;
            }

            else
            {
                if (co2 <= 95) impAmbiental = co2 * 19.97 - 1586.51;
                else if (co2 <= 120) impAmbiental = co2 * 57.15 - 5173.80;
                else if (co2 <= 140) impAmbiental = co2 * 126.75 - 13642.70;
                else if (co2 <= 160) impAmbiental = co2 * 140.96 - 15684.40;
                else if (co2 > 160) impAmbiental = co2 * 193.61 - 24137.71;
            }

            //Agora calculamos a datas para aplicar mais descontos

            DateTime dataHoje = DateTime.Today; //Apanhamos a data de Hoje.

            // Calculamos a difeença das duas datas a de hoje e a inserida pelo user, usando o TimeSpan.
            totalDias = ((TimeSpan)(dataHoje - data1)).Days;

            //Agora calculamos os anos.
            idade = (int)(totalDias / 365.2425);

            switch(idade)
            {
                case 0:
                    desconto = (impCilindrada + impAmbiental) * 0; break;
                case 1:
                    
                case 2:
                    desconto = (impCilindrada + impAmbiental) * 0.2; break;
                case 3: desconto = (impCilindrada + impAmbiental) * 0.28; break;
                case 4: desconto = (impCilindrada + impAmbiental) * 0.35; break;
                case 5: desconto = (impCilindrada + impAmbiental) * 0.43; break;
                default: desconto = desconto = (impCilindrada + impAmbiental) * 0.52; break;
            }

            resultadoImposto = impAmbiental + impCilindrada - desconto;

            if (resultadoImposto < 0) resultadoImposto = 0;
            return resultadoImposto;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double totalImposto = 0;
            if (mtxtCilindrada.MaskCompleted == true && mtxtCo2.MaskCompleted == true)
            {
                double imposto;
                string combustivel;

                if (rbGasolina.Checked == true) combustivel = "Gasolina";
                else combustivel = "Outros";

                totalImposto = calculoImposto(DateTime.Parse(dateTimePicker1.Text), int.Parse(mtxtCilindrada.Text), int.Parse(mtxtCo2.Text), combustivel);
                lblTotalImpostos.Text = totalImposto.ToString("C2");
            }

            else MessageBox.Show("Preencha os campos para o calculo",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbGasolina_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalImpostos.ResetText();
        }

        private void grbCombustivel_Enter(object sender, EventArgs e)
        {
            lblTotalImpostos.ResetText();
        }

        private void rbOutros_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
