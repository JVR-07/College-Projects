namespace Ejercicio_C
{
    partial class frmFormaC
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
            this.btnname = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.Label();
            this.btnedad = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.Label();
            this.btnresultado = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convocatoria para participar en evento";
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnname.Location = new System.Drawing.Point(23, 71);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(124, 64);
            this.btnname.TabIndex = 1;
            this.btnname.Text = "Click para ingresar nombre";
            this.btnname.UseVisualStyleBackColor = false;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(153, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 22);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Aquí aparecerá el nombre";
            // 
            // txtage
            // 
            this.txtage.AutoSize = true;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(153, 159);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(196, 22);
            this.txtage.TabIndex = 4;
            this.txtage.Text = "Aquí aparecerá la edad";
            // 
            // btnedad
            // 
            this.btnedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedad.Location = new System.Drawing.Point(23, 141);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(124, 57);
            this.btnedad.TabIndex = 3;
            this.btnedad.Text = "Click para ingresar edad";
            this.btnedad.UseVisualStyleBackColor = false;
            this.btnedad.Click += new System.EventHandler(this.btnedad_Click);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(153, 222);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(230, 22);
            this.txtresult.TabIndex = 6;
            this.txtresult.Text = "Aquí aparecerá el resultado";
            // 
            // btnresultado
            // 
            this.btnresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(209)))), ((int)(((byte)(23)))));
            this.btnresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(23, 204);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(124, 57);
            this.btnresultado.TabIndex = 5;
            this.btnresultado.Text = "Realizar registro";
            this.btnresultado.UseVisualStyleBackColor = false;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(23, 274);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(160, 57);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Click para limpiar datos";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(331, 274);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(123, 57);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Click para salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmFormaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(915, 346);
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
            this.Name = "frmFormaC";
            this.Text = "Ejercicio C";
            this.Load += new System.EventHandler(this.frmFormaC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtage;
        private System.Windows.Forms.Button btnedad;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

