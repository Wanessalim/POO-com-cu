using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class Professor : IFSP //herdar IFSP, é já ter o prontuario e o nome, e os metodos 
    {
        double Salario = 0;

        public Professor(): base(1)
        {

        }

        public void Gravar(string name, string area, double salario)
        {
            base.Gravar(name, area);
            this.Salario = salario;
        }

        public override string ToString()
        {
            return base.ToString() + " Salario: " + this.Salario;
        }

        public override void Imprimir()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
