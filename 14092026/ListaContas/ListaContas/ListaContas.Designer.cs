namespace ListaContas
{
    partial class w_Lista
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
            this.lb_Lista = new System.Windows.Forms.ListBox();
            this.btn_Criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Lista
            // 
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.Location = new System.Drawing.Point(12, 26);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(235, 251);
            this.lb_Lista.TabIndex = 13;
            // 
            // btn_Criar
            // 
            this.btn_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criar.Location = new System.Drawing.Point(273, 26);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(205, 34);
            this.btn_Criar.TabIndex = 14;
            this.btn_Criar.Text = "Criar Conta";
            this.btn_Criar.UseVisualStyleBackColor = true;
            this.btn_Criar.Click += new System.EventHandler(this.btn_Criar_Click);
            // 
            // w_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.btn_Criar);
            this.Controls.Add(this.lb_Lista);
            this.Name = "w_Lista";
            this.Text = "ListaContas";
            this.Load += new System.EventHandler(this.ListaContas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Lista;
        private System.Windows.Forms.Button btn_Criar;
    }
}