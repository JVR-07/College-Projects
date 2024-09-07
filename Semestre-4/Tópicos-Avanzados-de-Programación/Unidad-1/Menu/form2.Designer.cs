using System;

namespace Menu
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.txtbxTextoPrincipal = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnDesaparecer = new System.Windows.Forms.Button();
            this.btnAparecerlo = new System.Windows.Forms.Button();
            this.btnEnviarTexto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquearControl = new System.Windows.Forms.Button();
            this.btnCambiarColorFondo = new System.Windows.Forms.Button();
            this.txtVisibilidad = new System.Windows.Forms.Label();
            this.txtAccesibilidad = new System.Windows.Forms.Label();
            this.btnCambiarColorLetra = new System.Windows.Forms.Button();
            this.cbColorFuente = new System.Windows.Forms.ComboBox();
            this.txtbxTextoSecundario = new System.Windows.Forms.TextBox();
            this.txtColorFuenteFondo = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxTextoPrincipal
            // 
            this.txtbxTextoPrincipal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTextoPrincipal.Location = new System.Drawing.Point(281, 63);
            this.txtbxTextoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxTextoPrincipal.Multiline = true;
            this.txtbxTextoPrincipal.Name = "txtbxTextoPrincipal";
            this.txtbxTextoPrincipal.Size = new System.Drawing.Size(431, 61);
            this.txtbxTextoPrincipal.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(227, 11);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(522, 39);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Modificar Propiedades de Control";
            // 
            // btnDesaparecer
            // 
            this.btnDesaparecer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDesaparecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesaparecer.Location = new System.Drawing.Point(281, 169);
            this.btnDesaparecer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesaparecer.Name = "btnDesaparecer";
            this.btnDesaparecer.Size = new System.Drawing.Size(199, 46);
            this.btnDesaparecer.TabIndex = 2;
            this.btnDesaparecer.Text = "Desaparecer";
            this.btnDesaparecer.UseVisualStyleBackColor = false;
            this.btnDesaparecer.Click += new System.EventHandler(this.btnDesaparecerlo_Click);
            // 
            // btnAparecerlo
            // 
            this.btnAparecerlo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAparecerlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAparecerlo.Location = new System.Drawing.Point(281, 231);
            this.btnAparecerlo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAparecerlo.Name = "btnAparecerlo";
            this.btnAparecerlo.Size = new System.Drawing.Size(199, 46);
            this.btnAparecerlo.TabIndex = 3;
            this.btnAparecerlo.Text = "Aparecerlo";
            this.btnAparecerlo.UseVisualStyleBackColor = false;
            this.btnAparecerlo.Click += new System.EventHandler(this.btnAparecerlo_Click);
            // 
            // btnEnviarTexto
            // 
            this.btnEnviarTexto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEnviarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarTexto.Location = new System.Drawing.Point(508, 438);
            this.btnEnviarTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarTexto.Name = "btnEnviarTexto";
            this.btnEnviarTexto.Size = new System.Drawing.Size(205, 46);
            this.btnEnviarTexto.TabIndex = 4;
            this.btnEnviarTexto.Text = "Enviar el texto";
            this.btnEnviarTexto.UseVisualStyleBackColor = false;
            this.btnEnviarTexto.Click += new System.EventHandler(this.btnEnviarTexto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(508, 501);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(205, 46);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Location = new System.Drawing.Point(508, 231);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(205, 46);
            this.btnDesbloquear.TabIndex = 6;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = false;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnBloquearControl
            // 
            this.btnBloquearControl.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBloquearControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquearControl.Location = new System.Drawing.Point(508, 169);
            this.btnBloquearControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBloquearControl.Name = "btnBloquearControl";
            this.btnBloquearControl.Size = new System.Drawing.Size(205, 46);
            this.btnBloquearControl.TabIndex = 7;
            this.btnBloquearControl.Text = "Bloquear control";
            this.btnBloquearControl.UseVisualStyleBackColor = false;
            this.btnBloquearControl.Click += new System.EventHandler(this.btnBloquearControl_Click);
            // 
            // btnCambiarColorFondo
            // 
            this.btnCambiarColorFondo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCambiarColorFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarColorFondo.Location = new System.Drawing.Point(281, 501);
            this.btnCambiarColorFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarColorFondo.Name = "btnCambiarColorFondo";
            this.btnCambiarColorFondo.Size = new System.Drawing.Size(199, 46);
            this.btnCambiarColorFondo.TabIndex = 9;
            this.btnCambiarColorFondo.Text = "Cambiar color fondo";
            this.btnCambiarColorFondo.UseVisualStyleBackColor = false;
            this.btnCambiarColorFondo.Click += new System.EventHandler(this.btnCambiarColorFondo_Click);
            // 
            // txtVisibilidad
            // 
            this.txtVisibilidad.AutoSize = true;
            this.txtVisibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisibilidad.Location = new System.Drawing.Point(291, 135);
            this.txtVisibilidad.Name = "txtVisibilidad";
            this.txtVisibilidad.Size = new System.Drawing.Size(129, 29);
            this.txtVisibilidad.TabIndex = 10;
            this.txtVisibilidad.Text = "Visibilidad";
            // 
            // txtAccesibilidad
            // 
            this.txtAccesibilidad.AutoSize = true;
            this.txtAccesibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccesibilidad.Location = new System.Drawing.Point(528, 135);
            this.txtAccesibilidad.Name = "txtAccesibilidad";
            this.txtAccesibilidad.Size = new System.Drawing.Size(163, 29);
            this.txtAccesibilidad.TabIndex = 11;
            this.txtAccesibilidad.Text = "Accesibilidad";
            // 
            // btnCambiarColorLetra
            // 
            this.btnCambiarColorLetra.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCambiarColorLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarColorLetra.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarColorLetra.Location = new System.Drawing.Point(281, 438);
            this.btnCambiarColorLetra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarColorLetra.Name = "btnCambiarColorLetra";
            this.btnCambiarColorLetra.Size = new System.Drawing.Size(199, 46);
            this.btnCambiarColorLetra.TabIndex = 12;
            this.btnCambiarColorLetra.Text = "Cambiar color letra";
            this.btnCambiarColorLetra.UseVisualStyleBackColor = false;
            this.btnCambiarColorLetra.Click += new System.EventHandler(this.btnCambiarColorLetra_Click);
            // 
            // cbColorFuente
            // 
            this.cbColorFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColorFuente.FormattingEnabled = true;
            this.cbColorFuente.Items.AddRange(new object[] {
            "Ligth Golden Yellow",
            "Forest Green",
            "Medium Slate Blue",
            "Pale Turquoise",
            "Hot Pink"});
            this.cbColorFuente.Location = new System.Drawing.Point(281, 361);
            this.cbColorFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbColorFuente.Name = "cbColorFuente";
            this.cbColorFuente.Size = new System.Drawing.Size(197, 28);
            this.cbColorFuente.TabIndex = 13;
            // 
            // txtbxTextoSecundario
            // 
            this.txtbxTextoSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTextoSecundario.Location = new System.Drawing.Point(508, 346);
            this.txtbxTextoSecundario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxTextoSecundario.Multiline = true;
            this.txtbxTextoSecundario.Name = "txtbxTextoSecundario";
            this.txtbxTextoSecundario.Size = new System.Drawing.Size(188, 46);
            this.txtbxTextoSecundario.TabIndex = 14;
            // 
            // txtColorFuenteFondo
            // 
            this.txtColorFuenteFondo.AutoSize = true;
            this.txtColorFuenteFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorFuenteFondo.Location = new System.Drawing.Point(276, 294);
            this.txtColorFuenteFondo.Name = "txtColorFuenteFondo";
            this.txtColorFuenteFondo.Size = new System.Drawing.Size(165, 50);
            this.txtColorFuenteFondo.TabIndex = 15;
            this.txtColorFuenteFondo.Text = "Color de fuente y \r\ncolor de fondo";
            // 
            // txtTexto
            // 
            this.txtTexto.AutoSize = true;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(560, 313);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(75, 29);
            this.txtTexto.TabIndex = 16;
            this.txtTexto.Text = "Texto";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1072, 578);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtColorFuenteFondo);
            this.Controls.Add(this.txtbxTextoSecundario);
            this.Controls.Add(this.cbColorFuente);
            this.Controls.Add(this.btnCambiarColorLetra);
            this.Controls.Add(this.txtAccesibilidad);
            this.Controls.Add(this.txtVisibilidad);
            this.Controls.Add(this.btnCambiarColorFondo);
            this.Controls.Add(this.btnBloquearControl);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEnviarTexto);
            this.Controls.Add(this.btnAparecerlo);
            this.Controls.Add(this.btnDesaparecer);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtbxTextoPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Propiedades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTextoPrincipal;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnDesaparecer;
        private System.Windows.Forms.Button btnAparecerlo;
        private System.Windows.Forms.Button btnEnviarTexto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquearControl;
        private System.Windows.Forms.Button btnCambiarColorFondo;
        private System.Windows.Forms.Label txtVisibilidad;
        private System.Windows.Forms.Label txtAccesibilidad;
        private System.Windows.Forms.Button btnCambiarColorLetra;
        private System.Windows.Forms.ComboBox cbColorFuente;
        private System.Windows.Forms.TextBox txtbxTextoSecundario;
        private System.Windows.Forms.Label txtColorFuenteFondo;
        private System.Windows.Forms.Label txtTexto;
    }
}