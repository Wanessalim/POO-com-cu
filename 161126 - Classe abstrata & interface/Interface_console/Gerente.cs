using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_console
{
    class Gerente: Funcionario, IUsuario
    {
        public double Bonus { get; set; }


        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Gerente(string _senha)
        {
            this.Senha = _senha;
        }

        public bool VerificaSenha()
        {

            return (this.Senha == "12345");
        }
    }
}
