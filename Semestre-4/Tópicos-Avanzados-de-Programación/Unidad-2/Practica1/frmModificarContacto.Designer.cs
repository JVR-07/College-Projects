using System;

namespace Practica1
{
    partial class frmModificarContacto
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
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtbxRedSocial = new System.Windows.Forms.TextBox();
            this.txtbxTelefono = new System.Windows.Forms.TextBox();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.lblRedSocial = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.Location = new System.Drawing.Point(148, 430);
            this.btnEditarContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(364, 72);
            this.btnEditarContacto.TabIndex = 20;
            this.btnEditarContacto.Text = "Editar Contacto";
            this.btnEditarContacto.UseVisualStyleBackColor = true;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(186, 267);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(469, 36);
            this.dtpFechaNacimiento.TabIndex = 19;
            // 
            // txtbxRedSocial
            // 
            this.txtbxRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxRedSocial.Location = new System.Drawing.Point(167, 348);
            this.txtbxRedSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxRedSocial.Name = "txtbxRedSocial";
            this.txtbxRedSocial.Size = new System.Drawing.Size(489, 36);
            this.txtbxRedSocial.TabIndex = 18;
            // 
            // txtbxTelefono
            // 
            this.txtbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTelefono.Location = new System.Drawing.Point(167, 177);
            this.txtbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxTelefono.Name = "txtbxTelefono";
            this.txtbxTelefono.Size = new System.Drawing.Size(488, 36);
            this.txtbxTelefono.TabIndex = 17;
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombre.Location = new System.Drawing.Point(167, 103);
            this.txtbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(488, 39);
            this.txtbxNombre.TabIndex = 16;
            // 
            // lblRedSocial
            // 
            this.lblRedSocial.AutoSize = true;
            this.lblRedSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedSocial.Location = new System.Drawing.Point(5, 344);
            this.lblRedSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedSocial.Name = "lblRedSocial";
            this.lblRedSocial.Size = new System.Drawing.Size(170, 38);
            this.lblRedSocial.TabIndex = 15;
            this.lblRedSocial.Text = "Instagram:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(-2, 225);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(189, 76);
            this.lblFechaNacimiento.TabIndex = 14;
            this.lblFechaNacimiento.Text = "Fecha de\r\nNacimiento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(4, 173);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(152, 38);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(10, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 38);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(166, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(385, 58);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Editar Contacto";
            // 
            // frmModificarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 564);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtbxRedSocial);
            this.Controls.Add(this.txtbxTelefono);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblRedSocial);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmModificarContacto";
            this.Text = "frmModificarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtbxRedSocial;
        private System.Windows.Forms.TextBox txtbxTelefono;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Label lblRedSocial;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblTitulo;
    }
}