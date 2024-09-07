namespace EXAMENBU2_MachadoJavier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DgvTablaDocentes = new System.Windows.Forms.DataGridView();
            this.btnImprimirDocentes = new CustomElements.CustomButton();
            this.btnAnadirDocente = new CustomElements.CustomButton();
            this.clmNoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCarreraUniversitaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNivelEstudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaterias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHorasClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new CustomElements.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaDocentes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTablaDocentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTablaDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvTablaDocentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvTablaDocentes.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTablaDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTablaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNoEmpleado,
            this.clmNombreCompleto,
            this.clmCarreraUniversitaria,
            this.clmNivelEstudio,
            this.clmMaterias,
            this.clmHorasClase,
            this.clmSueldo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTablaDocentes.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvTablaDocentes.GridColor = System.Drawing.Color.White;
            this.DgvTablaDocentes.Location = new System.Drawing.Point(0, 87);
            this.DgvTablaDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTablaDocentes.Name = "DgvTablaDocentes";
            this.DgvTablaDocentes.ReadOnly = true;
            this.DgvTablaDocentes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvTablaDocentes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvTablaDocentes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvTablaDocentes.Size = new System.Drawing.Size(1500, 680);
            this.DgvTablaDocentes.TabIndex = 2;
            // 
            // btnImprimirDocentes
            // 
            this.btnImprimirDocentes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnImprimirDocentes.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnImprimirDocentes.BorderRadius = 40;
            this.btnImprimirDocentes.BorderSize = 2;
            this.btnImprimirDocentes.FlatAppearance.BorderSize = 0;
            this.btnImprimirDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDocentes.Location = new System.Drawing.Point(632, 16);
            this.btnImprimirDocentes.Name = "btnImprimirDocentes";
            this.btnImprimirDocentes.Size = new System.Drawing.Size(217, 64);
            this.btnImprimirDocentes.TabIndex = 3;
            this.btnImprimirDocentes.Text = "Imprimir Docentes";
            this.btnImprimirDocentes.UseVisualStyleBackColor = false;
            this.btnImprimirDocentes.Click += new System.EventHandler(this.btnImprimirDocentes_Click);
            // 
            // btnAnadirDocente
            // 
            this.btnAnadirDocente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnadirDocente.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnAnadirDocente.BorderRadius = 50;
            this.btnAnadirDocente.BorderSize = 2;
            this.btnAnadirDocente.FlatAppearance.BorderSize = 0;
            this.btnAnadirDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirDocente.ForeColor = System.Drawing.Color.Black;
            this.btnAnadirDocente.Location = new System.Drawing.Point(55, 16);
            this.btnAnadirDocente.Name = "btnAnadirDocente";
            this.btnAnadirDocente.Size = new System.Drawing.Size(210, 64);
            this.btnAnadirDocente.TabIndex = 4;
            this.btnAnadirDocente.Text = "Añadir Docente";
            this.btnAnadirDocente.UseVisualStyleBackColor = false;
            this.btnAnadirDocente.Click += new System.EventHandler(this.btnAnadirDocente_Click);
            // 
            // clmNoEmpleado
            // 
            this.clmNoEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clmNoEmpleado.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmNoEmpleado.HeaderText = "Número Control";
            this.clmNoEmpleado.MinimumWidth = 6;
            this.clmNoEmpleado.Name = "clmNoEmpleado";
            this.clmNoEmpleado.ReadOnly = true;
            // 
            // clmNombreCompleto
            // 
            this.clmNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmNombreCompleto.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmNombreCompleto.HeaderText = "Nombre Completo";
            this.clmNombreCompleto.MinimumWidth = 6;
            this.clmNombreCompleto.Name = "clmNombreCompleto";
            this.clmNombreCompleto.ReadOnly = true;
            // 
            // clmCarreraUniversitaria
            // 
            this.clmCarreraUniversitaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCarreraUniversitaria.HeaderText = "Carrera Universitaria";
            this.clmCarreraUniversitaria.MinimumWidth = 6;
            this.clmCarreraUniversitaria.Name = "clmCarreraUniversitaria";
            this.clmCarreraUniversitaria.ReadOnly = true;
            // 
            // clmNivelEstudio
            // 
            this.clmNivelEstudio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNivelEstudio.HeaderText = "Nivel Estudio";
            this.clmNivelEstudio.MinimumWidth = 6;
            this.clmNivelEstudio.Name = "clmNivelEstudio";
            this.clmNivelEstudio.ReadOnly = true;
            // 
            // clmMaterias
            // 
            this.clmMaterias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMaterias.HeaderText = "Lista de Materias";
            this.clmMaterias.MinimumWidth = 6;
            this.clmMaterias.Name = "clmMaterias";
            this.clmMaterias.ReadOnly = true;
            // 
            // clmHorasClase
            // 
            this.clmHorasClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHorasClase.HeaderText = "Horas Clase";
            this.clmHorasClase.MinimumWidth = 6;
            this.clmHorasClase.Name = "clmHorasClase";
            this.clmHorasClase.ReadOnly = true;
            // 
            // clmSueldo
            // 
            this.clmSueldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSueldo.HeaderText = "Sueldo";
            this.clmSueldo.MinimumWidth = 6;
            this.clmSueldo.Name = "clmSueldo";
            this.clmSueldo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnSalir.BorderRadius = 40;
            this.btnSalir.BorderSize = 2;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1229, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(231, 64);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir del Programa";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 633);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnadirDocente);
            this.Controls.Add(this.btnImprimirDocentes);
            this.Controls.Add(this.DgvTablaDocentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTablaDocentes;
        private CustomElements.CustomButton btnImprimirDocentes;
        private CustomElements.CustomButton btnAnadirDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCarreraUniversitaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNivelEstudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHorasClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSueldo;
        private CustomElements.CustomButton btnSalir;
    }
}

