namespace Problema_8
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
            this.mostrar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(911, 32);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Querido usuario, ¿Desea conocer el nombre del apuesto programador?";
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.Color.Green;
            this.mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(18, 58);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(327, 81);
            this.mostrar.TabIndex = 1;
            this.mostrar.Text = "Sí, muéstrame el nombre";
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(216, 175);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(446, 36);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "--> Aquí aparecerá el nombre <--";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.DarkRed;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(529, 58);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(382, 81);
            this.salir.TabIndex = 3;
            this.salir.Text = "No, quiero cerrar el programa";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(923, 248);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button salir;
    }
}

