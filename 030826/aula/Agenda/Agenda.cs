using System;

namespace Agenda
{
    internal class Agenda
    {
        struct Contato //conjunto de dados relacionado a uma entidade (Contato)
        {
            public string Nome, Email , Estado;
            public int Idade;
        }

        static void Menu(Contato[] Ag, ref int Tam)
        {
            int Op, OpImp, Pos;
            string Estado;
            do
            {
                Console.Clear();//limpa tela
                Console.WriteLine("*****Agenda de Contatos*****");
                Console.WriteLine();

                Console.WriteLine("[1] - para cadastrar");
                Console.WriteLine("[2] - Para Buscar adulto por estado");
                Console.WriteLine("[3] - para buscar pessoa mais velha");
                Console.WriteLine("[4] - Impressão"); //fazer impressão especial.
                Console.Write("Opção desejada: ");
                Op = System.Int32.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1:
                        Cadastrar(Ag, ref Tam);
                        break;
                    case 2:
                        Console.Write("Qual Estado: ");
                        Estado = Console.ReadLine();
                        ImprimirPorIdadeEstado(Ag, Tam, 18 ,Estado);
                        break;
                    case 3:
                        //vai me obrigar a imprimir so uma pessoa - um registro
                        Pos = BuscarMaisVelho(Ag, Tam);
                        if (Pos >= 0) //posição válida!!
                        {
                            ImprimirRegistro(Ag, Pos, false);
                        }
                        break;
                    case 4:
                        Console.Write("1 - Total / 2 - Parcial: ");
                        OpImp = Int32.Parse(Console.ReadLine());
                        Imprimir(Ag, Tam, OpImp == 2);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

                Console.ReadKey(); //espera resposta
            } while (Op != 5);
        }

        static int Cadastrar(Contato[] Ag, ref int  Tam)
        {
            Console.Write("Nome: ");
            Ag[Tam].Nome = Console.ReadLine();
            Console.Write("E-mail: ");
            Ag[Tam].Email = Console.ReadLine();
            Console.Write("Estado: ");
            Ag[Tam].Estado = Console.ReadLine();
            Console.Write("Idade:");
            Ag[Tam].Idade = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Tam++;
            return Tam;
        }

        static void Imprimir(Contato[] Ag,  int Tam, bool Parcial)
        {
            int Cont;
            
            for(Cont = 0; Cont < Tam; Cont++)
            {
                ImprimirRegistro(Ag, Cont, Parcial);
            }
            Console.WriteLine();
                
        }

        static void ImprimirPorIdadeEstado(Contato[] Ag, int Tam, int Idade ,string Estado)
        {
            int Cont;
            for (Cont = 0; Cont < Tam; Cont++)
            {
                if (Ag[Cont].Idade >= Idade && Ag[Cont].Estado == Estado)
                {
                    ImprimirRegistro(Ag, Cont, false);
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine();

        }

        static void ImprimirRegistro(Contato[] Ag, int Pos, bool Parcial)
        {
            Console.Write("Nome: " + Ag[Pos].Nome);
            Console.Write(" E-mail: " + Ag[Pos].Email);
            if (!Parcial)
            {
                Console.Write(" Estado: " + Ag[Pos].Estado);
                Console.Write(" Idade: " + Ag[Pos].Idade);
            }
            Console.WriteLine();
        }

        static int BuscarMaisVelho(Contato[] Ag, int Tam)
        {
            int Cont, Pos = -1, MaiorIdade = 0;

            for (Cont = 0; Cont < Tam; Cont++)
            {
                if(Cont == 0 || Ag[Cont].Idade > MaiorIdade)
                {
                    MaiorIdade = Ag[Cont].Idade;
                    Pos = Cont;
                }
            }

            return Pos;
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
