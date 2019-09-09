namespace Cronometro
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuWindows = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new ns1.BunifuImageButton();
            this.ButtonStart = new ns1.BunifuFlatButton();
            this.ButtonPause = new ns1.BunifuFlatButton();
            this.ButtonStop = new ns1.BunifuFlatButton();
            this.LabelCronometer = new ns1.BunifuCustomLabel();
            this.TimeWork = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuWindows
            // 
            this.bunifuWindows.ElipseRadius = 6;
            this.bunifuWindows.TargetControl = this;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panel1;
            this.bunifuDragControl.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 31);
            this.panel1.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(601, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 5;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonStart.BackColor = System.Drawing.Color.Green;
            this.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonStart.BorderRadius = 0;
            this.ButtonStart.ButtonText = "Start";
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonStart.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonStart.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonStart.Iconimage")));
            this.ButtonStart.Iconimage_right = null;
            this.ButtonStart.Iconimage_right_Selected = null;
            this.ButtonStart.Iconimage_Selected = null;
            this.ButtonStart.IconMarginLeft = 0;
            this.ButtonStart.IconMarginRight = 0;
            this.ButtonStart.IconRightVisible = true;
            this.ButtonStart.IconRightZoom = 0D;
            this.ButtonStart.IconVisible = true;
            this.ButtonStart.IconZoom = 40D;
            this.ButtonStart.IsTab = false;
            this.ButtonStart.Location = new System.Drawing.Point(159, 145);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Normalcolor = System.Drawing.Color.Green;
            this.ButtonStart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonStart.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonStart.selected = false;
            this.ButtonStart.Size = new System.Drawing.Size(108, 39);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonStart.Textcolor = System.Drawing.Color.White;
            this.ButtonStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPause.BorderRadius = 0;
            this.ButtonPause.ButtonText = "Pause";
            this.ButtonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPause.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonPause.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonPause.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonPause.Iconimage")));
            this.ButtonPause.Iconimage_right = null;
            this.ButtonPause.Iconimage_right_Selected = null;
            this.ButtonPause.Iconimage_Selected = null;
            this.ButtonPause.IconMarginLeft = 0;
            this.ButtonPause.IconMarginRight = 0;
            this.ButtonPause.IconRightVisible = true;
            this.ButtonPause.IconRightZoom = 0D;
            this.ButtonPause.IconVisible = true;
            this.ButtonPause.IconZoom = 40D;
            this.ButtonPause.IsTab = false;
            this.ButtonPause.Location = new System.Drawing.Point(273, 145);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonPause.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonPause.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonPause.selected = false;
            this.ButtonPause.Size = new System.Drawing.Size(108, 39);
            this.ButtonPause.TabIndex = 0;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonPause.Textcolor = System.Drawing.Color.White;
            this.ButtonPause.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonStop.BackColor = System.Drawing.Color.Maroon;
            this.ButtonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonStop.BorderRadius = 0;
            this.ButtonStop.ButtonText = "Reiniciar";
            this.ButtonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStop.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonStop.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonStop.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonStop.Iconimage")));
            this.ButtonStop.Iconimage_right = null;
            this.ButtonStop.Iconimage_right_Selected = null;
            this.ButtonStop.Iconimage_Selected = null;
            this.ButtonStop.IconMarginLeft = 0;
            this.ButtonStop.IconMarginRight = 0;
            this.ButtonStop.IconRightVisible = true;
            this.ButtonStop.IconRightZoom = 0D;
            this.ButtonStop.IconVisible = true;
            this.ButtonStop.IconZoom = 40D;
            this.ButtonStop.IsTab = false;
            this.ButtonStop.Location = new System.Drawing.Point(387, 145);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Normalcolor = System.Drawing.Color.Maroon;
            this.ButtonStop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonStop.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonStop.selected = false;
            this.ButtonStop.Size = new System.Drawing.Size(109, 39);
            this.ButtonStop.TabIndex = 0;
            this.ButtonStop.Text = "Reiniciar";
            this.ButtonStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonStop.Textcolor = System.Drawing.Color.White;
            this.ButtonStop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // LabelCronometer
            // 
            this.LabelCronometer.AutoSize = true;
            this.LabelCronometer.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCronometer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelCronometer.Location = new System.Drawing.Point(209, 69);
            this.LabelCronometer.Name = "LabelCronometer";
            this.LabelCronometer.Size = new System.Drawing.Size(206, 46);
            this.LabelCronometer.TabIndex = 1;
            this.LabelCronometer.Text = "00:00:00";
            this.LabelCronometer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimeWork
            // 
            this.TimeWork.Interval = 1000;
            this.TimeWork.Tick += new System.EventHandler(this.TimeTicker);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(630, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCronometer);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuWindows;
        private ns1.BunifuDragControl bunifuDragControl;
        private ns1.BunifuFlatButton ButtonStart;
        private ns1.BunifuFlatButton ButtonStop;
        private ns1.BunifuFlatButton ButtonPause;
        private ns1.BunifuCustomLabel LabelCronometer;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton CloseButton;
        private System.Windows.Forms.Timer TimeWork;
    }
}

