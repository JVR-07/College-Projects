namespace Ejercicio_D
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
            this.btnnumero = new System.Windows.Forms.Button();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verificador de números pares o impares";
            // 
            // btnnumero
            // 
            this.btnnumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(97)))), ((int)(((byte)(254)))));
            this.btnnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnumero.Location = new System.Drawing.Point(127, 52);
            this.btnnumero.Name = "btnnumero";
            this.btnnumero.Size = new System.Drawing.Size(220, 51);
            this.btnnumero.TabIndex = 1;
            this.btnnumero.Text = "Ingresar número";
            this.btnnumero.UseVisualStyleBackColor = false;
            this.btnnumero.Click += new System.EventHandler(this.btnnumero_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(97)))), ((int)(((byte)(254)))));
            this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Location = new System.Drawing.Point(127, 139);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(223, 48);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "Verificar número";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(85)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(124, 212);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(223, 48);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Ingresar nuevo número";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(124, 266);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(223, 45);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtnum
            // 
            this.txtnum.AutoSize = true;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnum.Location = new System.Drawing.Point(124, 106);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(116, 17);
            this.txtnum.TabIndex = 5;
            this.txtnum.Text = "Texto de ejemplo";
            this.txtnum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(255)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(516, 353);
            this.ControlBox = false;
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.btnnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnumero;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label txtnum;
    }
}

