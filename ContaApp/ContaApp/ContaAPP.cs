using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContaApp
{
    
    public partial class ContaAPP : Form
    {
        Conta conta;
        public ContaAPP()
        {
            InitializeComponent();
        }

        private void btnCriaConta_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtSaldo.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Informe Valores de nome, Saldo e limite da conta!");
            }
            else
            {
                conta = new Conta(txtName.Text, double.Parse(txtSaldo.Text), double.Parse(txtLimite.Text));
                txtName.ReadOnly = true;
                txtSaldo.ReadOnly = true;
                txtLimite.ReadOnly = true;
                MessageBox.Show("Conta criada com sucesso!");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if(txtValor.Text == "")
            {
                MessageBox.Show("Informe valor da operação");
            }
            else{
                conta.Saca(double.Parse(txtValor.Text));
                txtValor.Text = "";
                txtSaldo.Text = conta.Consulta().ToString();
                txtCashBack.Text = "";
                txtCashBack.Text = conta.SaldoCashBack.ToString();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Informe valor da operação");
            }
            else
            {
                conta.Deposita(double.Parse(txtValor.Text));
                txtValor.Text = "";
                txtSaldo.Text = conta.Consulta().ToString();
                txtCashBack.Text = "";
                txtCashBack.Text = conta.SaldoCashBack.ToString();

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo Atual: " + conta.Consulta().ToString());
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCashBack_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
