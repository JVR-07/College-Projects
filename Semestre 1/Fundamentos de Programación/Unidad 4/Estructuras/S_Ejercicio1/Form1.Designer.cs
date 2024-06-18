namespace S_Ejercicio1
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
            this.btniniciarregistro = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnimprimirresultado = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL CLIMA";
            // 
            // btniniciarregistro
            // 
            this.btniniciarregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btniniciarregistro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarregistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(106)))));
            this.btniniciarregistro.Location = new System.Drawing.Point(12, 59);
            this.btniniciarregistro.Name = "btniniciarregistro";
            this.btniniciarregistro.Size = new System.Drawing.Size(136, 32);
            this.btniniciarregistro.TabIndex = 1;
            this.btniniciarregistro.Text = "&Iniciar registro";
            this.btniniciarregistro.UseVisualStyleBackColor = false;
            this.btniniciarregistro.Click += new System.EventHandler(this.btniniciarregistro_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Black;
            this.txtresultado.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(133)))), ((int)(((byte)(3)))));
            this.txtresultado.Location = new System.Drawing.Point(12, 106);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(555, 123);
            this.txtresultado.TabIndex = 2;
            // 
            // btnimprimirresultado
            // 
            this.btnimprimirresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnimprimirresultado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(106)))));
            this.btnimprimirresultado.Location = new System.Drawing.Point(422, 59);
            this.btnimprimirresultado.Name = "btnimprimirresultado";
            this.btnimprimirresultado.Size = new System.Drawing.Size(145, 32);
            this.btnimprimirresultado.TabIndex = 3;
            this.btnimprimirresultado.Text = "&Mostrar registro";
            this.btnimprimirresultado.UseVisualStyleBackColor = false;
            this.btnimprimirresultado.Click += new System.EventHandler(this.btnimprimirresultado_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.btnlimpiar.Location = new System.Drawing.Point(12, 245);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(136, 34);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "&Limpiar programa";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnsalir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(206)))));
            this.btnsalir.Location = new System.Drawing.Point(422, 245);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(145, 34);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(220)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(584, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnimprimirresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btniniciarregistro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Tijuana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btniniciarregistro;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnimprimirresultado;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

