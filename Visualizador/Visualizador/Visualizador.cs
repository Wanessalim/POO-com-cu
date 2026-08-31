using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador
{
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Seleciona_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Imagens.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void pb_Imagens_Click(object sender, EventArgs e)
        {

        }

        private void bt_Aumenta_Click(object sender, EventArgs e)
        {
            this.Width = this.Width*2;
            this.Height = this.Height*2;
        }

        private void btn_Diminui_Click(object sender, EventArgs e)
        {
            this.Width = this.Width/2;
            this.Height = this.Height/2;
        }

        private void btn_DesenhaBorda_Click(object sender, EventArgs e)
        {
            Graphics objGraphic = null;
            objGraphic = this.CreateGraphics();
            objGraphic.Clear(SystemColors.Control); //deixa o fundo cinza
            objGraphic.DrawRectangle(Pens.DarkMagenta, pb_Imagens.Left - 1, pb_Imagens.Top - 1,pb_Imagens.Width + 1, pb_Imagens.Height + 1);
            objGraphic.Dispose();
        }

        private void lb_y_Click(object sender, EventArgs e)
        {

        }

        private void pb_Imagens_MouseMove(object sender, MouseEventArgs e)
        {
            lb_x.Text = "X: " + e.X.ToString(); 
            lb_y.Text = "Y: " + e.Y.ToString();
        }

        private void pb_Imagens_MouseLeave(object sender, EventArgs e)
        {
            lb_x.Text = "";
            lb_y.Text = "";
        }

        private void Visualizador_Load(object sender, EventArgs e)
        {
            lb_x.Text = "";
            lb_y.Text = "";
        }

        private void bt_Opcoes_Click(object sender, EventArgs e)
        {
            OpcoesForm frmOptionsDialog = new OpcoesForm();
            frmOptionsDialog.ShowDialog();
        }
    }
}
