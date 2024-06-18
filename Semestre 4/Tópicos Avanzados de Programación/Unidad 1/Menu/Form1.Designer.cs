namespace Menu
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
            this.MnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnVer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.MnModificarPropiedades = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnArchivo,
            this.MnEditar,
            this.MnVer,
            this.MnPrograma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnArchivo
            // 
            this.MnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnNuevo});
            this.MnArchivo.Name = "MnArchivo";
            this.MnArchivo.Size = new System.Drawing.Size(73, 24);
            this.MnArchivo.Text = "Archivo";
            // 
            // MnNuevo
            // 
            this.MnNuevo.Name = "MnNuevo";
            this.MnNuevo.Size = new System.Drawing.Size(135, 26);
            this.MnNuevo.Text = "Nuevo";
            // 
            // MnEditar
            // 
            this.MnEditar.Name = "MnEditar";
            this.MnEditar.Size = new System.Drawing.Size(62, 24);
            this.MnEditar.Text = "Editar";
            // 
            // MnVer
            // 
            this.MnVer.Name = "MnVer";
            this.MnVer.Size = new System.Drawing.Size(44, 24);
            this.MnVer.Text = "Ver";
            // 
            // MnPrograma
            // 
            this.MnPrograma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnModificarPropiedades});
            this.MnPrograma.Name = "MnPrograma";
            this.MnPrograma.Size = new System.Drawing.Size(94, 24);
            this.MnPrograma.Text = "Programas";
            // 
            // MnModificarPropiedades
            // 
            this.MnModificarPropiedades.Name = "MnModificarPropiedades";
            this.MnModificarPropiedades.Size = new System.Drawing.Size(244, 26);
            this.MnModificarPropiedades.Text = "Modificar propiedades";
            this.MnModificarPropiedades.Click += new System.EventHandler(this.MnModificarPropiedades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programas Topicos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnArchivo;
        private System.Windows.Forms.ToolStripMenuItem MnNuevo;
        private System.Windows.Forms.ToolStripMenuItem MnEditar;
        private System.Windows.Forms.ToolStripMenuItem MnVer;
        private System.Windows.Forms.ToolStripMenuItem MnPrograma;
        private System.Windows.Forms.ToolStripMenuItem MnModificarPropiedades;
    }
}

