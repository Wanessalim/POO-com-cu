using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{

    internal class Agenda
    {

        struct Contato
        {
            public string Nome, Email, Endereco, Cidade, Estado;
            public int Idade;
        }

        static void BuscaMaioresde18(Contato[] Ag, string Estado)
        {
            int Cont;
            for (Cont = 0; Cont < 9; Cont++)
            {
                if (Ag[Cont].Estado == Estado)
                {
                    if (Ag[Cont].Idade >= 18)
                    {
                        Console.WriteLine("Nome: " + Ag[Cont].Nome);
                        Console.WriteLine("E-mail: " + Ag[Cont].Email);
                        Console.WriteLine("Endereço: " + Ag[Cont].Endereco);
                        Console.WriteLine("Cidade: " + Ag[Cont].Cidade);
                        Console.WriteLine("Estado: " + Ag[Cont].Estado);
                        Console.WriteLine("Idade: " + Ag[Cont].Idade);
                    }
                }
            }
        }

        

        static void Menu(Contato[] Ag, ref int Tam)
        {
            int Op;

            do
            {
                Console.Clear(); //Limpa a tela
                Console.WriteLine("****** AGENDA DE CONTATOS ******");
                Console.WriteLine();
                Console.WriteLine("[1] - Cadastrar");
                Console.WriteLine("[2] - Buscar mais velhos do estado desejado");
                Console.WriteLine("[3] - Econtra pessoa mais velha");
                Console.WriteLine("[4] - Imprimir");
                Console.WriteLine("[5] - Sair");
                Console.Write("Opção: ");
                Op = Int32.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Cadastrar(Ag, ref Tam);
                        break;
                    case 2:
                        //maior de 18
                        string estado;
                        Console.Write("Estado: ");
                        estado = Console.ReadLine();
                        BuscaMaioresde18(Ag, estado);

                        break;
                    case 3:
                        int posisao;
                        posisao = EcontraMaisVelha(Ag);

                        Console.WriteLine("Nome: " + Ag[posisao].Nome);
                        Console.WriteLine("E-mail: " + Ag[posisao].Email);
                        Console.WriteLine("Endereço: " + Ag[posisao].Endereco);
                        Console.WriteLine("Cidade: " + Ag[posisao].Cidade);
                        Console.WriteLine("Estado: " + Ag[posisao].Estado);
                        Console.WriteLine("Idade: " + Ag[posisao].Idade);

                        break;
                    case 4:
                        //impressão especial
                        int opcaoImpressao;
                        Console.WriteLine("Escolha sua opção de impressão: ");
                        Console.WriteLine("[1] - Imprimir tudo");
                        Console.WriteLine("[2] - Imprimir Nome e E-mail");
                        Console.Write("Digite sua Opção: ");
                        opcaoImpressao = Int32.Parse(Console.ReadLine());
                        Imprimir(Ag, opcaoImpressao, Tam);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }

                Console.ReadKey(); //Espera pra ver o resultado do processamento

            } while (Op != 5);

        }

        static int EcontraMaisVelha(Contato[] Ag)
        {
            int Maisvelha, Cont, posicao = 0;
            Maisvelha = Ag[0].Idade;

            for (Cont = 0; Cont <= 9; Cont++)
            {
                if (Ag[Cont].Idade > Maisvelha)
                {
                    posicao = Cont;
                }
                
            }
            return posicao;
        }

        static void Cadastrar(Contato[] Ag, ref int Tam)
        {

            Console.Write("Nome: ");
            Ag[Tam].Nome = Console.ReadLine();
             Console.Write("E-Mail: ");
            Ag[Tam].Email = Console.ReadLine();
            Console.Write("Endereço: ");
            Ag[Tam].Endereco = Console.ReadLine();
            Console.Write("cidade: ");
            Ag[Tam].Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            Ag[Tam].Estado = Console.ReadLine();
            Console.Write("Idade: ");
            Ag[Tam].Idade = Int32.Parse(Console.ReadLine());
            ++Tam;
        }

        static void Imprimir(Contato[] Ag, int opcao, int Tam)
        {
            if (opcao == 1)
            {
                int Cont;

                for (Cont = 0; Cont < Tam; Cont++)
                {
                    Console.WriteLine("Nome: " + Ag[Cont].Nome);
                     Console.WriteLine("E-mail: " + Ag[Cont].Email);
                    Console.WriteLine("Endereço: " + Ag[Cont].Endereco);
                    Console.WriteLine("Cidade: " + Ag[Cont].Cidade);
                    Console.WriteLine("Estado: " + Ag[Cont].Estado);
                    Console.WriteLine("Idade: " + Ag[Cont].Idade);

                }
                Console.WriteLine();
            }
            else
            {
                int Cont;

                for (Cont = 0; Cont < Tam; Cont++)
                {
                    Console.WriteLine("Nome: " + Ag[Cont].Nome);
                    Console.WriteLine("E-mail: " + Ag[Cont].Email);
                }

            }
            
        }

        static void Main(string[] args)
        {
            Contato[] Ag = new Contato[10];
            int Tam = 0;

            Menu(Ag, ref Tam);

        }
    }
}