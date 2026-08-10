using System;

namespace Agenda
{
    internal class Agenda
    {
        struct Contato //conjunto de dados relacionado a uma entidade (Contato)
        {
            public string Nome;
            public int Idade;
        }

        static void Menu(Contato[] Ag, ref int Tam)
        {
            int Op;
            do
            {
                Console.Clear();//limpa tela
                Console.WriteLine("*****Agenda de Contatos*****");
                Console.WriteLine();

                Console.WriteLine("1 - para cadastrar");
                Console.WriteLine("2 - Para Imprimir");
                Console.WriteLine("3 - Para Sair");
                Console.Write("Opção desejada: ");
                Op = System.Int32.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1:
                        Cadastrar(Ag, ref Tam);
                        break;
                    case 2:
                        Imprimir(Ag, Tam);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

                Console.ReadKey(); //espera resposta
            } while (Op != 3);
        }

        static int Cadastrar(Contato[] Ag, ref int  Tam)
        {
            Console.Write("Nome: ");
            Ag[Tam].Nome = Console.ReadLine();
            Console.Write("Idade:");
            Ag[Tam].Idade = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Tam++;
            return Tam;
        }

        static void Imprimir(Contato[] Ag,  int Tam)
        {
            int Cont;
            for(Cont = 0; Cont < Tam; Cont++)
            {
                Console.WriteLine("Nome: " + Ag[Cont].Nome);
                Console.WriteLine("Idade: " + Ag[Cont].Idade);
                Console.WriteLine();
            };
                
        }

        static void Main(string[] args)
        {
            Contato[] Ag = new Contato[50]; //declaração de vetor
            int Tam = 0;

            Menu(Ag, ref Tam);
            Console.WriteLine("\nTam: " + Tam);
        }
    }
}
