namespace Ejercicio_C
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
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.txtmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificador de punto de ebullición del agua";
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnverificar.Location = new System.Drawing.Point(394, 52);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(141, 60);
            this.btnverificar.TabIndex = 1;
            this.btnverificar.Text = "Verificar punto de ebullición";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(17, 122);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(96, 60);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(495, 131);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(85, 60);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese temperatura:";
            // 
            // txttemp
            // 
            this.txttemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttemp.Location = new System.Drawing.Point(200, 62);
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(168, 30);
            this.txttemp.TabIndex = 5;
            // 
            // txtmensaje
            // 
            this.txtmensaje.AutoSize = true;
            this.txtmensaje.Location = new System.Drawing.Point(127, 77);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(0, 13);
            this.txtmensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(600, 203);
            this.ControlBox = false;
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.txttemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.Label txtmensaje;
    }
}

