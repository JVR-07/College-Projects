namespace VuelaVeloz
{
    partial class frmVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEliminarTripulante = new CustomElements.CustomButton();
            this.btnAgregarTripulante = new CustomElements.CustomButton();
            this.dgvTablaTripulacion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmVUE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTRIP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEstDest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvnId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiuOrigen = new System.Windows.Forms.TextBox();
            this.txtPilId = new System.Windows.Forms.TextBox();
            this.txtCiuDest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraLleg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstOrigen = new System.Windows.Forms.TextBox();
            this.txtHoraSal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dgvTablaVuelos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTripulacion)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(830, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 838);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 663);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.dgvTablaTripulacion);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 376);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 287);
            this.panel8.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnEliminarTripulante);
            this.panel9.Controls.Add(this.btnAgregarTripulante);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 214);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(222, 73);
            this.panel9.TabIndex = 22;
            // 
            // btnEliminarTripulante
            // 
            this.btnEliminarTripulante.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminarTripulante.BorderRadius = 30;
            this.btnEliminarTripulante.BorderSize = 1;
            this.btnEliminarTripulante.FlatAppearance.BorderSize = 0;
            this.btnEliminarTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTripulante.Location = new System.Drawing.Point(12, 38);
            this.btnEliminarTripulante.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTripulante.Name = "btnEliminarTripulante";
            this.btnEliminarTripulante.Size = new System.Drawing.Size(199, 32);
            this.btnEliminarTripulante.TabIndex = 23;
            this.btnEliminarTripulante.Text = "Eliminar Tripulante";
            this.btnEliminarTripulante.UseVisualStyleBackColor = true;
            this.btnEliminarTripulante.Visible = false;
            this.btnEliminarTripulante.Click += new System.EventHandler(this.btnEliminarTripulante_Click);
            // 
            // btnAgregarTripulante
            // 
            this.btnAgregarTripulante.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarTripulante.BorderRadius = 30;
            this.btnAgregarTripulante.BorderSize = 1;
            this.btnAgregarTripulante.FlatAppearance.BorderSize = 0;
            this.btnAgregarTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTripulante.Location = new System.Drawing.Point(12, 2);
            this.btnAgregarTripulante.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTripulante.Name = "btnAgregarTripulante";
            this.btnAgregarTripulante.Size = new System.Drawing.Size(199, 32);
            this.btnAgregarTripulante.TabIndex = 22;
            this.btnAgregarTripulante.Text = "Agregar Tripulante";
            this.btnAgregarTripulante.UseVisualStyleBackColor = true;
            this.btnAgregarTripulante.Visible = false;
            this.btnAgregarTripulante.Click += new System.EventHandler(this.btnAgregarTripulante_Click);
            // 
            // dgvTablaTripulacion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaTripulacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaTripulacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaTripulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaTripulacion.ColumnHeadersHeight = 18;
            this.dgvTablaTripulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTablaTripulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVUE_ID,
            this.clmTRIP_ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaTripulacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaTripulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaTripulacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulacion.Location = new System.Drawing.Point(0, 31);
            this.dgvTablaTripulacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaTripulacion.Name = "dgvTablaTripulacion";
            this.dgvTablaTripulacion.ReadOnly = true;
            this.dgvTablaTripulacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTablaTripulacion.RowHeadersVisible = false;
            this.dgvTablaTripulacion.RowHeadersWidth = 51;
            this.dgvTablaTripulacion.RowTemplate.Height = 24;
            this.dgvTablaTripulacion.Size = new System.Drawing.Size(222, 256);
            this.dgvTablaTripulacion.TabIndex = 21;
            this.dgvTablaTripulacion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulacion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTablaTripulacion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulacion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulacion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTablaTripulacion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulacion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTablaTripulacion.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTablaTripulacion.ThemeStyle.ReadOnly = true;
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaTripulacion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmVUE_ID
            // 
            this.clmVUE_ID.HeaderText = "VUE_ID";
            this.clmVUE_ID.Name = "clmVUE_ID";
            this.clmVUE_ID.ReadOnly = true;
            // 
            // clmTRIP_ID
            // 
            this.clmTRIP_ID.HeaderText = "TRIP_ID";
            this.clmTRIP_ID.Name = "clmTRIP_ID";
            this.clmTRIP_ID.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tripulación";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.txtEstDest);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtAvnId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtCiuOrigen);
            this.panel4.Controls.Add(this.txtPilId);
            this.panel4.Controls.Add(this.txtCiuDest);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtHoraLleg);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtEstOrigen);
            this.panel4.Controls.Add(this.txtHoraSal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 376);
            this.panel4.TabIndex = 21;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(108, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtEstDest
            // 
            this.txtEstDest.Location = new System.Drawing.Point(103, 119);
            this.txtEstDest.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstDest.Name = "txtEstDest";
            this.txtEstDest.ReadOnly = true;
            this.txtEstDest.Size = new System.Drawing.Size(108, 20);
            this.txtEstDest.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Avión Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado Destino";
            // 
            // txtAvnId
            // 
            this.txtAvnId.Location = new System.Drawing.Point(103, 338);
            this.txtAvnId.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvnId.Name = "txtAvnId";
            this.txtAvnId.ReadOnly = true;
            this.txtAvnId.Size = new System.Drawing.Size(108, 20);
            this.txtAvnId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ciudad Destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Piloto Id";
            // 
            // txtCiuOrigen
            // 
            this.txtCiuOrigen.Location = new System.Drawing.Point(103, 159);
            this.txtCiuOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiuOrigen.Name = "txtCiuOrigen";
            this.txtCiuOrigen.ReadOnly = true;
            this.txtCiuOrigen.Size = new System.Drawing.Size(108, 20);
            this.txtCiuOrigen.TabIndex = 7;
            // 
            // txtPilId
            // 
            this.txtPilId.Location = new System.Drawing.Point(103, 304);
            this.txtPilId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPilId.Name = "txtPilId";
            this.txtPilId.ReadOnly = true;
            this.txtPilId.Size = new System.Drawing.Size(108, 20);
            this.txtPilId.TabIndex = 15;
            // 
            // txtCiuDest
            // 
            this.txtCiuDest.Location = new System.Drawing.Point(103, 77);
            this.txtCiuDest.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiuDest.Name = "txtCiuDest";
            this.txtCiuDest.ReadOnly = true;
            this.txtCiuDest.Size = new System.Drawing.Size(108, 20);
            this.txtCiuDest.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hora LLegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ciudad Origen";
            // 
            // txtHoraLleg
            // 
            this.txtHoraLleg.Location = new System.Drawing.Point(103, 271);
            this.txtHoraLleg.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraLleg.Name = "txtHoraLleg";
            this.txtHoraLleg.ReadOnly = true;
            this.txtHoraLleg.Size = new System.Drawing.Size(108, 20);
            this.txtHoraLleg.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora Salida";
            // 
            // txtEstOrigen
            // 
            this.txtEstOrigen.Location = new System.Drawing.Point(103, 194);
            this.txtEstOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstOrigen.Name = "txtEstOrigen";
            this.txtEstOrigen.ReadOnly = true;
            this.txtEstOrigen.Size = new System.Drawing.Size(108, 20);
            this.txtEstOrigen.TabIndex = 9;
            // 
            // txtHoraSal
            // 
            this.txtHoraSal.Location = new System.Drawing.Point(103, 234);
            this.txtHoraSal.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraSal.Name = "txtHoraSal";
            this.txtHoraSal.ReadOnly = true;
            this.txtHoraSal.Size = new System.Drawing.Size(108, 20);
            this.txtHoraSal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado Origen";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnAceptarEditar);
            this.panel6.Controls.Add(this.btnAceptarAgregar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 738);
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
            this.lblBarraLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBarraLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.lblBarraLateral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarraLateral.Name = "lblBarraLateral";
            this.lblBarraLateral.Size = new System.Drawing.Size(222, 50);
            this.lblBarraLateral.TabIndex = 1;
            this.lblBarraLateral.Text = "Vuelo Seleccionado";
            this.lblBarraLateral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 754);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 84);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 84);
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
            this.btnEliminar.Location = new System.Drawing.Point(645, 11);
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
            this.btnBuscar.Location = new System.Drawing.Point(437, 11);
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
            this.btnAgregar.Location = new System.Drawing.Point(23, 11);
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
            this.btnEditar.Location = new System.Drawing.Point(230, 11);
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
            this.panel3.Size = new System.Drawing.Size(830, 55);
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
            this.label1.Size = new System.Drawing.Size(830, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Vuelos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTablaVuelos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTablaVuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaVuelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaVuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTablaVuelos.ColumnHeadersHeight = 18;
            this.dgvTablaVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaVuelos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTablaVuelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaVuelos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaVuelos.Location = new System.Drawing.Point(0, 55);
            this.dgvTablaVuelos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaVuelos.Name = "dgvTablaVuelos";
            this.dgvTablaVuelos.ReadOnly = true;
            this.dgvTablaVuelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTablaVuelos.RowHeadersVisible = false;
            this.dgvTablaVuelos.RowHeadersWidth = 51;
            this.dgvTablaVuelos.RowTemplate.Height = 24;
            this.dgvTablaVuelos.Size = new System.Drawing.Size(830, 699);
            this.dgvTablaVuelos.TabIndex = 4;
            this.dgvTablaVuelos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaVuelos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTablaVuelos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTablaVuelos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTablaVuelos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTablaVuelos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaVuelos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTablaVuelos.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTablaVuelos.ThemeStyle.ReadOnly = true;
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaVuelos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaVuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaVuelos_CellClick);
            // 
            // frmVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1052, 838);
            this.Controls.Add(this.dgvTablaVuelos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVuelos";
            this.Text = "frmVuelos";
            this.Load += new System.EventHandler(this.frmVuelos_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTripulacion)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvTablaVuelos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private CustomElements.CustomButton btnEliminarTripulante;
        private CustomElements.CustomButton btnAgregarTripulante;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTablaTripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVUE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTRIP_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEstDest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvnId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiuOrigen;
        private System.Windows.Forms.TextBox txtPilId;
        private System.Windows.Forms.TextBox txtCiuDest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoraLleg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstOrigen;
        private System.Windows.Forms.TextBox txtHoraSal;
        private System.Windows.Forms.Label label2;
    }
}