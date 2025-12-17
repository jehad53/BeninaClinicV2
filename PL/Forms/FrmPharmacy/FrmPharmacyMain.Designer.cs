
namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    partial class FrmPharmacyMain
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
            this.pnlMenu = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDispense = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDispenseHistory = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnDispenseHistory);
            this.pnlMenu.Controls.Add(this.guna2Button1);
            this.pnlMenu.Controls.Add(this.btnClose);
            this.pnlMenu.Controls.Add(this.btnDispense);
            this.pnlMenu.Controls.Add(this.btnInventory);
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.FillColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Radius = 10;
            this.pnlMenu.ShadowColor = System.Drawing.Color.Black;
            this.pnlMenu.Size = new System.Drawing.Size(600, 366);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 5;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(555, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDispense
            // 
            this.btnDispense.Animated = true;
            this.btnDispense.BorderRadius = 10;
            this.btnDispense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnDispense.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispense.ForeColor = System.Drawing.Color.White;
            this.btnDispense.Location = new System.Drawing.Point(315, 99);
            this.btnDispense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(188, 122);
            this.btnDispense.TabIndex = 2;
            this.btnDispense.Text = "صرف الأدوية\r\n(Dispensing)";
            this.btnDispense.Click += new System.EventHandler(this.btnDispense_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Animated = true;
            this.btnInventory.BorderRadius = 10;
            this.btnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(80)))));
            this.btnInventory.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(98, 99);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(188, 122);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "إدارة الأدوية\r\n(Inventory)";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(225, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نظام الصيدلية";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(315, 233);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(188, 122);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "صرف عام";
            // 
            // btnDispenseHistory
            // 
            this.btnDispenseHistory.Animated = true;
            this.btnDispenseHistory.BorderRadius = 10;
            this.btnDispenseHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(80)))));
            this.btnDispenseHistory.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispenseHistory.ForeColor = System.Drawing.Color.White;
            this.btnDispenseHistory.Location = new System.Drawing.Point(98, 233);
            this.btnDispenseHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispenseHistory.Name = "btnDispenseHistory";
            this.btnDispenseHistory.Size = new System.Drawing.Size(188, 122);
            this.btnDispenseHistory.TabIndex = 5;
            this.btnDispenseHistory.Text = "سجل الصرف";
            this.btnDispenseHistory.Click += new System.EventHandler(this.btnDispenseHistory_Click);
            // 
            // FrmPharmacyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPharmacyMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Main";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnDispense;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnDispenseHistory;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
