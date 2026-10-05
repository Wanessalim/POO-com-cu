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
    public partial class W_Det : Form
    {
        IFSP Usuario;
        public W_Det()
        {
            InitializeComponent();
        }
        
        public W_Det(IFSP Us): this()
        {
            this.Usuario = Us;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Gravar(tb_Nome.Text, tb_Area.Text);
            this.Close();
        }

        private void W_Det_Load(object sender, EventArgs e)
        {
            tb_Pront.Text = this.Usuario.Prontuario;
            tb_Nome.Text = this.Usuario.Nome;
            tb_Area.Text = this.Usuario.Area;
        }
        public void Gravar(string Nome, string Area)
        {
            this.Usuario.Gravar(Nome, Area);
        }
    }
}
