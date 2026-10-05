using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaForm
{
    public partial class W_Lista : Form
    {
        List<IFSP> Lista = new List<IFSP>();
        public W_Lista()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void W_Lista_Load(object sender, EventArgs e)
        {
            Lista.Add(new Professor());
            Lista.Add(new Aluno());

            (Lista[0] as Professor).Gravar("Valtemir", "Informatica", 1000);
            (Lista[1] as Aluno).Gravar("Lucy", "Informatica", 10);

            this.Atualizar();
        }

        public void Atualizar()
        {
            Lb_Lista.Items.Clear();
            foreach(IFSP U in Lista)
            {
                Lb_Lista.Items.Add(U.ToString());
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.Editar("A");
        }

        public void Editar(string Op) //A - adiciona, E- editar
        {
            IFSP U;
            if(Op == "A")
            {
                if (rb_Professor.Checked)
                {
                   U = new Professor();
                }
                else
                {
                   U = new Aluno();
                }
            }
            else
            {
                if(Lb_Lista.SelectedIndex >= 0)
                {
                    U = this.Lista[Lb_Lista.SelectedIndex];
                }
                else
                {
                    U = null;
                }
            }
            if(U != null)
            {
                W_Det w_detalhe = new W_Det(U);
                w_detalhe.ShowDialog();
                if (U.Nome != "")
                {
                    if(Op == "A")
                    {
                        this.Lista.Add(U);
                    }
                    this.Atualizar();
                }
            }

        }

        private void Lb_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Editar("E");
        }
    }
}
