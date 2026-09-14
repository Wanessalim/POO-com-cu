namespace ListaContas
{
    partial class w_Detalhe
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
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.tb_Limite = new System.Windows.Forms.TextBox();
            this.lbl_Limite = new System.Windows.Forms.Label();
            this.btn_Criar = new System.Windows.Forms.Button();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.lb_Lista = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(51, 27);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(86, 25);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código:";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(134, 31);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_Codigo.TabIndex = 1;
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.Location = new System.Drawing.Point(134, 57);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(71, 20);
            this.tb_Saldo.TabIndex = 3;
            this.tb_Saldo.Text = "0";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo.Location = new System.Drawing.Point(51, 52);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(73, 25);
            this.lbl_Saldo.TabIndex = 2;
            this.lbl_Saldo.Text = "Saldo:";
            this.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Limite
            // 
            this.tb_Limite.Location = new System.Drawing.Point(134, 83);
            this.tb_Limite.Name = "tb_Limite";
            this.tb_Limite.Size = new System.Drawing.Size(71, 20);
            this.tb_Limite.TabIndex = 5;
            this.tb_Limite.Text = "0";
            // 
            // lbl_Limite
            // 
            this.lbl_Limite.AutoSize = true;
            this.lbl_Limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Limite.Location = new System.Drawing.Point(51, 79);
            this.lbl_Limite.Name = "lbl_Limite";
            this.lbl_Limite.Size = new System.Drawing.Size(75, 25);
            this.lbl_Limite.TabIndex = 4;
            this.lbl_Limite.Text = "Limite:";
            // 
            // btn_Criar
            // 
            this.btn_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criar.Location = new System.Drawing.Point(47, 118);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(205, 34);
            this.btn_Criar.TabIndex = 6;
            this.btn_Criar.Text = "Criar Conta";
            this.btn_Criar.UseVisualStyleBackColor = true;
            this.btn_Criar.Click += new System.EventHandler(this.btn_Criar_Click);
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depositar.Location = new System.Drawing.Point(485, 57);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(155, 34);
            this.btn_Depositar.TabIndex = 7;
            this.btn_Depositar.Text = "Depositar";
            this.btn_Depositar.UseVisualStyleBackColor = true;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // tb_Valor
            // 
            this.tb_Valor.Location = new System.Drawing.Point(540, 27);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(100, 20);
            this.tb_Valor.TabIndex = 8;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor.Location = new System.Drawing.Point(336, 27);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(198, 25);
            this.lbl_Valor.TabIndex = 9;
            this.lbl_Valor.Text = "Valor da Operação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Consultar);
            this.groupBox2.Controls.Add(this.btn_Sacar);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Location = new System.Drawing.Point(168, 125);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(155, 34);
            this.btn_Consultar.TabIndex = 13;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sacar.Location = new System.Drawing.Point(168, 85);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(155, 34);
            this.btn_Sacar.TabIndex = 12;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // lb_Lista
            // 
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.Location = new System.Drawing.Point(47, 190);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(235, 134);
            this.lb_Lista.TabIndex = 12;
            // 
            // w_Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 338);
            this.Controls.Add(this.lb_Lista);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.tb_Valor);
            this.Controls.Add(this.btn_Depositar);
            this.Controls.Add(this.btn_Criar);
            this.Controls.Add(this.tb_Limite);
            this.Controls.Add(this.lbl_Limite);
            this.Controls.Add(this.tb_Saldo);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "w_Detalhe";
            this.Text = "Dados da Conta";
            this.Load += new System.EventHandler(this.w_ListaContas_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.TextBox tb_Limite;
        private System.Windows.Forms.Label lbl_Limite;
        private System.Windows.Forms.Button btn_Criar;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.ListBox lb_Lista;
    }
}

