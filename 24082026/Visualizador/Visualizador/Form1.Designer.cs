namespace Visualizador
{
    partial class Vizualizador_ebaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizador_ebaa));
            this.Btm_Selecionar = new System.Windows.Forms.Button();
            this.Btm_Sair = new System.Windows.Forms.Button();
            this.Pb_Figura = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btm_Diminui = new System.Windows.Forms.Button();
            this.Btm_Aumenta = new System.Windows.Forms.Button();
            this.Btn_DesenhaBorda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Figura)).BeginInit();
            this.SuspendLayout();
            // 
            // Btm_Selecionar
            // 
            this.Btm_Selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btm_Selecionar.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Selecionar.Location = new System.Drawing.Point(359, 8);
            this.Btm_Selecionar.Name = "Btm_Selecionar";
            this.Btm_Selecionar.Size = new System.Drawing.Size(189, 59);
            this.Btm_Selecionar.TabIndex = 0;
            this.Btm_Selecionar.Text = "Selecionar";
            this.Btm_Selecionar.UseVisualStyleBackColor = false;
            this.Btm_Selecionar.Click += new System.EventHandler(this.Btm_Selecionar_Click);
            // 
            // Btm_Sair
            // 
            this.Btm_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btm_Sair.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Sair.Location = new System.Drawing.Point(359, 73);
            this.Btm_Sair.Name = "Btm_Sair";
            this.Btm_Sair.Size = new System.Drawing.Size(189, 59);
            this.Btm_Sair.TabIndex = 1;
            this.Btm_Sair.Text = "Sair...";
            this.Btm_Sair.UseVisualStyleBackColor = false;
            this.Btm_Sair.Click += new System.EventHandler(this.Btm_Sair_Click);
            // 
            // Pb_Figura
            // 
            this.Pb_Figura.Location = new System.Drawing.Point(8, 8);
            this.Pb_Figura.Name = "Pb_Figura";
            this.Pb_Figura.Size = new System.Drawing.Size(282, 275);
            this.Pb_Figura.TabIndex = 2;
            this.Pb_Figura.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btm_Diminui
            // 
            this.Btm_Diminui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btm_Diminui.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Diminui.Location = new System.Drawing.Point(457, 138);
            this.Btm_Diminui.Name = "Btm_Diminui";
            this.Btm_Diminui.Size = new System.Drawing.Size(91, 59);
            this.Btm_Diminui.TabIndex = 3;
            this.Btm_Diminui.Text = "Diminuir";
            this.Btm_Diminui.UseVisualStyleBackColor = false;
            this.Btm_Diminui.Click += new System.EventHandler(this.Btm_Diminui_Click);
            // 
            // Btm_Aumenta
            // 
            this.Btm_Aumenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btm_Aumenta.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Aumenta.Location = new System.Drawing.Point(359, 138);
            this.Btm_Aumenta.Name = "Btm_Aumenta";
            this.Btm_Aumenta.Size = new System.Drawing.Size(90, 59);
            this.Btm_Aumenta.TabIndex = 4;
            this.Btm_Aumenta.Text = "Aumentar";
            this.Btm_Aumenta.UseVisualStyleBackColor = false;
            this.Btm_Aumenta.Click += new System.EventHandler(this.Btm_Aumenta_Click);
            // 
            // Btn_DesenhaBorda
            // 
            this.Btn_DesenhaBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DesenhaBorda.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DesenhaBorda.Location = new System.Drawing.Point(359, 224);
            this.Btn_DesenhaBorda.Name = "Btn_DesenhaBorda";
            this.Btn_DesenhaBorda.Size = new System.Drawing.Size(189, 59);
            this.Btn_DesenhaBorda.TabIndex = 5;
            this.Btn_DesenhaBorda.Text = "DesenhaBorda";
            this.Btn_DesenhaBorda.UseVisualStyleBackColor = false;
            this.Btn_DesenhaBorda.Click += new System.EventHandler(this.Btn_DesenhaBorda_Click);
            // 
            // Vizualizador_ebaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(598, 314);
            this.Controls.Add(this.Btn_DesenhaBorda);
            this.Controls.Add(this.Btm_Aumenta);
            this.Controls.Add(this.Btm_Diminui);
            this.Controls.Add(this.Pb_Figura);
            this.Controls.Add(this.Btm_Sair);
            this.Controls.Add(this.Btm_Selecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vizualizador_ebaa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizador";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Figura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_Selecionar;
        private System.Windows.Forms.Button Btm_Sair;
        private System.Windows.Forms.PictureBox Pb_Figura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btm_Diminui;
        private System.Windows.Forms.Button Btm_Aumenta;
        private System.Windows.Forms.Button Btn_DesenhaBorda;
    }
}

