﻿namespace Ejercicio_1
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
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.convertir = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(561, 222);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 51);
            this.salir.TabIndex = 15;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(303, 222);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(126, 67);
            this.limpiar.TabIndex = 14;
            this.limpiar.Text = "Limpiar cálculo";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // convertir
            // 
            this.convertir.BackColor = System.Drawing.Color.SlateBlue;
            this.convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertir.ForeColor = System.Drawing.Color.Black;
            this.convertir.Location = new System.Drawing.Point(59, 222);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(123, 51);
            this.convertir.TabIndex = 13;
            this.convertir.Text = "Convertir";
            this.convertir.UseVisualStyleBackColor = false;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(0)))), ((int)(((byte)(242)))));
            this.resultado.Location = new System.Drawing.Point(334, 160);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(255, 29);
            this.resultado.TabIndex = 12;
            this.resultado.Text = "Esperando resultado...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Los grados Celsius son: ";
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.Location = new System.Drawing.Point(394, 96);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(295, 30);
            this.txtF.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese los grados Farenheit:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Sitka Banner", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(30, 23);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(659, 52);
            this.titulo.TabIndex = 8;
            this.titulo.Text = "Convertor de grados Farenheit a grados Celsius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(105)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(733, 359);
            this.ControlBox = false;
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.convertir);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Ejercicio 1 Try-Catch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button convertir;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
    }
}

