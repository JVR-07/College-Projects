namespace Ejercicio_B
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btncod = new System.Windows.Forms.Button();
            this.btnsueldo = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.Label();
            this.txtdep = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.Label();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculador de sueldos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ingrese su nombre";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.Location = new System.Drawing.Point(19, 102);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(246, 38);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Ingrese su departamento";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btncod
            // 
            this.btncod.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncod.Location = new System.Drawing.Point(19, 146);
            this.btncod.Name = "btncod";
            this.btncod.Size = new System.Drawing.Size(246, 38);
            this.btncod.TabIndex = 3;
            this.btncod.Text = "Ingrese su código";
            this.btncod.UseVisualStyleBackColor = false;
            this.btncod.Click += new System.EventHandler(this.btncod_Click);
            // 
            // btnsueldo
            // 
            this.btnsueldo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsueldo.Location = new System.Drawing.Point(19, 190);
            this.btnsueldo.Name = "btnsueldo";
            this.btnsueldo.Size = new System.Drawing.Size(246, 65);
            this.btnsueldo.TabIndex = 4;
            this.btnsueldo.Text = "Ingrese su sueldo mensual";
            this.btnsueldo.UseVisualStyleBackColor = false;
            this.btnsueldo.Click += new System.EventHandler(this.btnsueldo_Click);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtname.Location = new System.Drawing.Point(271, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(157, 20);
            this.txtname.TabIndex = 5;
            this.txtname.Text = "Esperando nombre...";
            // 
            // txtdep
            // 
            this.txtdep.AutoSize = true;
            this.txtdep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdep.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtdep.Location = new System.Drawing.Point(271, 116);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(203, 20);
            this.txtdep.TabIndex = 6;
            this.txtdep.Text = "Esperando departamento...";
            // 
            // txtcod
            // 
            this.txtcod.AutoSize = true;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtcod.Location = new System.Drawing.Point(271, 160);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(150, 20);
            this.txtcod.TabIndex = 7;
            this.txtcod.Text = "Esperando código...";
            // 
            // txtsueldo
            // 
            this.txtsueldo.AutoSize = true;
            this.txtsueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsueldo.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtsueldo.Location = new System.Drawing.Point(271, 208);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(214, 20);
            this.txtsueldo.TabIndex = 8;
            this.txtsueldo.Text = "Esperando sueldo mensual...";
            // 
            // btnresult
            // 
            this.btnresult.BackColor = System.Drawing.Color.Cyan;
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(188, 273);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(174, 77);
            this.btnresult.TabIndex = 9;
            this.btnresult.Text = "Calcular nuevo sueldo";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(388, 273);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 77);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(19, 273);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(135, 77);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar registro";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(532, 365);
            this.ControlBox = false;
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnsueldo);
            this.Controls.Add(this.btncod);
            this.Controls.Add(this.btndep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.Button btncod;
        private System.Windows.Forms.Button btnsueldo;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtdep;
        private System.Windows.Forms.Label txtcod;
        private System.Windows.Forms.Label txtsueldo;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

