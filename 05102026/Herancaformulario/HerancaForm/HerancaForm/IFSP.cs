using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class IFSP
    {
        private static int Id = 0; // todos os objetos enxergam uma variavel só
        public string Prontuario { get; } //apenas construtor consegue gravar no prontuario
        public int Classe { get; } // 1 - professor, 2 - aluno
        public string Nome { get; set; } //campo de força criado
        public string Area { get; set; } //protected da visibilidade para as classes filhas.

        public IFSP()
        {
            ++IFSP.Id;
            this.Prontuario = "BI" + Id.ToString("D7");
            this.Classe = 0;
        }

        public IFSP(int classe): this() /*construtor não recebe chamada, então não posso usar :ifsp() direto*/
        {
            this.Classe = classe;
        }


        public void  Gravar(string name, string area)
        {
            this.Nome = name;
            this.Area = area;
        }

        
        public override string ToString()
        {
            return "Prontuario: " + this.Prontuario + " - Nome: " + this.Nome; 
        }

        public virtual void Imprimir()
        {
            Console.WriteLine(this.ToString());
        }

        public string MostraArea()
        {
            return "Area: " + this.Area; 
        }
    }
}
