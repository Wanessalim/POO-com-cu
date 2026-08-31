namespace Visualizador
{
    partial class Visualizador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizador));
            this.btn_Seleciona = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pb_Imagens = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_Aumenta = new System.Windows.Forms.Button();
            this.btn_Diminui = new System.Windows.Forms.Button();
            this.btn_DesenhaBorda = new System.Windows.Forms.Button();
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_y = new System.Windows.Forms.Label();
            this.bt_Opcoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Seleciona
            // 
            this.btn_Seleciona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Seleciona.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seleciona.Location = new System.Drawing.Point(350, 12);
            this.btn_Seleciona.Name = "btn_Seleciona";
            this.btn_Seleciona.Size = new System.Drawing.Size(182, 54);
            this.btn_Seleciona.TabIndex = 0;
            this.btn_Seleciona.Text = "Selecionar";
            this.btn_Seleciona.UseVisualStyleBackColor = false;
            this.btn_Seleciona.Click += new System.EventHandler(this.btn_Seleciona_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(350, 72);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(182, 46);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pb_Imagens
            // 
            this.pb_Imagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Imagens.BackgroundImage")));
            this.pb_Imagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Imagens.Location = new System.Drawing.Point(8, 8);
            this.pb_Imagens.Name = "pb_Imagens";
            this.pb_Imagens.Size = new System.Drawing.Size(282, 275);
            this.pb_Imagens.TabIndex = 2;
            this.pb_Imagens.TabStop = false;
            this.pb_Imagens.Click += new System.EventHandler(this.pb_Imagens_Click);
            this.pb_Imagens.MouseLeave += new System.EventHandler(this.pb_Imagens_MouseLeave);
            this.pb_Imagens.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Imagens_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_Aumenta
            // 
            this.bt_Aumenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Aumenta.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Aumenta.Location = new System.Drawing.Point(407, 286);
            this.bt_Aumenta.Name = "bt_Aumenta";
            this.bt_Aumenta.Size = new System.Drawing.Size(93, 58);
            this.bt_Aumenta.TabIndex = 3;
            this.bt_Aumenta.Text = "+";
            this.bt_Aumenta.UseVisualStyleBackColor = false;
            this.bt_Aumenta.Click += new System.EventHandler(this.bt_Aumenta_Click);
            // 
            // btn_Diminui
            // 
            this.btn_Diminui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Diminui.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diminui.Location = new System.Drawing.Point(506, 284);
            this.btn_Diminui.Name = "btn_Diminui";
            this.btn_Diminui.Size = new System.Drawing.Size(93, 60);
            this.btn_Diminui.TabIndex = 4;
            this.btn_Diminui.Text = "-";
            this.btn_Diminui.UseVisualStyleBackColor = false;
            this.btn_Diminui.Click += new System.EventHandler(this.btn_Diminui_Click);
            // 
            // btn_DesenhaBorda
            // 
            this.btn_DesenhaBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DesenhaBorda.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DesenhaBorda.Location = new System.Drawing.Point(350, 124);
            this.btn_DesenhaBorda.Name = "btn_DesenhaBorda";
            this.btn_DesenhaBorda.Size = new System.Drawing.Size(182, 46);
            this.btn_DesenhaBorda.TabIndex = 5;
            this.btn_DesenhaBorda.Text = "Borda";
            this.btn_DesenhaBorda.UseVisualStyleBackColor = false;
            this.btn_DesenhaBorda.Click += new System.EventHandler(this.btn_DesenhaBorda_Click);
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(296, 9);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(14, 13);
            this.lb_x.TabIndex = 6;
            this.lb_x.Text = "X";
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Location = new System.Drawing.Point(296, 31);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(14, 13);
            this.lb_y.TabIndex = 7;
            this.lb_y.Text = "Y";
            this.lb_y.Click += new System.EventHandler(this.lb_y_Click);
            // 
            // bt_Opcoes
            // 
            this.bt_Opcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Opcoes.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Opcoes.Location = new System.Drawing.Point(350, 176);
            this.bt_Opcoes.Name = "bt_Opcoes";
            this.bt_Opcoes.Size = new System.Drawing.Size(182, 46);
            this.bt_Opcoes.TabIndex = 8;
            this.bt_Opcoes.Text = "Opções";
            this.bt_Opcoes.UseVisualStyleBackColor = false;
            this.bt_Opcoes.Click += new System.EventHandler(this.bt_Opcoes_Click);
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Visualizador.Properties.Resources.papel_de_parede;
            this.ClientSize = new System.Drawing.Size(611, 356);
            this.Controls.Add(this.bt_Opcoes);
            this.Controls.Add(this.lb_y);
            this.Controls.Add(this.lb_x);
            this.Controls.Add(this.btn_DesenhaBorda);
            this.Controls.Add(this.btn_Diminui);
            this.Controls.Add(this.bt_Aumenta);
            this.Controls.Add(this.pb_Imagens);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_Seleciona);
            this.Name = "Visualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador";
            this.Load += new System.EventHandler(this.Visualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seleciona;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pb_Imagens;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_Aumenta;
        private System.Windows.Forms.Button btn_Diminui;
        private System.Windows.Forms.Button btn_DesenhaBorda;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.Button bt_Opcoes;
    }
}

