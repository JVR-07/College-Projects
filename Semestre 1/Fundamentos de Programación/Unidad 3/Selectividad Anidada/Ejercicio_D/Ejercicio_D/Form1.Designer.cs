namespace Ejercicio_D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtang = new System.Windows.Forms.Label();
            this.btnang = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular cuadrante del eje positivo de X";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(73)))), ((int)(((byte)(1)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click para calcular el cuadrante";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtang
            // 
            this.txtang.AutoSize = true;
            this.txtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(12)))), ((int)(((byte)(177)))));
            this.txtang.Location = new System.Drawing.Point(210, 63);
            this.txtang.Name = "txtang";
            this.txtang.Size = new System.Drawing.Size(294, 22);
            this.txtang.TabIndex = 2;
            this.txtang.Text = "Aquí aparecerá el ángulo ingresado";
            // 
            // btnang
            // 
            this.btnang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(73)))), ((int)(((byte)(1)))));
            this.btnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnang.ForeColor = System.Drawing.Color.White;
            this.btnang.Location = new System.Drawing.Point(12, 57);
            this.btnang.Name = "btnang";
            this.btnang.Size = new System.Drawing.Size(193, 35);
            this.btnang.TabIndex = 3;
            this.btnang.Text = "Click para ingresar ángulo";
            this.btnang.UseVisualStyleBackColor = false;
            this.btnang.Click += new System.EventHandler(this.btnang_Click);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(12)))), ((int)(((byte)(177)))));
            this.txtresult.Location = new System.Drawing.Point(211, 108);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(370, 22);
            this.txtresult.TabIndex = 4;
            this.txtresult.Text = "Aquí aparecerá el cuadrante correspondiente";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(244)))), ((int)(((byte)(196)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(84, 153);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(193, 44);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Click para borrar los datos";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(421, 153);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(160, 44);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Click para salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(620, 228);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnang);
            this.Controls.Add(this.txtang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ejercicio D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtang;
        private System.Windows.Forms.Button btnang;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

