using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContas
{
    public class Conta
    {
        private string Codigo;
        double Saldo, Limite;

        //Construtor
        public Conta(string Codigo, double Saldo, double Limite)
        {
           // MessageBox.Show("Código: "+Codigo+" Saldo: "+ Saldo +" Limite: "+Limite);
            
            this.Codigo = Codigo;
            this.Saldo = Saldo;
            this.Limite = Limite;
        }

        public string GetCodigo()
        {
            return this.Codigo;
        }

        public void SetCodigo(string Value)
        {
            this.Codigo = Value;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public void SetSaldo(double Value)
        {
            if (Value > 0)
            {
                this.Saldo = Value;
            }
            else
            {
                MessageBox.Show("Saldo não pode ser negativo!!!");
            }
            
        }


        public double GetLimite()
        {
            return this.Limite;
        }

        public void SetLimite(double Value)
        {
            this.Limite = Value;
        }

        public void Depositar(double Value)
        {
            this.Saldo += Value;
        }

        public void Sacar(double Value)
        {
            this.Saldo -= Value;
        }


    }
}
