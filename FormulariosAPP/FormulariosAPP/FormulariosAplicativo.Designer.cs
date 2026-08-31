namespace FormulariosAPP
{
    partial class FormulariosAplicativo
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
            this.btnCriaCarro = new System.Windows.Forms.Button();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtautonomia = new System.Windows.Forms.TextBox();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtdistanciapercorrida = new System.Windows.Forms.TextBox();
            this.txtniveldecombustivel = new System.Windows.Forms.TextBox();
            this.txtconsumo = new System.Windows.Forms.TextBox();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.btnCalculaAutomonia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriaCarro
            // 
            this.btnCriaCarro.Location = new System.Drawing.Point(203, 159);
            this.btnCriaCarro.Name = "btnCriaCarro";
            this.btnCriaCarro.Size = new System.Drawing.Size(75, 23);
            this.btnCriaCarro.TabIndex = 0;
            this.btnCriaCarro.Text = "Criar Carro";
            this.btnCriaCarro.UseVisualStyleBackColor = true;
            this.btnCriaCarro.Click += new System.EventHandler(this.btnCriaCarro_Click);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(178, 55);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 1;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // txtautonomia
            // 
            this.txtautonomia.Location = new System.Drawing.Point(178, 368);
            this.txtautonomia.Name = "txtautonomia";
            this.txtautonomia.Size = new System.Drawing.Size(100, 20);
            this.txtautonomia.TabIndex = 2;
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(178, 288);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 20);
            this.txtdistancia.TabIndex = 3;
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(178, 212);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(100, 20);
            this.txtlitros.TabIndex = 4;
            // 
            // txtdistanciapercorrida
            // 
            this.txtdistanciapercorrida.Location = new System.Drawing.Point(178, 133);
            this.txtdistanciapercorrida.Name = "txtdistanciapercorrida";
            this.txtdistanciapercorrida.Size = new System.Drawing.Size(100, 20);
            this.txtdistanciapercorrida.TabIndex = 5;
            // 
            // txtniveldecombustivel
            // 
            this.txtniveldecombustivel.Location = new System.Drawing.Point(178, 107);
            this.txtniveldecombustivel.Name = "txtniveldecombustivel";
            this.txtniveldecombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtniveldecombustivel.TabIndex = 6;
            // 
            // txtconsumo
            // 
            this.txtconsumo.Location = new System.Drawing.Point(178, 81);
            this.txtconsumo.Name = "txtconsumo";
            this.txtconsumo.Size = new System.Drawing.Size(100, 20);
            this.txtconsumo.TabIndex = 7;
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Location = new System.Drawing.Point(203, 238);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(75, 23);
            this.btnAbastecer.TabIndex = 8;
            this.btnAbastecer.Text = "Abastece";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(203, 314);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(75, 23);
            this.btnAndar.TabIndex = 9;
            this.btnAndar.Text = "Anda";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // btnCalculaAutomonia
            // 
            this.btnCalculaAutomonia.Location = new System.Drawing.Point(203, 394);
            this.btnCalculaAutomonia.Name = "btnCalculaAutomonia";
            this.btnCalculaAutomonia.Size = new System.Drawing.Size(75, 23);
            this.btnCalculaAutomonia.TabIndex = 10;
            this.btnCalculaAutomonia.Text = "Autonomia";
            this.btnCalculaAutomonia.UseVisualStyleBackColor = true;
            this.btnCalculaAutomonia.Click += new System.EventHandler(this.btnCalculaAutomonia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modelo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consumo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nivel de Combustível: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Distância Percorrida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Litros: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Distância: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Autonomia: ";
            // 
            // FormulariosAplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculaAutomonia);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnAbastecer);
            this.Controls.Add(this.txtconsumo);
            this.Controls.Add(this.txtniveldecombustivel);
            this.Controls.Add(this.txtdistanciapercorrida);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.txtautonomia);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.btnCriaCarro);
            this.Name = "FormulariosAplicativo";
            this.Text = "Aplicativo de Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriaCarro;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtautonomia;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtdistanciapercorrida;
        private System.Windows.Forms.TextBox txtniveldecombustivel;
        private System.Windows.Forms.TextBox txtconsumo;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button btnCalculaAutomonia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

