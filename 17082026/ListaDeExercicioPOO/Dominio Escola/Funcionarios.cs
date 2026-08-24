using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Escola
{
    public class Funcionarios
    {
        public string Nome;
        public string Cargo;
        public double Salario;

        public int AumentarSalario(int percentual)
        {
            Salario += Salario * percentual / 100;
            return (int)Salario;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine();
        }
    }
}
