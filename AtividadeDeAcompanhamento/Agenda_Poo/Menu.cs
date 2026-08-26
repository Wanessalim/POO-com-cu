using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Poo
{
    class Menu
    {
        public void Cadastrar(List<Contato> contatos)
        {
            Contato contato = new Contato();
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();
            Console.Write("Digite o endereço do contato: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite a cidade do contato: ");
            string cidade = Console.ReadLine();
            Console.Write("Digite o estado do contato: ");
            string estado = Console.ReadLine();
            Console.Write("Digite a idade do contato: ");
            int idade = int.Parse(Console.ReadLine());
            contato.SetContato(nome, email, endereco, cidade, estado, idade);
            contatos.Add(contato);
        }

        //neste Metódo eu imprimo os dados do contato, caso o usuário queira imprimir apenas o nome e email, ele pode passar o parâmetro Parcial como true, caso contrário, ele pode passar como false para imprimir todos os dados do contato.
        public void Imprimir(Contato contato, bool Parcial)
        {
            Console.WriteLine("=== Dados do Contato ===");
            
                Console.WriteLine($"Nome: {contato.Nome}");
                Console.WriteLine($"Email: {contato.Email}");
                if(!Parcial)
                {
                    Console.WriteLine($"Endereço: {contato.Endereco}");
                    Console.WriteLine($"Cidade: {contato.Cidade}");
                    Console.WriteLine($"Estado: {contato.Estado}");
                    Console.WriteLine($"Idade: {contato.Idade}");
                }
            Console.WriteLine("-------------------------");
        }
        //agora eu criei um metódo para imprimir todos os meus contatos, ele vai percorrer a lista de contatos e imprimir todos os dados de cada contato, caso o usuário queira imprimir apenas o nome e email, ele pode passar o parâmetro Parcial como true, caso contrário, ele pode passar como false para imprimir todos os dados do contato. Usando sobrecarga de metódo, eu criei um metódo Imprimir que recebe uma lista de contatos e um parâmetro Parcial, e outro metódo Imprimir que recebe apenas um contato e um parâmetro Parcial.
        public void Imprimir(List<Contato> contatos, bool Parcial)
        {
            foreach (Contato contato in contatos)
            {
                this.Imprimir(contato, Parcial);
            }
        }

        public void Imprimir(List<Contato> contatos, int idade, string estado)
        {
            foreach (Contato contato in contatos)
            {
                if (contato.Idade >= idade && contato.Estado == estado)
                {
                    this.Imprimir(contato, true);
                }
            }
        }

        public Contato BuscaMaisVelho(List<Contato> contatos)
        {
            Contato MaisVelho = null;
            int IdadeMaisVelho = 0;
            
                foreach (Contato contato in contatos)
                {
                    if (contato.Idade > IdadeMaisVelho)
                    {
                        IdadeMaisVelho = contato.Idade;
                        MaisVelho = contato;
                    }
                }

            return MaisVelho;
        }

        public void ExibirMenu(List<Contato> contatos)
        {
            int Opcao = 0, OpcaoImpressao;
            Contato C;

            do
            {
                Console.Clear();//limpa tela
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("[1]. Adicionar Contato");
                Console.WriteLine("[2].Buscar adulto por estado");
                Console.WriteLine("[3].Buscar pessoa mais velha");
                Console.WriteLine("[4]. Impressão");
                Console.WriteLine("[5]. Sair");
                Console.Write("Escolha uma opção: ");
                Opcao = int.Parse(Console.ReadLine());
                switch (Opcao)
                {
                    case 1:
                        Cadastrar(contatos);
                        break;
                    case 2:
                        //Buscar adulto por estado
                        Console.WriteLine("Escolha o Estado: ");
                        string estado = Console.ReadLine();
                        this.Imprimir(contatos, 18, estado);
                        break;
                    case 3:
                        //Buscar pessoa mais velha
                        C = this.BuscaMaisVelho(contatos);
                        this.Imprimir(C, false);
                        break;
                    case 4:
                        //aqui temos que fazer a interface pro usuario escolher o tipo de impressao, parcial ou total
                        Console.WriteLine("Escolha o tipo de impressão: ");
                        Console.WriteLine("[1]. Parcial");
                        Console.WriteLine("[2]. Total");
                        OpcaoImpressao = int.Parse(Console.ReadLine());
                        if(OpcaoImpressao == 1)
                        {
                            this.Imprimir(contatos, true);
                        }
                        else
                        {
                            this.Imprimir(contatos, false);
                        }
                        Console.ReadLine();
                        break;

                }
            } while (Opcao != 5);
            
        }
    }
}
