using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class Aluno:IFSP
    {
        double IRA = 0;
        public Aluno(): base(2)
        {
        }

        public void Gravar(string name, string area, double ira) //$
        {
            base.Gravar(name, area);
            this.IRA = ira;
        }

        public override string ToString()
        {
            return base.ToString() + " IRA: " + this.IRA;
        }

        public override void Imprimir()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
