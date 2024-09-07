namespace Practica1
{
    partial class MainView
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
            this.gbxCoordinate = new System.Windows.Forms.GroupBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDraw = new System.Windows.Forms.GroupBox();
            this.pbxDrawZone = new System.Windows.Forms.PictureBox();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            this.btnDrawLines = new System.Windows.Forms.Button();
            this.gbxFormat = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbxCoordinate.SuspendLayout();
            this.gbxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawZone)).BeginInit();
            this.gbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCoordinate
            // 
            this.gbxCoordinate.Controls.Add(this.lblY);
            this.gbxCoordinate.Controls.Add(this.lblX);
            this.gbxCoordinate.Controls.Add(this.label2);
            this.gbxCoordinate.Controls.Add(this.label1);
            this.gbxCoordinate.Location = new System.Drawing.Point(1052, 12);
            this.gbxCoordinate.Name = "gbxCoordinate";
            this.gbxCoordinate.Size = new System.Drawing.Size(200, 82);
            this.gbxCoordinate.TabIndex = 1;
            this.gbxCoordinate.TabStop = false;
            this.gbxCoordinate.Text = "Sección de Coordenadas";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(132, 53);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "label4";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(31, 53);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // gbxDraw
            // 
            this.gbxDraw.Controls.Add(this.pbxDrawZone);
            this.gbxDraw.Location = new System.Drawing.Point(12, 100);
            this.gbxDraw.Name = "gbxDraw";
            this.gbxDraw.Size = new System.Drawing.Size(1240, 569);
            this.gbxDraw.TabIndex = 2;
            this.gbxDraw.TabStop = false;
            this.gbxDraw.Text = "Sección de Dibujo";
            // 
            // pbxDrawZone
            // 
            this.pbxDrawZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDrawZone.Location = new System.Drawing.Point(6, 19);
            this.pbxDrawZone.Name = "pbxDrawZone";
            this.pbxDrawZone.Size = new System.Drawing.Size(1228, 544);
            this.pbxDrawZone.TabIndex = 0;
            this.pbxDrawZone.TabStop = false;
            this.pbxDrawZone.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDrawZone_Paint);
            this.pbxDrawZone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxDrawZone_MouseClick);
            this.pbxDrawZone.MouseLeave += new System.EventHandler(this.pbxDrawZone_MouseLeave);
            this.pbxDrawZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxDrawZone_MouseMove);
            // 
            // gbxControls
            // 
            this.gbxControls.Controls.Add(this.btnDrawLines);
            this.gbxControls.Location = new System.Drawing.Point(888, 12);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(127, 82);
            this.gbxControls.TabIndex = 3;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Sección de Controles";
            // 
            // btnDrawLines
            // 
            this.btnDrawLines.Location = new System.Drawing.Point(16, 21);
            this.btnDrawLines.Name = "btnDrawLines";
            this.btnDrawLines.Size = new System.Drawing.Size(96, 45);
            this.btnDrawLines.TabIndex = 1;
            this.btnDrawLines.Text = "Start Drawing";
            this.btnDrawLines.UseVisualStyleBackColor = true;
            this.btnDrawLines.Click += new System.EventHandler(this.btnDrawLines_Click);
            // 
            // gbxFormat
            // 
            this.gbxFormat.Location = new System.Drawing.Point(18, 12);
            this.gbxFormat.Name = "gbxFormat";
            this.gbxFormat.Size = new System.Drawing.Size(864, 82);
            this.gbxFormat.TabIndex = 4;
            this.gbxFormat.TabStop = false;
            this.gbxFormat.Text = "Sección de Formato";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbxFormat);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxDraw);
            this.Controls.Add(this.gbxCoordinate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Principal";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.gbxCoordinate.ResumeLayout(false);
            this.gbxCoordinate.PerformLayout();
            this.gbxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawZone)).EndInit();
            this.gbxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCoordinate;
        private System.Windows.Forms.GroupBox gbxDraw;
        private System.Windows.Forms.PictureBox pbxDrawZone;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxControls;
        private System.Windows.Forms.Button btnDrawLines;
        private System.Windows.Forms.GroupBox gbxFormat;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

