using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaClasses
{
    public class TestaClasses
    {
        static void Main(string[] args)
        {
            
                 //criando um objeto do tipo Aluno
                 Aluno Al1 = new Aluno();

                 //Lucyneide
                Al1.Nome = "Lucy";
                Al1.Rg = "123.456.78-9";
                Al1.DataDeNascimento = "04/05/2021";

                //Pedrinho malvadeza
                Aluno Al2 = new Aluno();

                Al2.Nome = "Pedrinho";
                Al2.Rg = "987.654.32-1";
                Al2.DataDeNascimento = "01/05/2005";

                //imprimindo os dados do aluno 1
                Console.WriteLine("-----Alunos-----");

                Console.WriteLine("Aluno 1:");
                Console.WriteLine("Nome: " + Al1.Nome);
                Console.WriteLine("RG: " + Al1.Rg);
                Console.WriteLine("Data de Nascimento: " + Al1.DataDeNascimento);

                //imprimindo os dados do aluno 2

                Console.WriteLine("\nAluno 2:");
                Console.WriteLine("Nome: " + Al2.Nome);
                Console.WriteLine("RG: " + Al2.Rg);
                Console.WriteLine("Data de Nascimento: " + Al2.DataDeNascimento);

                //criando funcionarios
                Funcionarios F1 = new Funcionarios();

                F1.Nome = "Valtemir";
                F1.Cargo = "Professor";
                F1.Salario = 1000.0;

                Funcionarios F2 = new Funcionarios();
                F2.Nome = "Lívia";
                F2.Cargo = "Professora";
                F2.Salario = 1000.0;

                 Console.WriteLine("-----Funcionários-----");
                //imprimindo os dados do funcionário 1
                Console.WriteLine("\nFuncionário 1:");
                Console.WriteLine("Salario: " + F1.Salario);
                Console.WriteLine();
                F1.AumentarSalario(50);

                //imprimindo os dados do funcionário 2
                Console.WriteLine("\nFuncionário 2:");
                Console.WriteLine("Salario: " + F2.Salario);
                F2.AumentarSalario(50);
                Console.WriteLine();

                F1.ExibirDados();
                F2.ExibirDados();

                Turma T1 = new Turma();
                T1.Periodo = "Vespertino";
                T1.Serie = "5ª Série";
                T1.Sigla = "BRI67";
                T1.Tipo_Ensino = "Fundamental";

                Turma T2 = new Turma();
                T2.Periodo = "Matutino";
                T2.Serie = "6ª Série";
                T2.Sigla = "BRI68";
                T2.Tipo_Ensino = "Fundamental";

                Console.WriteLine("-----Turmas-----");

                //imprimindo os dados da turma 1
                Console.WriteLine("\nTurma 1:");
                Console.WriteLine("Período: " + T1.Periodo);
                Console.WriteLine("Série: " + T1.Serie);
                Console.WriteLine("Sigla: " + T1.Sigla);
                Console.WriteLine("Tipo de Ensino: " + T1.Tipo_Ensino);

                //imprimindo os dados da turma 2
                Console.WriteLine("\nTurma 2:");
                Console.WriteLine("Período: " + T2.Periodo);
                Console.WriteLine("Série: " + T2.Serie);
                Console.WriteLine("Sigla: " + T2.Sigla);
                Console.WriteLine("Tipo de Ensino: " + T2.Tipo_Ensino);
            
                
                
            /*-----Dominio Banco -----*/
            Conta C1 = new Conta();
            Console.Write("Número: ");
            C1.Numero = Int32.Parse(Console.ReadLine());
            Console.Write("Saldo: ");
            C1.Saldo = Double.Parse(Console.ReadLine());
            Console.Write("Limite: ");
            C1.Limite = Double.Parse(Console.ReadLine());

            int Opcao = 0;

            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("[1]. Depositar");
                Console.WriteLine("[2]. Sacar");
                Console.WriteLine("[3]. Exibir Saldo");
                Console.WriteLine("[4]. Sair");
                Opcao = Int32.Parse(Console.ReadLine());
                switch (Opcao)
                {
                    case 1:
                        Console.Write("Digite o valor a ser depositado: ");
                        double valorDeposito = Double.Parse(Console.ReadLine());
                        C1.Depositar(valorDeposito);
                        break;
                    case 2:
                        Console.Write("Digite o valor a ser sacado: ");
                        double valorSaque = Double.Parse(Console.ReadLine());
                        C1.Sacar(valorSaque);
                        break;
                    case 3:
                        C1.ExibirSaldo();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (Opcao != 4);

            
            
        }
    }
}
