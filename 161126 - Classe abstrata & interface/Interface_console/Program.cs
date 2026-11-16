namespace Interface_console
{
    class Program
    {
        public bool Autentica(IUsuario u)
        {
            return (u.VerificaSenha());
        }
        /*
         O método Main é estático (static), enquanto o método Autentica não é estático (ele pertence a
        uma instância/objeto da classe Program).

        No C#, um método static existe antes mesmo de qualquer objeto ser criado na memória. Por isso, ele não enxerga métodos comuns da própria classe diretamente. Se você tentasse chamar Autentica(usuario) direto no Main, o compilador daria erro ("An object reference is required...").

        Ao instanciar Program P = new Program();, você cria o objeto na memória e passa a conseguir chamar P.Autentica(...).

        (Alternativa: se você declarasse public static bool Autentica(Iusuario u), não precisaria criar o new Program()).
         */

        static void Main(string[] args)
        {
            Program P = new Program(); //criando objeto pra usar o método

            Gerente G = new Gerente("12345");
            Empresa E = new Empresa("12345");

            IUsuario U; //Polimorfismo, obs estou dando new no filho, não na interface!!!

            Console.WriteLine("Escolha cadastrar Empresa ou Gerente: ");
            string Escolha = Console.ReadLine();
            if(Escolha == "E")
            {
                U = new Empresa("12345");
            }
            else
            {
                U = new Gerente("12345");
            }
            //implementar método de cadastro ou construtor = Fazido


            if (P.Autentica(E))
            {
                Console.WriteLine("Empresa aprovada");
            }
            else
            {
                Console.WriteLine(P.Autentica(E) + " -Empresa não autorizado");
            }

            if (P.Autentica(G))
            {
                Console.WriteLine("Gerente aprovado");
            }
            else
            {
                Console.WriteLine(P.Autentica(G) + " -Gerente não autorizado");
            }

            Console.WriteLine("Teste polimorfismo: "+P.Autentica(U));
        }
    }
}
