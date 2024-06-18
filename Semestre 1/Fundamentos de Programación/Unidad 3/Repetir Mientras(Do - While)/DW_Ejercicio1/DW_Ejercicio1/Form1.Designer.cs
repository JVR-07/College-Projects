namespace DW_Ejercicio1
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotaledades = new System.Windows.Forms.TextBox();
            this.txtMaE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.txterror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada a 10 edades y determinar mayores de edad";
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(5)))), ((int)(((byte)(111)))));
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.White;
            this.btnCapturar.Location = new System.Drawing.Point(189, 37);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(166, 39);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "&Ingresar edades";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de edades";
            // 
            // txttotaledades
            // 
            this.txttotaledades.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaledades.Location = new System.Drawing.Point(17, 129);
            this.txttotaledades.Multiline = true;
            this.txttotaledades.Name = "txttotaledades";
            this.txttotaledades.ReadOnly = true;
            this.txttotaledades.Size = new System.Drawing.Size(160, 288);
            this.txttotaledades.TabIndex = 3;
            // 
            // txtMaE
            // 
            this.txtMaE.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaE.Location = new System.Drawing.Point(189, 129);
            this.txtMaE.Multiline = true;
            this.txtMaE.Name = "txtMaE";
            this.txtMaE.ReadOnly = true;
            this.txtMaE.Size = new System.Drawing.Size(155, 288);
            this.txtMaE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mayores de edad";
            // 
            // txtMeE
            // 
            this.txtMeE.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeE.Location = new System.Drawing.Point(359, 129);
            this.txtMeE.Multiline = true;
            this.txtMeE.Name = "txtMeE";
            this.txtMeE.ReadOnly = true;
            this.txtMeE.Size = new System.Drawing.Size(172, 288);
            this.txtMeE.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menores de edad";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(41)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 432);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 38);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(425, 432);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(90, 38);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "&Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txterror.Location = new System.Drawing.Point(14, 473);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(110, 17);
            this.txterror.TabIndex = 10;
            this.txterror.Text = "esperando texto";
            this.txterror.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(255)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(574, 517);
            this.ControlBox = false;
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMeE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotaledades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Programa 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotaledades;
        private System.Windows.Forms.TextBox txtMaE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label txterror;
    }
}

