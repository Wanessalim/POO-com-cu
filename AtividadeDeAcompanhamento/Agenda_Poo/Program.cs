using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu Agenda1 = new Menu();
            List<Contato> contatos = new List<Contato>();
            Agenda1.ExibirMenu(contatos);
        }
    }
}
