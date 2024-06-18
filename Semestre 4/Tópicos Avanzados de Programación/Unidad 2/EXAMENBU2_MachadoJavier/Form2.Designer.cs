namespace EXAMENBU2_MachadoJavier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtbxNombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxCarreraUniversitaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxNivelEstudio = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new CustomElements.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnadirMateria = new CustomElements.CustomButton();
            this.DgvMaterias = new System.Windows.Forms.DataGridView();
            this.txtbxNombreMateria = new System.Windows.Forms.TextBox();
            this.txtbxHorasMateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHorasSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de empleado: ";
            // 
            // txtbxNoEmpleado
            // 
            this.txtbxNoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNoEmpleado.Location = new System.Drawing.Point(223, 43);
            this.txtbxNoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNoEmpleado.Name = "txtbxNoEmpleado";
            this.txtbxNoEmpleado.Size = new System.Drawing.Size(328, 30);
            this.txtbxNoEmpleado.TabIndex = 2;
            // 
            // txtbxNombreCompleto
            // 
            this.txtbxNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombreCompleto.Location = new System.Drawing.Point(223, 75);
            this.txtbxNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNombreCompleto.Name = "txtbxNombreCompleto";
            this.txtbxNombreCompleto.Size = new System.Drawing.Size(328, 30);
            this.txtbxNombreCompleto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre completo: ";
            // 
            // txtbxCarreraUniversitaria
            // 
            this.txtbxCarreraUniversitaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCarreraUniversitaria.Location = new System.Drawing.Point(224, 107);
            this.txtbxCarreraUniversitaria.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCarreraUniversitaria.Name = "txtbxCarreraUniversitaria";
            this.txtbxCarreraUniversitaria.Size = new System.Drawing.Size(328, 30);
            this.txtbxCarreraUniversitaria.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carrera universitaria: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nivel de estudio: ";
            // 
            // cmbxNivelEstudio
            // 
            this.cmbxNivelEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxNivelEstudio.FormattingEnabled = true;
            this.cmbxNivelEstudio.Items.AddRange(new object[] {
            "Licenciatura",
            "Maestría",
            "Doctorado"});
            this.cmbxNivelEstudio.Location = new System.Drawing.Point(224, 140);
            this.cmbxNivelEstudio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxNivelEstudio.Name = "cmbxNivelEstudio";
            this.cmbxNivelEstudio.Size = new System.Drawing.Size(328, 33);
            this.cmbxNivelEstudio.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistrar.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnRegistrar.BorderRadius = 40;
            this.btnRegistrar.BorderSize = 2;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(179, 497);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(240, 49);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Capturar Docente";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre Materia:";
            // 
            // btnAnadirMateria
            // 
            this.btnAnadirMateria.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnadirMateria.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnAnadirMateria.BorderRadius = 40;
            this.btnAnadirMateria.BorderSize = 2;
            this.btnAnadirMateria.FlatAppearance.BorderSize = 0;
            this.btnAnadirMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirMateria.Location = new System.Drawing.Point(179, 248);
            this.btnAnadirMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirMateria.Name = "btnAnadirMateria";
            this.btnAnadirMateria.Size = new System.Drawing.Size(218, 36);
            this.btnAnadirMateria.TabIndex = 11;
            this.btnAnadirMateria.Text = "Añadir Materia";
            this.btnAnadirMateria.UseVisualStyleBackColor = false;
            this.btnAnadirMateria.Click += new System.EventHandler(this.btnAnadirMateria_Click);
            // 
            // DgvMaterias
            // 
            this.DgvMaterias.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMateria,
            this.clmHorasSemanales});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMaterias.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMaterias.GridColor = System.Drawing.Color.White;
            this.DgvMaterias.Location = new System.Drawing.Point(-1, 292);
            this.DgvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.DgvMaterias.Name = "DgvMaterias";
            this.DgvMaterias.RowHeadersWidth = 51;
            this.DgvMaterias.Size = new System.Drawing.Size(581, 192);
            this.DgvMaterias.TabIndex = 12;
            // 
            // txtbxNombreMateria
            // 
            this.txtbxNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombreMateria.Location = new System.Drawing.Point(224, 176);
            this.txtbxNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNombreMateria.Name = "txtbxNombreMateria";
            this.txtbxNombreMateria.Size = new System.Drawing.Size(328, 30);
            this.txtbxNombreMateria.TabIndex = 13;
            // 
            // txtbxHorasMateria
            // 
            this.txtbxHorasMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxHorasMateria.Location = new System.Drawing.Point(224, 210);
            this.txtbxHorasMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxHorasMateria.Name = "txtbxHorasMateria";
            this.txtbxHorasMateria.Size = new System.Drawing.Size(328, 30);
            this.txtbxHorasMateria.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Horas de la Materia: ";
            // 
            // clmMateria
            // 
            this.clmMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMateria.HeaderText = "Nombre Materia";
            this.clmMateria.MinimumWidth = 6;
            this.clmMateria.Name = "clmMateria";
            this.clmMateria.ReadOnly = true;
            // 
            // clmHorasSemanales
            // 
            this.clmHorasSemanales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHorasSemanales.HeaderText = "Horas Semanales";
            this.clmHorasSemanales.MinimumWidth = 6;
            this.clmHorasSemanales.Name = "clmHorasSemanales";
            this.clmHorasSemanales.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(583, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxHorasMateria);
            this.Controls.Add(this.txtbxNombreMateria);
            this.Controls.Add(this.DgvMaterias);
            this.Controls.Add(this.btnAnadirMateria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbxNivelEstudio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxCarreraUniversitaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxNombreCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxNoEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de docente";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxNoEmpleado;
        private System.Windows.Forms.TextBox txtbxNombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxCarreraUniversitaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxNivelEstudio;
        private CustomElements.CustomButton btnRegistrar;
        private System.Windows.Forms.Label label6;
        private CustomElements.CustomButton btnAnadirMateria;
        private System.Windows.Forms.DataGridView DgvMaterias;
        private System.Windows.Forms.TextBox txtbxNombreMateria;
        private System.Windows.Forms.TextBox txtbxHorasMateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHorasSemanales;
    }
}