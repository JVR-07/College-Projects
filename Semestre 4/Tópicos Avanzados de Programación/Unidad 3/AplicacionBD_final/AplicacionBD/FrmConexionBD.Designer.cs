namespace AplicacionBD
{
    partial class FrmConexionBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConexionBD));
            this.GbxInformacionBasica = new System.Windows.Forms.GroupBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbxAcciones = new System.Windows.Forms.GroupBox();
            this.BtnCerrar = new CustomElements.CustomButton();
            this.BtnEliminar = new CustomElements.CustomButton();
            this.BtnBuscar = new CustomElements.CustomButton();
            this.BtnEditar = new CustomElements.CustomButton();
            this.BtnGuardar = new CustomElements.CustomButton();
            this.BtnFinal = new CustomElements.CustomButton();
            this.BtnSiguiente = new CustomElements.CustomButton();
            this.BtnAnterior = new CustomElements.CustomButton();
            this.BtnInicio = new CustomElements.CustomButton();
            this.GbxInformacionBasica.SuspendLayout();
            this.GbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxInformacionBasica
            // 
            this.GbxInformacionBasica.BackColor = System.Drawing.Color.BlueViolet;
            this.GbxInformacionBasica.Controls.Add(this.TxtDireccion);
            this.GbxInformacionBasica.Controls.Add(this.TxtTelefono);
            this.GbxInformacionBasica.Controls.Add(this.CbxSexo);
            this.GbxInformacionBasica.Controls.Add(this.label8);
            this.GbxInformacionBasica.Controls.Add(this.label7);
            this.GbxInformacionBasica.Controls.Add(this.label6);
            this.GbxInformacionBasica.Controls.Add(this.TxtSegundoApellido);
            this.GbxInformacionBasica.Controls.Add(this.label5);
            this.GbxInformacionBasica.Controls.Add(this.TxtPrimerApellido);
            this.GbxInformacionBasica.Controls.Add(this.label4);
            this.GbxInformacionBasica.Controls.Add(this.TxtSegundoNombre);
            this.GbxInformacionBasica.Controls.Add(this.label3);
            this.GbxInformacionBasica.Controls.Add(this.TxtPrimerNombre);
            this.GbxInformacionBasica.Controls.Add(this.label2);
            this.GbxInformacionBasica.Controls.Add(this.TxtIdentificacion);
            this.GbxInformacionBasica.Controls.Add(this.label1);
            this.GbxInformacionBasica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInformacionBasica.Location = new System.Drawing.Point(12, 12);
            this.GbxInformacionBasica.Name = "GbxInformacionBasica";
            this.GbxInformacionBasica.Size = new System.Drawing.Size(718, 363);
            this.GbxInformacionBasica.TabIndex = 0;
            this.GbxInformacionBasica.TabStop = false;
            this.GbxInformacionBasica.Text = "Información Básica";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(275, 318);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(405, 36);
            this.TxtDireccion.TabIndex = 18;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(275, 275);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(405, 36);
            this.TxtTelefono.TabIndex = 17;
            // 
            // CbxSexo
            // 
            this.CbxSexo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No especificado"});
            this.CbxSexo.Location = new System.Drawing.Point(275, 233);
            this.CbxSexo.MaxDropDownItems = 3;
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(405, 37);
            this.CbxSexo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo";
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoApellido.Location = new System.Drawing.Point(275, 191);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(405, 36);
            this.TxtSegundoApellido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundo Apellido";
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerApellido.Location = new System.Drawing.Point(275, 149);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(405, 36);
            this.TxtPrimerApellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primer Apellido";
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoNombre.Location = new System.Drawing.Point(275, 106);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(405, 36);
            this.TxtSegundoNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Nombre";
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerNombre.Location = new System.Drawing.Point(275, 64);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(405, 36);
            this.TxtPrimerNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Nombre";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(275, 22);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(405, 36);
            this.TxtIdentificacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // GbxAcciones
            // 
            this.GbxAcciones.BackColor = System.Drawing.Color.BlueViolet;
            this.GbxAcciones.Controls.Add(this.BtnCerrar);
            this.GbxAcciones.Controls.Add(this.BtnEliminar);
            this.GbxAcciones.Controls.Add(this.BtnBuscar);
            this.GbxAcciones.Controls.Add(this.BtnEditar);
            this.GbxAcciones.Controls.Add(this.BtnGuardar);
            this.GbxAcciones.Controls.Add(this.BtnFinal);
            this.GbxAcciones.Controls.Add(this.BtnSiguiente);
            this.GbxAcciones.Controls.Add(this.BtnAnterior);
            this.GbxAcciones.Controls.Add(this.BtnInicio);
            this.GbxAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxAcciones.Location = new System.Drawing.Point(12, 382);
            this.GbxAcciones.Name = "GbxAcciones";
            this.GbxAcciones.Size = new System.Drawing.Size(718, 185);
            this.GbxAcciones.TabIndex = 1;
            this.GbxAcciones.TabStop = false;
            this.GbxAcciones.Text = "Acciones";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DeepPink;
            this.BtnCerrar.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrar.BorderRadius = 55;
            this.BtnCerrar.BorderSize = 2;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(558, 104);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(126, 54);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.BorderRadius = 55;
            this.BtnEliminar.BorderSize = 2;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(426, 104);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(126, 54);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.BorderRadius = 55;
            this.BtnBuscar.BorderSize = 2;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(294, 104);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(126, 54);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Lime;
            this.BtnEditar.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.BorderRadius = 55;
            this.BtnEditar.BorderSize = 2;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(162, 104);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(126, 54);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnGuardar.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.BorderRadius = 55;
            this.BtnGuardar.BorderSize = 2;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(30, 102);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 54);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnFinal
            // 
            this.BtnFinal.BackColor = System.Drawing.Color.Gold;
            this.BtnFinal.BorderColor = System.Drawing.Color.Black;
            this.BtnFinal.BorderRadius = 40;
            this.BtnFinal.BorderSize = 2;
            this.BtnFinal.FlatAppearance.BorderSize = 0;
            this.BtnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinal.Location = new System.Drawing.Point(461, 28);
            this.BtnFinal.Name = "BtnFinal";
            this.BtnFinal.Size = new System.Drawing.Size(97, 41);
            this.BtnFinal.TabIndex = 12;
            this.BtnFinal.Text = ">>";
            this.BtnFinal.UseVisualStyleBackColor = false;
            this.BtnFinal.Click += new System.EventHandler(this.BtnFinal_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.Gold;
            this.BtnSiguiente.BorderColor = System.Drawing.Color.Black;
            this.BtnSiguiente.BorderRadius = 40;
            this.BtnSiguiente.BorderSize = 2;
            this.BtnSiguiente.FlatAppearance.BorderSize = 0;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(359, 28);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(97, 40);
            this.BtnSiguiente.TabIndex = 11;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.Gold;
            this.BtnAnterior.BorderColor = System.Drawing.Color.Black;
            this.BtnAnterior.BorderRadius = 40;
            this.BtnAnterior.BorderSize = 2;
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(256, 28);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(97, 38);
            this.BtnAnterior.TabIndex = 10;
            this.BtnAnterior.Text = "<";
            this.BtnAnterior.UseVisualStyleBackColor = false;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Gold;
            this.BtnInicio.BorderColor = System.Drawing.Color.Black;
            this.BtnInicio.BorderRadius = 40;
            this.BtnInicio.BorderSize = 2;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Location = new System.Drawing.Point(154, 27);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(97, 38);
            this.BtnInicio.TabIndex = 9;
            this.BtnInicio.Text = "<<";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // FrmConexionBD
            // 
            this.AcceptButton = this.BtnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.CancelButton = this.BtnCerrar;
            this.ClientSize = new System.Drawing.Size(751, 605);
            this.ControlBox = false;
            this.Controls.Add(this.GbxAcciones);
            this.Controls.Add(this.GbxInformacionBasica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConexionBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.FrmConexionBD_Load);
            this.GbxInformacionBasica.ResumeLayout(false);
            this.GbxInformacionBasica.PerformLayout();
            this.GbxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxInformacionBasica;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxAcciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxSexo;
        private CustomElements.CustomButton BtnInicio;
        private CustomElements.CustomButton BtnFinal;
        private CustomElements.CustomButton BtnSiguiente;
        private CustomElements.CustomButton BtnAnterior;
        private CustomElements.CustomButton BtnCerrar;
        private CustomElements.CustomButton BtnEliminar;
        private CustomElements.CustomButton BtnBuscar;
        private CustomElements.CustomButton BtnEditar;
        private CustomElements.CustomButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
    }
}