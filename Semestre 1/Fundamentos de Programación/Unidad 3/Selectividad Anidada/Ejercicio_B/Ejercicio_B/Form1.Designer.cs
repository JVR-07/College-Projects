namespace Ejercicio_B
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar mes del año ingresando su número";
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(81)))));
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.Color.Black;
            this.btnmostrar.Location = new System.Drawing.Point(376, 52);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(163, 35);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar mes del año";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el número del mes:";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(219, 61);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(94, 26);
            this.txtnum.TabIndex = 3;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(80, 90);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(64, 45);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar mes";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(159)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(17, 90);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(57, 45);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(231)))));
            this.txtresult.Location = new System.Drawing.Point(175, 98);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(276, 25);
            this.txtresult.TabIndex = 6;
            this.txtresult.Text = "Aquí aparecerá el mes del año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(566, 151);
            this.ControlBox = false;
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Ejercicio B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label txtresult;
    }
}

