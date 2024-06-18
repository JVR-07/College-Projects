namespace Ejercicio_F
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnprueba = new System.Windows.Forms.Button();
            this.txtvolt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(81)))), ((int)(((byte)(249)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(269, 93);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 51);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(132)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(146, 93);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(117, 51);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Nuevo voltaje";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnprueba
            // 
            this.btnprueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.btnprueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprueba.Location = new System.Drawing.Point(12, 93);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(128, 51);
            this.btnprueba.TabIndex = 9;
            this.btnprueba.Text = "Hacer prueba de voltaje";
            this.btnprueba.UseVisualStyleBackColor = false;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // txtvolt
            // 
            this.txtvolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolt.Location = new System.Drawing.Point(182, 54);
            this.txtvolt.Name = "txtvolt";
            this.txtvolt.Size = new System.Drawing.Size(123, 30);
            this.txtvolt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese el voltaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(253)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prueba de aislamiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(362, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnprueba);
            this.Controls.Add(this.txtvolt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnprueba;
        private System.Windows.Forms.TextBox txtvolt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

