namespace Ejercicio_3
{
    partial class miforma
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
            this.txtresult = new System.Windows.Forms.Label();
            this.btnresultado = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.Label();
            this.btnedad = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.Label();
            this.btnname = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(342, 277);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(123, 57);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Click para salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(34, 277);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(160, 57);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Click para limpiar datos";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(164, 225);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(230, 22);
            this.txtresult.TabIndex = 15;
            this.txtresult.Text = "Aquí aparecerá el resultado";
            // 
            // btnresultado
            // 
            this.btnresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(34, 207);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(124, 57);
            this.btnresultado.TabIndex = 14;
            this.btnresultado.Text = "Realizar registro";
            this.btnresultado.UseVisualStyleBackColor = false;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // txtage
            // 
            this.txtage.AutoSize = true;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(164, 162);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(196, 22);
            this.txtage.TabIndex = 13;
            this.txtage.Text = "Aquí aparecerá la edad";
            // 
            // btnedad
            // 
            this.btnedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedad.Location = new System.Drawing.Point(34, 144);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(124, 57);
            this.btnedad.TabIndex = 12;
            this.btnedad.Text = "Click para ingresar edad";
            this.btnedad.UseVisualStyleBackColor = false;
            this.btnedad.Click += new System.EventHandler(this.btnedad_Click);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(164, 96);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 22);
            this.txtname.TabIndex = 11;
            this.txtname.Text = "Aquí aparecerá el nombre";
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnname.Location = new System.Drawing.Point(34, 74);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(124, 64);
            this.btnname.TabIndex = 10;
            this.btnname.Text = "Click para ingresar nombre";
            this.btnname.UseVisualStyleBackColor = false;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Convocatoria para participar en evento";
            // 
            // miforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1060, 355);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.btnedad);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.label1);
            this.Name = "miforma";
            this.Text = "Ejercicio 3 de Selectividad Intenta";
            this.Load += new System.EventHandler(this.miforma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Label txtage;
        private System.Windows.Forms.Button btnedad;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Label label1;
    }
}

