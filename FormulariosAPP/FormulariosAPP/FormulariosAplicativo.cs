using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormulariosAPP
{
    public partial class FormulariosAplicativo : Form
    {
        FuncionamentoCarro Carro;
        public FormulariosAplicativo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriaCarro_Click(object sender, EventArgs e)
        {
            if (txtmodelo.Text == "" || txtconsumo.Text == "" || txtniveldecombustivel.Text == "" || txtdistanciapercorrida.Text == "")
            {
                MessageBox.Show("Informe Valores!");
            }
            else
            {
                Carro = new FuncionamentoCarro(txtmodelo.Text, double.Parse(txtconsumo.Text), double.Parse(txtniveldecombustivel.Text), double.Parse(txtdistanciapercorrida.Text));
                txtmodelo.ReadOnly = true;
                txtconsumo.ReadOnly = true;
                txtniveldecombustivel.ReadOnly = true;
                txtdistanciapercorrida.ReadOnly = true;
                MessageBox.Show("Carro criado com sucesso!");
            }
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            if (txtlitros.Text == "")
            {
                MessageBox.Show("Informe valor da litragêm");
            }
            else
            {
                Carro.Abastecer(double.Parse(txtlitros.Text));
                txtniveldecombustivel.Text = "";
                txtniveldecombustivel.Text = Carro.ConsultaCombustivel().ToString();
            }
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            if (txtdistancia.Text == "")
            {
                MessageBox.Show("Informe valor da Distância");
            }
            else
            {
                if (Carro.Andar(double.Parse(txtdistancia.Text)) )
                {
                    MessageBox.Show("Viagem é realizavel :)");
                    txtdistanciapercorrida.Text = Carro.DistanciaPercorrida.ToString();
                    txtniveldecombustivel.Text = Carro.NivelCombustivel.ToString();

                }
                else
                {
                    MessageBox.Show("Viagem não é realizavel :(");
                }

                
            }
        }

        private void btnCalculaAutomonia_Click(object sender, EventArgs e)
        {
            txtautonomia.Text = "";
            txtautonomia.Text = Carro.CalcularAutonomia().ToString();
        }
    }
}
