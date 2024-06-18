namespace Problema_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Black;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titulo.Location = new System.Drawing.Point(13, 13);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1210, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = " El prensado de aceituna produce el 36% de su peso en aceite, calcular la cantida" +
    "d de aceite de acuerdo a los kg de aceitunas producidos.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los kilogramos de aceitunas:";
            // 
            // txtkg
            // 
            this.txtkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkg.Location = new System.Drawing.Point(18, 111);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(400, 33);
            this.txtkg.TabIndex = 2;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Gold;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.Black;
            this.calcular.Location = new System.Drawing.Point(504, 62);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(113, 82);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular Aceite";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(636, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "El resultado es:";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultado.Location = new System.Drawing.Point(821, 89);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 29);
            this.resultado.TabIndex = 5;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(1191, 62);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(95, 82);
            this.salir.TabIndex = 6;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(1056, 62);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(104, 82);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1359, 180);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
    }
}

