using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaApp
{
    public class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public double SaldoCashBack { get; set; }


        public Conta(string nome, double saldo, double limite)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Limite = limite;
        }

        public void Deposita(double Valor)
        {
            this.Saldo += Valor;
            this.SaldoCashBack += Valor * 0.05;
        }

        public void Saca(double Valor)
        {
            this.Saldo -= Valor;
            this.SaldoCashBack += 1.00;
        }

        public double Consulta()
        {
            return this.Saldo;
        }

        

    }
}
