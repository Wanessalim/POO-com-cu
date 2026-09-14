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
    public partial class w_Detalhe: Form
    {
        List<Conta> Lista;//= new List<Conta>();

        public w_Detalhe(List<Conta> L):this()
        {
            this.Lista = L;
        }
        public w_Detalhe()
        {
            InitializeComponent();
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            if (this.ValidaCampos())
            {
                Lista.Add(new Conta(tb_Codigo.Text, Convert.ToDouble(tb_Saldo.Text), Double.Parse(tb_Limite.Text)));

                lb_Lista.Items.Add(tb_Codigo.Text + " - "+ tb_Saldo.Text);

                
                
                if (Lista[Lista.Count-1] != null)
                {
                    MessageBox.Show("Conta criada com sucesso!!");
                }
            }

        }

        private void w_ListaContas_Load(object sender, EventArgs e)
        {

        }

        public bool ValidaCampos()
        {
            bool Ret = true;

            if (tb_Codigo.Text == "" || tb_Saldo.Text == "" || tb_Limite.Text == "")
            {
                Ret = false;
                MessageBox.Show("Preencha os campos corretamente!!");
            }

            return Ret;
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            if (tb_Valor.Text != "")
            {
                if (Lista[Lista.Count - 1] != null)
                {
                    Lista[Lista.Count - 1].Depositar(Double.Parse(tb_Valor.Text));
                    MessageBox.Show("Saldo atualizado!!");
                    this.AtualizaCampos(Lista[Lista.Count - 1]);
                }
                else
                {
                    MessageBox.Show("Conta inválida!!");
                }
            }
            else
            {
                MessageBox.Show("Forneça um valor válido!!");
            }
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            if (tb_Valor.Text != "")
            {
                if (Lista[Lista.Count - 1] != null)
                {
                    Lista[Lista.Count - 1].Sacar(Double.Parse(tb_Valor.Text));
                    MessageBox.Show("Saldo atualizado!!");
                    this.AtualizaCampos(Lista[Lista.Count - 1]);
                }
                else
                {
                    MessageBox.Show("Conta inválida!!");
                }
            }
            else
            {
                MessageBox.Show("Forneça um valor válido!!");
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            
            foreach (Conta C in Lista)
            {
                MessageBox.Show("Código: " + C.GetCodigo() + " Saldo: " + C.GetSaldo() + " Limite: " + C.GetLimite());
            }

   
        }

        public void AtualizaCampos(Conta C)
        {
            if (C != null)
            {
                tb_Codigo.Text = C.GetCodigo();
                tb_Saldo.Text = C.GetSaldo().ToString();
                tb_Limite.Text = C.GetLimite().ToString();
                tb_Valor.Text = "0";
            }
            
        }
    }
}
