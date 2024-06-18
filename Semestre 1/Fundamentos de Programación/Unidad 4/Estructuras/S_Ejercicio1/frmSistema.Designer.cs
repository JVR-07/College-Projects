namespace S_Ejercicio1
{
    partial class frmSistema
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtvelocidadviento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtestadoclima = new System.Windows.Forms.TextBox();
            this.btnaceptarregistro = new System.Windows.Forms.Button();
            this.btncerrarregistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la velocidad del viento y el estado del clima\r\n";
            // 
            // txtvelocidadviento
            // 
            this.txtvelocidadviento.Location = new System.Drawing.Point(35, 82);
            this.txtvelocidadviento.Name = "txtvelocidadviento";
            this.txtvelocidadviento.ReadOnly = true;
            this.txtvelocidadviento.Size = new System.Drawing.Size(192, 20);
            this.txtvelocidadviento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la velocidad del viento en Km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese el estado del clima";
            // 
            // txtestadoclima
            // 
            this.txtestadoclima.Location = new System.Drawing.Point(261, 82);
            this.txtestadoclima.Name = "txtestadoclima";
            this.txtestadoclima.ReadOnly = true;
            this.txtestadoclima.Size = new System.Drawing.Size(192, 20);
            this.txtestadoclima.TabIndex = 3;
            // 
            // btnaceptarregistro
            // 
            this.btnaceptarregistro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptarregistro.Location = new System.Drawing.Point(86, 117);
            this.btnaceptarregistro.Name = "btnaceptarregistro";
            this.btnaceptarregistro.Size = new System.Drawing.Size(75, 23);
            this.btnaceptarregistro.TabIndex = 5;
            this.btnaceptarregistro.Text = "&Aceptar";
            this.btnaceptarregistro.UseVisualStyleBackColor = true;
            // 
            // btncerrarregistro
            // 
            this.btncerrarregistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncerrarregistro.Location = new System.Drawing.Point(321, 117);
            this.btncerrarregistro.Name = "btncerrarregistro";
            this.btncerrarregistro.Size = new System.Drawing.Size(75, 23);
            this.btncerrarregistro.TabIndex = 6;
            this.btncerrarregistro.Text = "&Cancelar";
            this.btncerrarregistro.UseVisualStyleBackColor = true;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 167);
            this.ControlBox = false;
            this.Controls.Add(this.btncerrarregistro);
            this.Controls.Add(this.btnaceptarregistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtestadoclima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvelocidadviento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.TextBox txtvelocidadviento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.TextBox txtestadoclima;
        public  System.Windows.Forms.Button btnaceptarregistro;
        public  System.Windows.Forms.Button btncerrarregistro;
    }
}