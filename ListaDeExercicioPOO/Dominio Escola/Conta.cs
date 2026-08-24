using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Escola
{
    public class Conta
    {
        public int Numero;
        public double Limite;
        public double Saldo;
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}
