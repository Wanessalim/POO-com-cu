using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_console
{
    interface IUsuario
    {
        string Usuario { get; set; }
        string Senha { get; set; }
        bool VerificaSenha();
    }
}
