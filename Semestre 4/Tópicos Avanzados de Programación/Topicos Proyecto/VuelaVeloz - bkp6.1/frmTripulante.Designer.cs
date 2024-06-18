namespace VuelaVeloz
{
    partial class frmTripulante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaseId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegApe = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrimNom = new System.Windows.Forms.TextBox();
            this.txtPrimApe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegNom = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelar = new CustomElements.CustomButton();
            this.btnAceptarEditar = new CustomElements.CustomButton();
            this.btnAceptarAgregar = new CustomElements.CustomButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBarraLateral = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new CustomElements.CustomButton();
            this.btnBuscar = new CustomElements.CustomButton();
            this.btnAgregar = new CustomElements.CustomButton();
            this.btnEditar = new CustomElements.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTablaTripulantes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(860, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 563);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txtBaseId);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtSegApe);
            this.panel7.Controls.Add(this.txtId);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txtPrimNom);
            this.panel7.Controls.Add(this.txtPrimApe);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtSegNom);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 413);
            this.panel7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vuelo Id :";
            // 
            // txtBaseId
            // 
            this.txtBaseId.Location = new System.Drawing.Point(59, 368);
            this.txtBaseId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaseId.Name = "txtBaseId";
            this.txtBaseId.ReadOnly = true;
            this.txtBaseId.Size = new System.Drawing.Size(108, 20);
            this.txtBaseId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Apellido :";
            // 
            // txtSegApe
            // 
            this.txtSegApe.Location = new System.Drawing.Point(59, 304);
            this.txtSegApe.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegApe.Name = "txtSegApe";
            this.txtSegApe.ReadOnly = true;
            this.txtSegApe.Size = new System.Drawing.Size(108, 20);
            this.txtSegApe.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(59, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(108, 20);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Primer Apellido :";
            // 
            // txtPrimNom
            // 
            this.txtPrimNom.Location = new System.Drawing.Point(59, 94);
            this.txtPrimNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimNom.Name = "txtPrimNom";
            this.txtPrimNom.ReadOnly = true;
            this.txtPrimNom.Size = new System.Drawing.Size(108, 20);
            this.txtPrimNom.TabIndex = 3;
            // 
            // txtPrimApe
            // 
            this.txtPrimApe.Location = new System.Drawing.Point(59, 227);
            this.txtPrimApe.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimApe.Name = "txtPrimApe";
            this.txtPrimApe.ReadOnly = true;
            this.txtPrimApe.Size = new System.Drawing.Size(108, 20);
            this.txtPrimApe.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Primer Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segundo Nombre :";
            // 
            // txtSegNom
            // 
            this.txtSegNom.Location = new System.Drawing.Point(59, 159);
            this.txtSegNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegNom.Name = "txtSegNom";
            this.txtSegNom.ReadOnly = true;
            this.txtSegNom.Size = new System.Drawing.Size(108, 20);
            this.txtSegNom.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnAceptarEditar);
            this.panel6.Controls.Add(this.btnAceptarAgregar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 463);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 100);
            this.panel6.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderRadius = 30;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(47, 61);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarEditar
            // 
            this.btnAceptarEditar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptarEditar.BorderRadius = 30;
            this.btnAceptarEditar.BorderSize = 1;
            this.btnAceptarEditar.FlatAppearance.BorderSize = 0;
            this.btnAceptarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEditar.Location = new System.Drawing.Point(47, 16);
            this.btnAceptarEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarEditar.Name = "btnAceptarEditar";
            this.btnAceptarEditar.Size = new System.Drawing.Size(135, 32);
            this.btnAceptarEditar.TabIndex = 11;
            this.btnAceptarEditar.Text = "Aceptar";
            this.btnAceptarEditar.UseVisualStyleBackColor = true;
            this.btnAceptarEditar.Visible = false;
            this.btnAceptarEditar.Click += new System.EventHandler(this.btnAceptarEditar_Click);
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptarAgregar.BorderRadius = 30;
            this.btnAceptarAgregar.BorderSize = 1;
            this.btnAceptarAgregar.FlatAppearance.BorderSize = 0;
            this.btnAceptarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAgregar.Location = new System.Drawing.Point(47, 16);
            this.btnAceptarAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(135, 32);
            this.btnAceptarAgregar.TabIndex = 10;
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = true;
            this.btnAceptarAgregar.Visible = false;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblBarraLateral);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 50);
            this.panel5.TabIndex = 0;
            // 
            // lblBarraLateral
            // 
            this.lblBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.lblBarraLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBarraLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.lblBarraLateral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarraLateral.Name = "lblBarraLateral";
            this.lblBarraLateral.Size = new System.Drawing.Size(222, 50);
            this.lblBarraLateral.TabIndex = 1;
            this.lblBarraLateral.Text = "Tripulante Seleccionado";
            this.lblBarraLateral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 84);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderRadius = 60;
            this.btnEliminar.BorderSize = 1;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(672, 11);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 61);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderRadius = 60;
            this.btnBuscar.BorderSize = 1;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(457, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 61);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BorderRadius = 60;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(27, 11);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 61);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnEditar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BorderRadius = 60;
            this.btnEditar.BorderSize = 1;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(242, 11);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 61);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 55);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Tripulantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTablaTripulantes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaTripulantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaTripulantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaTripulantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaTripulantes.ColumnHeadersHeight = 18;
            this.dgvTablaTripulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaTripulantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaTripulantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaTripulantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulantes.Location = new System.Drawing.Point(0, 55);
            this.dgvTablaTripulantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaTripulantes.Name = "dgvTablaTripulantes";
            this.dgvTablaTripulantes.ReadOnly = true;
            this.dgvTablaTripulantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTablaTripulantes.RowHeadersVisible = false;
            this.dgvTablaTripulantes.RowHeadersWidth = 51;
            this.dgvTablaTripulantes.RowTemplate.Height = 24;
            this.dgvTablaTripulantes.Size = new System.Drawing.Size(860, 424);
            this.dgvTablaTripulantes.TabIndex = 4;
            this.dgvTablaTripulantes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTablaTripulantes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulantes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulantes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTablaTripulantes.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTablaTripulantes.ThemeStyle.ReadOnly = true;
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulantes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaTripulantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaTripulantes_CellClick);
            // 
            // frmTripulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 563);
            this.Controls.Add(this.dgvTablaTripulantes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTripulante";
            this.Text = "frmTripulante";
            this.Load += new System.EventHandler(this.frmTripulante_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTripulantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrimNom;
        private System.Windows.Forms.TextBox txtPrimApe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegNom;
        private System.Windows.Forms.Panel panel6;
        private CustomElements.CustomButton btnCancelar;
        private CustomElements.CustomButton btnAceptarEditar;
        private CustomElements.CustomButton btnAceptarAgregar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBarraLateral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomElements.CustomButton btnEliminar;
        private CustomElements.CustomButton btnBuscar;
        private CustomElements.CustomButton btnAgregar;
        private CustomElements.CustomButton btnEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTablaTripulantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSegApe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBaseId;
    }
}