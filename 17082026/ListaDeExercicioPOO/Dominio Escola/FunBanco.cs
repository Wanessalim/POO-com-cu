using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Escola
{
    internal class FunBanco
    {
        public string Nome;
        public double Salario;
        public FunBanco(String nome)
        {
            this.Nome = nome;
            this.Salario = 200.00;
        }

        public FunBanco(String nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
