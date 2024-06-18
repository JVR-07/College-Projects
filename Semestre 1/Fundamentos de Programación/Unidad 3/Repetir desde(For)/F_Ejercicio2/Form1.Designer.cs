namespace F_Ejercicio2
{
    partial class frmMiforma
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.txtResultado3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTADOR DE EDADES";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(13)))));
            this.btnIngresar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnIngresar.Location = new System.Drawing.Point(794, 81);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 70);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "&Ingresar edades";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(13)))));
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnSalir.Location = new System.Drawing.Point(794, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 70);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir del programa";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(13)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnLimpiar.Location = new System.Drawing.Point(794, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 70);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "&Limpiar edades";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 81);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(237, 419);
            this.txtResultado.TabIndex = 4;
            // 
            // txtResultado2
            // 
            this.txtResultado2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado2.Location = new System.Drawing.Point(277, 81);
            this.txtResultado2.Multiline = true;
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.ReadOnly = true;
            this.txtResultado2.Size = new System.Drawing.Size(236, 419);
            this.txtResultado2.TabIndex = 5;
            // 
            // txtResultado3
            // 
            this.txtResultado3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado3.Location = new System.Drawing.Point(540, 81);
            this.txtResultado3.Multiline = true;
            this.txtResultado3.Name = "txtResultado3";
            this.txtResultado3.ReadOnly = true;
            this.txtResultado3.Size = new System.Drawing.Size(237, 419);
            this.txtResultado3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(58, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total de edades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(536, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de menores de edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(273, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de mayores de edad";
            // 
            // txtaviso
            // 
            this.txtaviso.AutoSize = true;
            this.txtaviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.txtaviso.Location = new System.Drawing.Point(13, 519);
            this.txtaviso.Name = "txtaviso";
            this.txtaviso.Size = new System.Drawing.Size(291, 17);
            this.txtaviso.TabIndex = 10;
            this.txtaviso.Text = "Texto de Ejemplo SUSSUSUSUSUSUSUSUS";
            this.txtaviso.Visible = false;
            // 
            // frmMiforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(254)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(923, 557);
            this.ControlBox = false;
            this.Controls.Add(this.txtaviso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado3);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMiforma";
            this.Text = "Ejercicio 3 FOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.TextBox txtResultado3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtaviso;
    }
}

