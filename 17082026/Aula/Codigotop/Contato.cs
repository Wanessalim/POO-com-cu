using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigotop
{
    class Contato
    {
        public string Nome, Email, Estado;
        public int Idade;

        public Contato() //construtor que sempre vai ser compilado.
        {
            Console.WriteLine("Criando objeto da Classe Contato");
            /*
             this.Estado = "SP"; //pesquisar o que é this depois
             */
            
        }

        public void SetContato(string Nome, string Email, string Estado, int Idade) //Set separação
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Estado = Estado;
            this.Idade = Idade;
        }

        public Contato GetContato() //Get Recupera contato/ pega
        {

            return this;
        }
    }
}
