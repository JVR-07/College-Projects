namespace FalsaPosicion_Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtErrorFinal = new System.Windows.Forms.TextBox();
            this.txtbxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTablaIteraciones = new System.Windows.Forms.DataGridView();
            this.ClmNumIteraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmXr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFXr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNuevoIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtErrorFinal
            // 
            this.txtErrorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorFinal.Location = new System.Drawing.Point(695, 257);
            this.txtErrorFinal.Name = "txtErrorFinal";
            this.txtErrorFinal.ReadOnly = true;
            this.txtErrorFinal.Size = new System.Drawing.Size(304, 30);
            this.txtErrorFinal.TabIndex = 16;
            // 
            // txtbxResultado
            // 
            this.txtbxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResultado.Location = new System.Drawing.Point(695, 218);
            this.txtbxResultado.Name = "txtbxResultado";
            this.txtbxResultado.ReadOnly = true;
            this.txtbxResultado.Size = new System.Drawing.Size(304, 30);
            this.txtbxResultado.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Con un error aproximado de: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "El resultado de la raíz es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fórmula a utilizar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 78);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calcular, con el método de la falsa posición, la raíz \r\nde la ecuación 4x² - 5x e" +
    "n el intervalo [1 , 1.6]\r\n";
            // 
            // dgvTablaIteraciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaIteraciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNumIteraciones,
            this.ClmA,
            this.ClmB,
            this.ClmFa,
            this.ClmFb,
            this.ClmXr,
            this.ClmFXr,
            this.ClmError,
            this.ClmNuevoIntervalo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaIteraciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaIteraciones.Location = new System.Drawing.Point(0, 308);
            this.dgvTablaIteraciones.Name = "dgvTablaIteraciones";
            this.dgvTablaIteraciones.Size = new System.Drawing.Size(1601, 417);
            this.dgvTablaIteraciones.TabIndex = 17;
            // 
            // ClmNumIteraciones
            // 
            this.ClmNumIteraciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmNumIteraciones.FillWeight = 203.0457F;
            this.ClmNumIteraciones.HeaderText = "#Iter";
            this.ClmNumIteraciones.Name = "ClmNumIteraciones";
            this.ClmNumIteraciones.ReadOnly = true;
            this.ClmNumIteraciones.Width = 50;
            // 
            // ClmA
            // 
            this.ClmA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmA.FillWeight = 85.27919F;
            this.ClmA.HeaderText = "a";
            this.ClmA.Name = "ClmA";
            this.ClmA.ReadOnly = true;
            // 
            // ClmB
            // 
            this.ClmB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmB.FillWeight = 85.27919F;
            this.ClmB.HeaderText = "b";
            this.ClmB.Name = "ClmB";
            this.ClmB.ReadOnly = true;
            // 
            // ClmFa
            // 
            this.ClmFa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmFa.FillWeight = 85.27919F;
            this.ClmFa.HeaderText = "f(a)";
            this.ClmFa.Name = "ClmFa";
            this.ClmFa.ReadOnly = true;
            // 
            // ClmFb
            // 
            this.ClmFb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmFb.FillWeight = 85.27919F;
            this.ClmFb.HeaderText = "f(b)";
            this.ClmFb.Name = "ClmFb";
            this.ClmFb.ReadOnly = true;
            // 
            // ClmXr
            // 
            this.ClmXr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmXr.FillWeight = 85.27919F;
            this.ClmXr.HeaderText = "Xr";
            this.ClmXr.Name = "ClmXr";
            this.ClmXr.ReadOnly = true;
            // 
            // ClmFXr
            // 
            this.ClmFXr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmFXr.FillWeight = 85.27919F;
            this.ClmFXr.HeaderText = "f(Xr)";
            this.ClmFXr.Name = "ClmFXr";
            this.ClmFXr.ReadOnly = true;
            // 
            // ClmError
            // 
            this.ClmError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmError.FillWeight = 85.27919F;
            this.ClmError.HeaderText = "εₐ";
            this.ClmError.Name = "ClmError";
            this.ClmError.ReadOnly = true;
            // 
            // ClmNuevoIntervalo
            // 
            this.ClmNuevoIntervalo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmNuevoIntervalo.HeaderText = "Nuevo Intervalo";
            this.ClmNuevoIntervalo.Name = "ClmNuevoIntervalo";
            this.ClmNuevoIntervalo.ReadOnly = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(214, 60);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Presiona para iniciar cálculo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1374, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(214, 60);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Presiona para salir del programa\r\n";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 725);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvTablaIteraciones);
            this.Controls.Add(this.txtErrorFinal);
            this.Controls.Add(this.txtbxResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método falsa posición ejercicio 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErrorFinal;
        private System.Windows.Forms.TextBox txtbxResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTablaIteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumIteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmXr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFXr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNuevoIntervalo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}

