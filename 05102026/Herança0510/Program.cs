using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança0510
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             IFSP U1 = new IFSP();
            IFSP U2 = new IFSP();
            U1.Gravar("Nessinha");
            U2.Gravar("Nessinha1");
            Console.WriteLine(U1.ToString());
            */

            /*
             Console.WriteLine(U1.Prontuario + "-" + U1.Nome);
            Console.WriteLine(U2.Prontuario + "-" + U2.Nome);
            */
            // Professor P1 = new Professor();
            // P1.Gravar("Lívia", "Matematica");

            // Aluno A1 = new Aluno();
            // A1.Gravar("Lucy", "Ti", 10);
            // A1.Imprimir();

            //a partir de agora todos serão ifsp - vou criar um vetor de pessoas do ifsp, porêm a refer~encia tá no objeto real
            List<IFSP> Lista = new List<IFSP>();
            Lista.Add(new IFSP());
            Lista.Add(new Professor());
            Lista.Add(new Aluno());

            foreach(IFSP U in Lista)
            {
                switch (U.Classe)
                {
                    case 0:
                        U.Gravar("Valtemir", "Informatica");
                        break;
                    case 1:
                        U.Gravar("Valtemir", "Informatica", 1200);
                        break;
                    case 2:
                        U.Gravar("Valtemir", "Informatica", 10);
                        break;
                }
            }

            Lista[0].Imprimir;
            Lista[1].Imprimir;
            Lista[2].Imprimir;


        }
    }
}
