
namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    partial class FrmAddMedication
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblHeaders = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtScientificName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSellingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAlertQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpProduction = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblHeaders);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.txtScientificName);
            this.pnlMain.Controls.Add(this.txtCode);
            this.pnlMain.Controls.Add(this.txtType);
            this.pnlMain.Controls.Add(this.txtPurchasePrice);
            this.pnlMain.Controls.Add(this.txtSellingPrice);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.txtAlertQty);
            this.pnlMain.Controls.Add(this.dtpProduction);
            this.pnlMain.Controls.Add(this.dtpExpiry);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Radius = 5;
            this.pnlMain.ShadowColor = System.Drawing.Color.Black;
            this.pnlMain.Size = new System.Drawing.Size(600, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // lblHeaders
            // 
            this.lblHeaders.AutoSize = true;
            this.lblHeaders.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaders.Location = new System.Drawing.Point(220, 20);
            this.lblHeaders.Name = "lblHeaders";
            this.lblHeaders.Size = new System.Drawing.Size(150, 45);
            this.lblHeaders.TabIndex = 0;
            this.lblHeaders.Text = "بيانات الدواء";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(12, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "اسم الدواء";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(576, 64);
            this.txtName.TabIndex = 1;
            // 
            // txtScientificName
            // 
            this.txtScientificName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScientificName.DefaultText = "";
            this.txtScientificName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScientificName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScientificName.Location = new System.Drawing.Point(12, 169);
            this.txtScientificName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtScientificName.Name = "txtScientificName";
            this.txtScientificName.PlaceholderText = "الاسم العلمي";
            this.txtScientificName.SelectedText = "";
            this.txtScientificName.Size = new System.Drawing.Size(576, 64);
            this.txtScientificName.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Location = new System.Drawing.Point(310, 252);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceholderText = "الباركود / الكود";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(270, 64);
            this.txtCode.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtType.Location = new System.Drawing.Point(12, 252);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtType.Name = "txtType";
            this.txtType.PlaceholderText = "النوع (أقراص, شراب...)";
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(275, 64);
            this.txtType.TabIndex = 4;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "";
            this.txtPurchasePrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPurchasePrice.Location = new System.Drawing.Point(310, 341);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "سعر الشراء";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(270, 64);
            this.txtPurchasePrice.TabIndex = 5;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.DefaultText = "";
            this.txtSellingPrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSellingPrice.Location = new System.Drawing.Point(12, 341);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderText = "سعر البيع";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(275, 64);
            this.txtSellingPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.Location = new System.Drawing.Point(310, 427);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "الكمية";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(270, 64);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtAlertQty
            // 
            this.txtAlertQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlertQty.DefaultText = "";
            this.txtAlertQty.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlertQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlertQty.Location = new System.Drawing.Point(12, 427);
            this.txtAlertQty.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAlertQty.Name = "txtAlertQty";
            this.txtAlertQty.PlaceholderText = "حد التنبيه";
            this.txtAlertQty.SelectedText = "";
            this.txtAlertQty.Size = new System.Drawing.Size(275, 64);
            this.txtAlertQty.TabIndex = 8;
            // 
            // dtpProduction
            // 
            this.dtpProduction.Checked = true;
            this.dtpProduction.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpProduction.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpProduction.Location = new System.Drawing.Point(310, 510);
            this.dtpProduction.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProduction.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProduction.Name = "dtpProduction";
            this.dtpProduction.Size = new System.Drawing.Size(270, 40);
            this.dtpProduction.TabIndex = 9;
            this.dtpProduction.Value = new System.DateTime(2025, 12, 6, 22, 32, 36, 163);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Checked = true;
            this.dtpExpiry.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpiry.Location = new System.Drawing.Point(17, 510);
            this.dtpExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(270, 40);
            this.dtpExpiry.TabIndex = 10;
            this.dtpExpiry.Value = new System.DateTime(2025, 12, 6, 22, 32, 36, 199);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(144, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(144, 638);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(300, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddMedication";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMain;
        private System.Windows.Forms.Label lblHeaders;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtScientificName;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private Guna.UI2.WinForms.Guna2TextBox txtSellingPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtAlertQty;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProduction;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiry;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
