namespace BeninaClinic.PL.UC
{
    partial class UC_AuditLogs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBoxFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.cmbActionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.txtUserId = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2GroupBoxFilter.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1100, 72);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "العمليات";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1100, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(955, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.FillColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(825, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 6;
            this.btnPrint.FillColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(695, 10);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // guna2GroupBoxFilter
            // 
            this.guna2GroupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBoxFilter.Controls.Add(this.txtTableName);
            this.guna2GroupBoxFilter.Controls.Add(this.labelTable);
            this.guna2GroupBoxFilter.Controls.Add(this.cmbActionType);
            this.guna2GroupBoxFilter.Controls.Add(this.labelAction);
            this.guna2GroupBoxFilter.Controls.Add(this.txtUserId);
            this.guna2GroupBoxFilter.Controls.Add(this.labelUser);
            this.guna2GroupBoxFilter.Controls.Add(this.dtpTo);
            this.guna2GroupBoxFilter.Controls.Add(this.labelTo);
            this.guna2GroupBoxFilter.Controls.Add(this.dtpFrom);
            this.guna2GroupBoxFilter.Controls.Add(this.labelFrom);
            this.guna2GroupBoxFilter.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBoxFilter.Location = new System.Drawing.Point(3, 81);
            this.guna2GroupBoxFilter.Name = "guna2GroupBoxFilter";
            this.guna2GroupBoxFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBoxFilter.Size = new System.Drawing.Size(1100, 78);
            this.guna2GroupBoxFilter.TabIndex = 1;
            this.guna2GroupBoxFilter.Text = "خيارات البحث";
            this.guna2GroupBoxFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableName.DefaultText = "";
            this.txtTableName.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(3, 42);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PlaceholderText = "اسم الجدول";
            this.txtTableName.SelectedText = "";
            this.txtTableName.Size = new System.Drawing.Size(155, 28);
            this.txtTableName.TabIndex = 0;
            // 
            // labelTable
            // 
            this.labelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTable.Location = new System.Drawing.Point(158, 42);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(83, 28);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "الجدول:";
            this.labelTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbActionType
            // 
            this.cmbActionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActionType.BackColor = System.Drawing.Color.Transparent;
            this.cmbActionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbActionType.Font = new System.Drawing.Font("Cairo", 10.2F);
            this.cmbActionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbActionType.ItemHeight = 30;
            this.cmbActionType.Items.AddRange(new object[] {
            "الكل",
            "Insert",
            "Update",
            "Delete",
            "Login"});
            this.cmbActionType.Location = new System.Drawing.Point(247, 45);
            this.cmbActionType.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(113, 36);
            this.cmbActionType.StartIndex = 0;
            this.cmbActionType.TabIndex = 2;
            this.cmbActionType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAction.Location = new System.Drawing.Point(366, 42);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(74, 28);
            this.labelAction.TabIndex = 3;
            this.labelAction.Text = "الحدث:";
            this.labelAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.DefaultText = "";
            this.txtUserId.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(440, 43);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PlaceholderText = "رقم المستخدم";
            this.txtUserId.SelectedText = "";
            this.txtUserId.Size = new System.Drawing.Size(149, 27);
            this.txtUserId.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.Location = new System.Drawing.Point(589, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(98, 28);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "مستخدم:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Animated = true;
            this.dtpTo.Checked = true;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.White;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(687, 47);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 23);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.Value = new System.DateTime(2025, 12, 12, 16, 46, 14, 108);
            // 
            // labelTo
            // 
            this.labelTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTo.Location = new System.Drawing.Point(837, 42);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(50, 28);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "إلى:";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Animated = true;
            this.dtpFrom.Checked = true;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.White;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(887, 47);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 23);
            this.dtpFrom.TabIndex = 8;
            this.dtpFrom.Value = new System.DateTime(2025, 12, 12, 16, 46, 14, 141);
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrom.Location = new System.Drawing.Point(1037, 42);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(51, 28);
            this.labelFrom.TabIndex = 9;
            this.labelFrom.Text = "من:";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.Controls.Add(this.dgvLogs);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 167);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1100, 440);
            this.guna2GroupBox2.TabIndex = 0;
            this.guna2GroupBox2.Text = "السجلات";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeColumns = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLogs.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(0, 40);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowHeadersWidth = 24;
            this.dgvLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1100, 400);
            this.dgvLogs.TabIndex = 0;
            // 
            // UC_AuditLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBoxFilter);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "UC_AuditLogs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1110, 610);
            this.Load += new System.EventHandler(this.UC_AuditLogs_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2GroupBoxFilter.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxFilter;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DataGridView dgvLogs;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private Guna.UI2.WinForms.Guna2TextBox txtUserId;
        private System.Windows.Forms.Label labelUser;
        private Guna.UI2.WinForms.Guna2ComboBox cmbActionType;
         private System.Windows.Forms.Label labelAction;
         private Guna.UI2.WinForms.Guna2TextBox txtTableName;
         private System.Windows.Forms.Label labelTable;
    }
}
