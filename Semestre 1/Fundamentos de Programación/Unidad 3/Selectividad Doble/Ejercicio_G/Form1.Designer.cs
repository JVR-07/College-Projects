namespace Ejercicio_G
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
            this.label1 = new System.Windows.Forms.Label();
            this.btngen = new System.Windows.Forms.Button();
            this.btnrun = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(255)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para poner en marcha los generadores";
            // 
            // btngen
            // 
            this.btngen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btngen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngen.Location = new System.Drawing.Point(21, 66);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(207, 55);
            this.btngen.TabIndex = 1;
            this.btngen.Text = "Instrucción para el generador";
            this.btngen.UseVisualStyleBackColor = false;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.Location = new System.Drawing.Point(343, 66);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(229, 55);
            this.btnrun.TabIndex = 2;
            this.btnrun.Text = "Poner en marcha el generador";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(151)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(21, 155);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(207, 51);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar instrucción";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(343, 155);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(229, 51);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(593, 239);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio G";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

