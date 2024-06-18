namespace Practica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiAnadirContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.smiModificarContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.smiEliminarContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPreguntasFrecuentes = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.smiSalirPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.clmIdRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRedSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAnadirContacto,
            this.smiModificarContacto,
            this.smiEliminarContacto,
            this.ayudaToolStripMenuItem,
            this.smiSalirPrograma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1654, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiAnadirContacto
            // 
            this.smiAnadirContacto.Name = "smiAnadirContacto";
            this.smiAnadirContacto.Size = new System.Drawing.Size(131, 24);
            this.smiAnadirContacto.Text = "Añadir Contacto";
            this.smiAnadirContacto.Click += new System.EventHandler(this.smiAnadirContacto_Click);
            // 
            // smiModificarContacto
            // 
            this.smiModificarContacto.Name = "smiModificarContacto";
            this.smiModificarContacto.Size = new System.Drawing.Size(151, 24);
            this.smiModificarContacto.Text = "Modificar Contacto";
            this.smiModificarContacto.Click += new System.EventHandler(this.smiModificarContacto_Click);
            // 
            // smiEliminarContacto
            // 
            this.smiEliminarContacto.Name = "smiEliminarContacto";
            this.smiEliminarContacto.Size = new System.Drawing.Size(141, 24);
            this.smiEliminarContacto.Text = "Eliminar Contacto";
            this.smiEliminarContacto.Click += new System.EventHandler(this.smiEliminarContacto_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiPreguntasFrecuentes,
            this.smiAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // smiPreguntasFrecuentes
            // 
            this.smiPreguntasFrecuentes.Name = "smiPreguntasFrecuentes";
            this.smiPreguntasFrecuentes.Size = new System.Drawing.Size(229, 26);
            this.smiPreguntasFrecuentes.Text = "Preguntas frecuentes";
            // 
            // smiAcercaDe
            // 
            this.smiAcercaDe.Name = "smiAcercaDe";
            this.smiAcercaDe.Size = new System.Drawing.Size(229, 26);
            this.smiAcercaDe.Text = "Acerca de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Contactos";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdRow,
            this.clmNombre,
            this.clmTelefono,
            this.clmFechaNacimiento,
            this.clmRedSocial});
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.Location = new System.Drawing.Point(0, 76);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(1685, 762);
            this.dgvContactos.StandardTab = true;
            this.dgvContactos.TabIndex = 2;
            // 
            // smiSalirPrograma
            // 
            this.smiSalirPrograma.Name = "smiSalirPrograma";
            this.smiSalirPrograma.Size = new System.Drawing.Size(146, 24);
            this.smiSalirPrograma.Text = "Salir del Programa";
            this.smiSalirPrograma.Click += new System.EventHandler(this.smiSalirPrograma_Click);
            // 
            // clmIdRow
            // 
            this.clmIdRow.HeaderText = "#";
            this.clmIdRow.MinimumWidth = 6;
            this.clmIdRow.Name = "clmIdRow";
            this.clmIdRow.ReadOnly = true;
            this.clmIdRow.Width = 40;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre del Contacto";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 360;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.MinimumWidth = 6;
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.Width = 360;
            // 
            // clmFechaNacimiento
            // 
            this.clmFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.clmFechaNacimiento.MinimumWidth = 6;
            this.clmFechaNacimiento.Name = "clmFechaNacimiento";
            this.clmFechaNacimiento.Width = 360;
            // 
            // clmRedSocial
            // 
            this.clmRedSocial.HeaderText = "Instagram";
            this.clmRedSocial.MinimumWidth = 6;
            this.clmRedSocial.Name = "clmRedSocial";
            this.clmRedSocial.Width = 360;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1654, 838);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiAnadirContacto;
        private System.Windows.Forms.ToolStripMenuItem smiModificarContacto;
        private System.Windows.Forms.ToolStripMenuItem smiEliminarContacto;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiPreguntasFrecuentes;
        private System.Windows.Forms.ToolStripMenuItem smiAcercaDe;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.ToolStripMenuItem smiSalirPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRedSocial;
    }
}

