namespace Encapsulamento
{
    partial class w_Detalhe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(119, 167);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(116, 48);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(42, 74);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(71, 25);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Título:";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Titulo.Location = new System.Drawing.Point(119, 71);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(158, 31);
            this.tb_Titulo.TabIndex = 0;
            this.tb_Titulo.TextChanged += new System.EventHandler(this.tb_Titulo_TextChanged);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(119, 28);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.ReadOnly = true;
            this.tb_codigo.Size = new System.Drawing.Size(158, 31);
            this.tb_codigo.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(27, 31);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(86, 25);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Codígo:";
            // 
            // tb_Ano
            // 
            this.tb_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ano.Location = new System.Drawing.Point(119, 114);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(158, 31);
            this.tb_Ano.TabIndex = 4;
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ano.Location = new System.Drawing.Point(57, 114);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(56, 25);
            this.lbl_Ano.TabIndex = 5;
            this.lbl_Ano.Text = "Ano:";
            this.lbl_Ano.Click += new System.EventHandler(this.lbl_Ano_Click);
            // 
            // w_Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(339, 256);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_OK);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "w_Detalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhe do Livro";
            this.Load += new System.EventHandler(this.w_Detalhe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Label lbl_Ano;
    }
}