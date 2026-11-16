using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_console
{
    internal class Empresa: Cliente, IUsuario
    {
        public string CNPJ { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Empresa(string _senha)
        {
            this.Senha = _senha;
        }

        public bool VerificaSenha()
        {

            return (this.Senha == "54321");
        }
    }
}
