using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Poo
{
    class Contato
    {
        public string Nome, Email, Endereco, Cidade, Estado;
        public int Idade;

        public void SetContato (string nome, string email, string endereco, string cidade, string estado, int idade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Idade = idade;
            //Serve para preencher ou atualizar todas as informações do objeto
        }

        public Contato GetContato()
        {
            return this;
            //Serve para retornar a própria instância do objeto
        }
    }
}
