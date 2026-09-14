using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public class Livro
    {
        static int Id = 0;
        string titulo="";
        public string Titulo
        {
            get
            {
                return this.titulo;
            }

            set
            {
                if (value != "")
                {
                    this.titulo = value;
                }
                else
                {
                    MessageBox.Show("Título não preenchido!!", "AVISO!!!");
                }

            }
        }
        public int Codigo { get; private set; }

        //todos os atributos são privados no encapisulamento
        int ano; //atributo == letra minuscula.
        //atributos privados são alterados ou mostrados por métodos.
        public string Ano
        {
            get //acesso de leitura do campo privado.
            {
                return this.ano.ToString();
            }

            set 
            {
                int resultado;

                if (int.TryParse(value, out resultado) && resultado <= DateTime.Now.Year)
                {
                    this.ano = resultado;
                }
                else
                {
                    MessageBox.Show("Ano invalído!", "ERRO 001");
                }
            }
        }

        public Livro()
        {
            this.Codigo = Livro.GeraId();
        }

        static int GeraId()
        {
            return ++Livro.Id;
        }

        
        
    }
}
