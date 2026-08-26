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
    public partial class Vizualizador_ebaa : Form
    {
        public Vizualizador_ebaa()
        {
            InitializeComponent();
        }

        private void Btm_Selecionar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pb_Figura.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Btm_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btm_Aumenta_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 20;
            this.Height = this.Height + 20;
        }

        private void Btm_Diminui_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 20;
            this.Height = this.Height - 20;
        }

        private void Btn_DesenhaBorda_Click(object sender, EventArgs e)
        {
            Graphics objGraphics = null; //manterá uma instância de um objeto
            objGraphics = this.CreateGraphics(); //cria o objeto gráfico
            objGraphics.Clear(SystemColors.Control); //Limpa tela 
            objGraphics.DrawRectangle(Pens.Blue, Pb_Figura.Left - 1, Pb_Figura.Top - 1,Pb_Figura.Width + 1, Pb_Figura.Height + 1); //desenha a borda
            objGraphics.Dispose(); //libera o objeto gráfico
        }
    }
}
