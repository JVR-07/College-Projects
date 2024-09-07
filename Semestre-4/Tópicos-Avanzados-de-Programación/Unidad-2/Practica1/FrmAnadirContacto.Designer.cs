namespace Practica1
{
    partial class FrmAnadirContacto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblRedSocial = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxTelefono = new System.Windows.Forms.TextBox();
            this.txtbxRedSocial = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAnadirContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(98, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(468, 58);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos del Contacto";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 38);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(0, 176);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(152, 38);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(-6, 228);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(189, 76);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de\r\nNacimiento:";
            // 
            // lblRedSocial
            // 
            this.lblRedSocial.AutoSize = true;
            this.lblRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedSocial.Location = new System.Drawing.Point(1, 347);
            this.lblRedSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedSocial.Name = "lblRedSocial";
            this.lblRedSocial.Size = new System.Drawing.Size(170, 38);
            this.lblRedSocial.TabIndex = 4;
            this.lblRedSocial.Text = "Instagram:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombre.Location = new System.Drawing.Point(162, 106);
            this.txtbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(489, 39);
            this.txtbxNombre.TabIndex = 5;
            // 
            // txtbxTelefono
            // 
            this.txtbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTelefono.Location = new System.Drawing.Point(162, 180);
            this.txtbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxTelefono.Name = "txtbxTelefono";
            this.txtbxTelefono.Size = new System.Drawing.Size(489, 36);
            this.txtbxTelefono.TabIndex = 6;
            // 
            // txtbxRedSocial
            // 
            this.txtbxRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxRedSocial.Location = new System.Drawing.Point(165, 350);
            this.txtbxRedSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxRedSocial.Name = "txtbxRedSocial";
            this.txtbxRedSocial.Size = new System.Drawing.Size(488, 36);
            this.txtbxRedSocial.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(180, 270);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(471, 36);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // btnAnadirContacto
            // 
            this.btnAnadirContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirContacto.Location = new System.Drawing.Point(144, 433);
            this.btnAnadirContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirContacto.Name = "btnAnadirContacto";
            this.btnAnadirContacto.Size = new System.Drawing.Size(364, 72);
            this.btnAnadirContacto.TabIndex = 10;
            this.btnAnadirContacto.Text = "Añadir Contacto";
            this.btnAnadirContacto.UseVisualStyleBackColor = true;
            this.btnAnadirContacto.Click += new System.EventHandler(this.btnAnadirContacto_Click);
            // 
            // FrmAnadirContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 554);
            this.Controls.Add(this.btnAnadirContacto);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtbxRedSocial);
            this.Controls.Add(this.txtbxTelefono);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblRedSocial);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnadirContacto";
            this.Text = "FrmAnadirContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblRedSocial;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxTelefono;
        private System.Windows.Forms.TextBox txtbxRedSocial;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnAnadirContacto;
    }
}