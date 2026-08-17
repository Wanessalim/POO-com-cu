using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoBanco
{
    internal class Program
    {
        class ContaBancaria
        {
            public string Nome;
            public int Codigo;
            public double Limite;
            public double Saldo;

            public void ImprimeDados()
            {
                System.Console.WriteLine(Nome);
                System.Console.WriteLine(Codigo);
                System.Console.WriteLine(Limite);
                System.Console.WriteLine(Saldo);
            }
        }

        class CartaoDeCredito
        {
            public int Identificador;
            public int Agencia;
            //Relação de agregação.
            public ContaBancaria ContaAssociada;
        }
        static void Main(string[] args)
        {
            ContaBancaria Conta1 = new ContaBancaria()
            {
                Nome = "Lucy Lima",
                Codigo = 1,
                Limite = 3000.0,
                Saldo = 10000.0
            };
            Conta1.ImprimeDados();


        }
    }
}
