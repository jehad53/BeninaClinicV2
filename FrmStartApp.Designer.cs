namespace BeninaClinic
{
    partial class FrmStartApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartApp));
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label25 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(0, 255);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.guna2ProgressBar1.Size = new System.Drawing.Size(484, 48);
            this.guna2ProgressBar1.TabIndex = 0;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Value = 30;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(484, 48);
            this.label25.TabIndex = 93;
            this.label25.Text = "منظومة السرية الطبية";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.lblValue.Location = new System.Drawing.Point(16, 208);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(72, 44);
            this.lblValue.TabIndex = 94;
            this.lblValue.Tag = "";
            this.lblValue.Text = "30";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(0, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 44);
            this.label1.TabIndex = 96;
            this.label1.Tag = "30";
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStartApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FrmStartApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStartApp";
            this.Load += new System.EventHandler(this.FrmStartApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblValue;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}