namespace HerancaForm
{
    partial class W_Lista
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
            this.Lb_Lista = new System.Windows.Forms.ListBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.rb_Professor = new System.Windows.Forms.RadioButton();
            this.rb_Aluno = new System.Windows.Forms.RadioButton();
            this.GB_ProfessorouAluno = new System.Windows.Forms.GroupBox();
            this.GB_ProfessorouAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Lista
            // 
            this.Lb_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Lista.FormattingEnabled = true;
            this.Lb_Lista.ItemHeight = 25;
            this.Lb_Lista.Location = new System.Drawing.Point(33, 30);
            this.Lb_Lista.Name = "Lb_Lista";
            this.Lb_Lista.Size = new System.Drawing.Size(564, 379);
            this.Lb_Lista.TabIndex = 0;
            this.Lb_Lista.SelectedIndexChanged += new System.EventHandler(this.Lb_Lista_SelectedIndexChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(603, 293);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(138, 55);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(603, 354);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(138, 55);
            this.Btn_Fechar.TabIndex = 2;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // rb_Professor
            // 
            this.rb_Professor.AutoSize = true;
            this.rb_Professor.Checked = true;
            this.rb_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Professor.Location = new System.Drawing.Point(6, 19);
            this.rb_Professor.Name = "rb_Professor";
            this.rb_Professor.Size = new System.Drawing.Size(122, 29);
            this.rb_Professor.TabIndex = 3;
            this.rb_Professor.TabStop = true;
            this.rb_Professor.Text = "Professor";
            this.rb_Professor.UseVisualStyleBackColor = true;
            // 
            // rb_Aluno
            // 
            this.rb_Aluno.AutoSize = true;
            this.rb_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Aluno.Location = new System.Drawing.Point(6, 48);
            this.rb_Aluno.Name = "rb_Aluno";
            this.rb_Aluno.Size = new System.Drawing.Size(85, 29);
            this.rb_Aluno.TabIndex = 4;
            this.rb_Aluno.TabStop = true;
            this.rb_Aluno.Text = "Aluno";
            this.rb_Aluno.UseVisualStyleBackColor = true;
            // 
            // GB_ProfessorouAluno
            // 
            this.GB_ProfessorouAluno.Controls.Add(this.rb_Aluno);
            this.GB_ProfessorouAluno.Controls.Add(this.rb_Professor);
            this.GB_ProfessorouAluno.Location = new System.Drawing.Point(603, 30);
            this.GB_ProfessorouAluno.Name = "GB_ProfessorouAluno";
            this.GB_ProfessorouAluno.Size = new System.Drawing.Size(150, 83);
            this.GB_ProfessorouAluno.TabIndex = 5;
            this.GB_ProfessorouAluno.TabStop = false;
            this.GB_ProfessorouAluno.Text = "Tipo";
            // 
            // W_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.GB_ProfessorouAluno);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lb_Lista);
            this.Name = "W_Lista";
            this.Text = "Usuarios IFSP";
            this.Load += new System.EventHandler(this.W_Lista_Load);
            this.GB_ProfessorouAluno.ResumeLayout(false);
            this.GB_ProfessorouAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Lista;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.RadioButton rb_Professor;
        private System.Windows.Forms.RadioButton rb_Aluno;
        private System.Windows.Forms.GroupBox GB_ProfessorouAluno;
    }
}

