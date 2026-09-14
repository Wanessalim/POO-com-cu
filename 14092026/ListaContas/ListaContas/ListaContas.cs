using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContas
{
    public partial class w_Lista: Form
    {
        List<Conta> Lista = new List<Conta>();
        public w_Lista()
        {
            InitializeComponent();
        }

        private void ListaContas_Load(object sender, EventArgs e)
        {

        }

        public void AtualizaLista()
        {
            lb_Lista.Items.Clear();

            foreach (Conta C in Lista)
            {
                lb_Lista.Items.Add(C.GetCodigo() + " - " + C.GetSaldo().ToString());
            }
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            w_Detalhe w_Det = new w_Detalhe(Lista);

            w_Det.ShowDialog();
            this.AtualizaLista();
        }
    }
}
