namespace Problema_2
{
    partial class Form1
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
            this.titulo = new System.Windows.Forms.Label();
            this.txtcata = new System.Windows.Forms.Label();
            this.txtcatb = new System.Windows.Forms.Label();
            this.cata = new System.Windows.Forms.TextBox();
            this.catb = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.SlateBlue;
            this.titulo.Location = new System.Drawing.Point(182, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(429, 39);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "--> Calcular hipotenusa <--";
            // 
            // txtcata
            // 
            this.txtcata.AutoSize = true;
            this.txtcata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcata.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtcata.Location = new System.Drawing.Point(12, 73);
            this.txtcata.Name = "txtcata";
            this.txtcata.Size = new System.Drawing.Size(248, 31);
            this.txtcata.TabIndex = 1;
            this.txtcata.Text = "Ingrese el cateto A:";
            // 
            // txtcatb
            // 
            this.txtcatb.AutoSize = true;
            this.txtcatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatb.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtcatb.Location = new System.Drawing.Point(12, 149);
            this.txtcatb.Name = "txtcatb";
            this.txtcatb.Size = new System.Drawing.Size(248, 31);
            this.txtcatb.TabIndex = 2;
            this.txtcatb.Text = "Ingrese el cateto B:";
            // 
            // cata
            // 
            this.cata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cata.Location = new System.Drawing.Point(283, 73);
            this.cata.Name = "cata";
            this.cata.Size = new System.Drawing.Size(328, 38);
            this.cata.TabIndex = 3;
            // 
            // catb
            // 
            this.catb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catb.Location = new System.Drawing.Point(283, 149);
            this.catb.Name = "catb";
            this.catb.Size = new System.Drawing.Size(328, 38);
            this.catb.TabIndex = 4;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(673, 138);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(122, 59);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar calculadora";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Red;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.Black;
            this.calcular.Location = new System.Drawing.Point(673, 61);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(122, 61);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular Hipotenusa";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Gold;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(673, 215);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(122, 37);
            this.salir.TabIndex = 7;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(183, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "El resultado es:";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Resultado.Location = new System.Drawing.Point(182, 255);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(358, 39);
            this.Resultado.TabIndex = 10;
            this.Resultado.Text = "Esperando resultado...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(813, 321);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.catb);
            this.Controls.Add(this.cata);
            this.Controls.Add(this.txtcatb);
            this.Controls.Add(this.txtcata);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label txtcata;
        private System.Windows.Forms.Label txtcatb;
        private System.Windows.Forms.TextBox cata;
        private System.Windows.Forms.TextBox catb;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultado;
    }
}

