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
            this.clrPoint = new System.Windows.Forms.ColorDialog();
            this.btnPointColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPointColor = new System.Windows.Forms.Panel();
            this.pnlLineColor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.clrLine = new System.Windows.Forms.ColorDialog();
            this.btnClearDraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxCoordinate.SuspendLayout();
            this.gbxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawZone)).BeginInit();
            this.gbxControls.SuspendLayout();
            this.gbxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCoordinate
            // 
            this.gbxCoordinate.BackColor = System.Drawing.Color.White;
            this.gbxCoordinate.Controls.Add(this.lblY);
            this.gbxCoordinate.Controls.Add(this.lblX);
            this.gbxCoordinate.Controls.Add(this.label2);
            this.gbxCoordinate.Controls.Add(this.label1);
            this.gbxCoordinate.Location = new System.Drawing.Point(1052, 12);
            this.gbxCoordinate.Name = "gbxCoordinate";
            this.gbxCoordinate.Size = new System.Drawing.Size(200, 106);
            this.gbxCoordinate.TabIndex = 1;
            this.gbxCoordinate.TabStop = false;
            this.gbxCoordinate.Text = "Sección de Coordenadas";
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(120, 62);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(55, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "label4";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(25, 62);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(65, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "label3";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(117, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxDraw
            // 
            this.gbxDraw.Controls.Add(this.pbxDrawZone);
            this.gbxDraw.Location = new System.Drawing.Point(12, 124);
            this.gbxDraw.Name = "gbxDraw";
            this.gbxDraw.Size = new System.Drawing.Size(1240, 545);
            this.gbxDraw.TabIndex = 2;
            this.gbxDraw.TabStop = false;
            this.gbxDraw.Text = "Sección de Dibujo";
            // 
            // pbxDrawZone
            // 
            this.pbxDrawZone.BackColor = System.Drawing.Color.White;
            this.pbxDrawZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDrawZone.Location = new System.Drawing.Point(6, 19);
            this.pbxDrawZone.Name = "pbxDrawZone";
            this.pbxDrawZone.Size = new System.Drawing.Size(1228, 520);
            this.pbxDrawZone.TabIndex = 0;
            this.pbxDrawZone.TabStop = false;
            this.pbxDrawZone.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDrawZone_Paint);
            this.pbxDrawZone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxDrawZone_MouseClick);
            this.pbxDrawZone.MouseLeave += new System.EventHandler(this.pbxDrawZone_MouseLeave);
            this.pbxDrawZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxDrawZone_MouseMove);
            // 
            // gbxControls
            // 
            this.gbxControls.BackColor = System.Drawing.Color.White;
            this.gbxControls.Controls.Add(this.btnClearDraw);
            this.gbxControls.Controls.Add(this.btnDrawLines);
            this.gbxControls.Location = new System.Drawing.Point(787, 12);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(243, 106);
            this.gbxControls.TabIndex = 3;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Sección de Controles";
            // 
            // btnDrawLines
            // 
            this.btnDrawLines.Location = new System.Drawing.Point(16, 35);
            this.btnDrawLines.Name = "btnDrawLines";
            this.btnDrawLines.Size = new System.Drawing.Size(96, 45);
            this.btnDrawLines.TabIndex = 1;
            this.btnDrawLines.Text = "Start Drawing";
            this.btnDrawLines.UseVisualStyleBackColor = true;
            this.btnDrawLines.Click += new System.EventHandler(this.btnDrawLines_Click);
            // 
            // gbxFormat
            // 
            this.gbxFormat.BackColor = System.Drawing.Color.White;
            this.gbxFormat.Controls.Add(this.pnlLineColor);
            this.gbxFormat.Controls.Add(this.label4);
            this.gbxFormat.Controls.Add(this.btnLineColor);
            this.gbxFormat.Controls.Add(this.pnlPointColor);
            this.gbxFormat.Controls.Add(this.label3);
            this.gbxFormat.Controls.Add(this.btnPointColor);
            this.gbxFormat.Location = new System.Drawing.Point(506, 12);
            this.gbxFormat.Name = "gbxFormat";
            this.gbxFormat.Size = new System.Drawing.Size(275, 106);
            this.gbxFormat.TabIndex = 4;
            this.gbxFormat.TabStop = false;
            this.gbxFormat.Text = "Sección de Formato";
            // 
            // clrPoint
            // 
            this.clrPoint.AnyColor = true;
            this.clrPoint.FullOpen = true;
            // 
            // btnPointColor
            // 
            this.btnPointColor.Location = new System.Drawing.Point(27, 72);
            this.btnPointColor.Name = "btnPointColor";
            this.btnPointColor.Size = new System.Drawing.Size(97, 25);
            this.btnPointColor.TabIndex = 0;
            this.btnPointColor.Text = "Cambiar color";
            this.btnPointColor.UseVisualStyleBackColor = true;
            this.btnPointColor.Click += new System.EventHandler(this.btnPointColor_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Color del punto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPointColor
            // 
            this.pnlPointColor.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlPointColor.Location = new System.Drawing.Point(27, 38);
            this.pnlPointColor.Name = "pnlPointColor";
            this.pnlPointColor.Size = new System.Drawing.Size(97, 28);
            this.pnlPointColor.TabIndex = 2;
            // 
            // pnlLineColor
            // 
            this.pnlLineColor.BackColor = System.Drawing.Color.Black;
            this.pnlLineColor.Location = new System.Drawing.Point(146, 38);
            this.pnlLineColor.Name = "pnlLineColor";
            this.pnlLineColor.Size = new System.Drawing.Size(97, 28);
            this.pnlLineColor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(143, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color de la línea";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(146, 72);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(97, 25);
            this.btnLineColor.TabIndex = 3;
            this.btnLineColor.Text = "Cambiar color";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // clrLine
            // 
            this.clrLine.FullOpen = true;
            // 
            // btnClearDraw
            // 
            this.btnClearDraw.Location = new System.Drawing.Point(130, 35);
            this.btnClearDraw.Name = "btnClearDraw";
            this.btnClearDraw.Size = new System.Drawing.Size(96, 45);
            this.btnClearDraw.TabIndex = 2;
            this.btnClearDraw.Text = "Clear Panel";
            this.btnClearDraw.UseVisualStyleBackColor = true;
            this.btnClearDraw.Click += new System.EventHandler(this.btnClearDraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica1.Properties.Resources.wallpaper_itt;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
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
            this.gbxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawZone)).EndInit();
            this.gbxControls.ResumeLayout(false);
            this.gbxFormat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ColorDialog clrPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPointColor;
        private System.Windows.Forms.Panel pnlLineColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Panel pnlPointColor;
        private System.Windows.Forms.ColorDialog clrLine;
        private System.Windows.Forms.Button btnClearDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

