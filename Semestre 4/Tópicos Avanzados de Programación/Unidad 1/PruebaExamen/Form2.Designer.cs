namespace PruebaExamen
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldoHora = new System.Windows.Forms.Label();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtbxSueldoHora = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSueldoFinal = new System.Windows.Forms.Label();
            this.lblAhorro = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.txtAhorro = new System.Windows.Forms.TextBox();
            this.txtSueldoFinal = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(223, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // lblSueldoHora
            // 
            this.lblSueldoHora.AutoSize = true;
            this.lblSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoHora.Location = new System.Drawing.Point(262, 9);
            this.lblSueldoHora.Name = "lblSueldoHora";
            this.lblSueldoHora.Size = new System.Drawing.Size(278, 29);
            this.lblSueldoHora.TabIndex = 1;
            this.lblSueldoHora.Text = "Ingrese sueldo por hora";
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(583, 9);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(205, 29);
            this.lblHorasTrabajadas.TabIndex = 2;
            this.lblHorasTrabajadas.Text = "Horas trabajadas";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombre.Location = new System.Drawing.Point(17, 55);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(218, 30);
            this.txtbxNombre.TabIndex = 3;
            // 
            // txtbxHorasTrabajadas
            // 
            this.txtbxHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxHorasTrabajadas.Location = new System.Drawing.Point(570, 55);
            this.txtbxHorasTrabajadas.Name = "txtbxHorasTrabajadas";
            this.txtbxHorasTrabajadas.Size = new System.Drawing.Size(218, 30);
            this.txtbxHorasTrabajadas.TabIndex = 4;
            // 
            // txtbxSueldoHora
            // 
            this.txtbxSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSueldoHora.Location = new System.Drawing.Point(294, 55);
            this.txtbxSueldoHora.Name = "txtbxSueldoHora";
            this.txtbxSueldoHora.Size = new System.Drawing.Size(218, 30);
            this.txtbxSueldoHora.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(261, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(279, 47);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSueldoFinal
            // 
            this.lblSueldoFinal.AutoSize = true;
            this.lblSueldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoFinal.Location = new System.Drawing.Point(565, 242);
            this.lblSueldoFinal.Name = "lblSueldoFinal";
            this.lblSueldoFinal.Size = new System.Drawing.Size(218, 29);
            this.lblSueldoFinal.TabIndex = 7;
            this.lblSueldoFinal.Text = "El Sueldo Final es";
            this.lblSueldoFinal.Visible = false;
            // 
            // lblAhorro
            // 
            this.lblAhorro.AutoSize = true;
            this.lblAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorro.Location = new System.Drawing.Point(318, 242);
            this.lblAhorro.Name = "lblAhorro";
            this.lblAhorro.Size = new System.Drawing.Size(152, 29);
            this.lblAhorro.TabIndex = 8;
            this.lblAhorro.Text = "El Ahorro es";
            this.lblAhorro.Visible = false;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(12, 242);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(216, 29);
            this.lblSueldoNeto.TabIndex = 9;
            this.lblSueldoNeto.Text = "El Sueldo Neto es\r\n";
            this.lblSueldoNeto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSueldoNeto.Visible = false;
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoNeto.Location = new System.Drawing.Point(17, 292);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(218, 30);
            this.txtSueldoNeto.TabIndex = 10;
            this.txtSueldoNeto.Visible = false;
            // 
            // txtAhorro
            // 
            this.txtAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAhorro.Location = new System.Drawing.Point(294, 292);
            this.txtAhorro.Name = "txtAhorro";
            this.txtAhorro.ReadOnly = true;
            this.txtAhorro.Size = new System.Drawing.Size(218, 30);
            this.txtAhorro.TabIndex = 11;
            this.txtAhorro.Visible = false;
            // 
            // txtSueldoFinal
            // 
            this.txtSueldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoFinal.Location = new System.Drawing.Point(570, 292);
            this.txtSueldoFinal.Name = "txtSueldoFinal";
            this.txtSueldoFinal.ReadOnly = true;
            this.txtSueldoFinal.Size = new System.Drawing.Size(218, 30);
            this.txtSueldoFinal.TabIndex = 12;
            this.txtSueldoFinal.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(261, 340);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(279, 47);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajador.Location = new System.Drawing.Point(12, 182);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(200, 39);
            this.lblTrabajador.TabIndex = 14;
            this.lblTrabajador.Text = "Trabajador: ";
            this.lblTrabajador.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrabajador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSueldoFinal);
            this.Controls.Add(this.txtAhorro);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblAhorro);
            this.Controls.Add(this.lblSueldoFinal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtbxSueldoHora);
            this.Controls.Add(this.txtbxHorasTrabajadas);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.lblSueldoHora);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Calcular Sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldoHora;
        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxHorasTrabajadas;
        private System.Windows.Forms.TextBox txtbxSueldoHora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSueldoFinal;
        private System.Windows.Forms.Label lblAhorro;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.TextBox txtAhorro;
        private System.Windows.Forms.TextBox txtSueldoFinal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTrabajador;
    }
}