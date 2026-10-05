namespace HerancaForm
{
    partial class W_Det
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
            this.lbl_Pront = new System.Windows.Forms.Label();
            this.tb_Pront = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.tb_Area = new System.Windows.Forms.TextBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Pront
            // 
            this.lbl_Pront.AutoSize = true;
            this.lbl_Pront.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pront.Location = new System.Drawing.Point(65, 39);
            this.lbl_Pront.Name = "lbl_Pront";
            this.lbl_Pront.Size = new System.Drawing.Size(117, 25);
            this.lbl_Pront.TabIndex = 0;
            this.lbl_Pront.Text = "Prontuário:";
            // 
            // tb_Pront
            // 
            this.tb_Pront.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pront.Location = new System.Drawing.Point(179, 33);
            this.tb_Pront.Name = "tb_Pront";
            this.tb_Pront.ReadOnly = true;
            this.tb_Pront.Size = new System.Drawing.Size(193, 31);
            this.tb_Pront.TabIndex = 1;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.Location = new System.Drawing.Point(179, 70);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(193, 31);
            this.tb_Nome.TabIndex = 3;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(108, 76);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(74, 25);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_Area
            // 
            this.tb_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Area.Location = new System.Drawing.Point(179, 107);
            this.tb_Area.Name = "tb_Area";
            this.tb_Area.Size = new System.Drawing.Size(193, 31);
            this.tb_Area.TabIndex = 5;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Area.Location = new System.Drawing.Point(119, 113);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(63, 25);
            this.lbl_Area.TabIndex = 4;
            this.lbl_Area.Text = "Área:";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(70, 177);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(145, 43);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(232, 177);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 43);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // W_Det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 253);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_Area);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.tb_Pront);
            this.Controls.Add(this.lbl_Pront);
            this.Name = "W_Det";
            this.Text = "Detalhes do ";
            this.Load += new System.EventHandler(this.W_Det_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Pront;
        private System.Windows.Forms.TextBox tb_Pront;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox tb_Area;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}