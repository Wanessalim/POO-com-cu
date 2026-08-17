using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigotop
{
    //menu, interface, controle etc...

    class Menu
    {

        public void Cadastrar(List<Contato> Ag)
        {
            Ag.Add(new Contato()); //Composição (se eu mato agenda mato os contatos tbm)
            Console.Write("Nome: ");
            Ag[Ag.Count - 1].Nome = Console.ReadLine();
            Console.Write("E-Mail: ");
            Ag[Ag.Count - 1].Email = Console.ReadLine();
            Console.Write("Estado: ");
            Ag[Ag.Count - 1].Estado = Console.ReadLine();
            Console.Write("Idade: ");
            Ag[Ag.Count - 1].Idade = Int32.Parse(Console.ReadLine());
        }

        public void Imprimir(Contato C, bool Parcial)
        {
            Console.WriteLine("Nome: " + C.Nome);
            Console.WriteLine(" E-mail: " + C.Email);
            if (!Parcial)
            {
                Console.WriteLine(" Estado: " + C.Estado);
                Console.WriteLine(" Idade: " + C.Idade);
            }
            Console.WriteLine();
        }

        

        public void Imprimir(List<Contato> Ag, bool Parcial)
        {
            /*
            int Cont;
            for (Cont = 0; Cont < Tam; Cont++)
            {
                Imprimir(Ag, Cont, Parcial);
            }
            Console.WriteLine();
          */
            foreach (Contato C in Ag) //pra que serve foreach
            {
                this.Imprimir(C , Parcial); //na internet não usam o this.
                //NÃO É RECURSÃO É SOBRECARGA(não preciso mudar nome hihihihi(presta atenção nisso!))
            }
            Console.WriteLine();
        }

        public void MostrarMenu(List<Contato> Ag) //não pode ser estatíco - medoto estatico não entende o this (new)
        {
            int Op, OpImp, Pos = 0;
            string Estado;
            Contato C;
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
                        this.Cadastrar(Ag);
                        break;
                    case 2:
                        Console.Write("Qual Estado: ");
                        Estado = Console.ReadLine();
                        //this.Imprimir(Ag, 18, Estado);
                        break;
                    case 3:
                        //vai me obrigar a imprimir so uma pessoa - um registro
                        //Pos = BuscarMaisVelho(Ag, Tam);
                        if (Pos >= 0) //posição válida!!
                        {
                            //this.Imprimir(C, false);
                        }
                        break;
                    case 4:
                        Console.Write("1 - Total / 2 - Parcial: ");
                        OpImp = Int32.Parse(Console.ReadLine());
                        this.Imprimir(Ag, OpImp == 2);
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

        //sobrecarga pode ser com o retorno ou parametros :)
    }
}
