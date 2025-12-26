namespace BeninaClinic.PL.UC.UCClinic
{
    partial class UCMedicine
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMedicine));
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicineID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtScinceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedicineType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.AllowUserToResizeColumns = false;
            this.dgvMedicines.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicines.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMedicines.EnableHeadersVisualStyles = false;
            this.dgvMedicines.Location = new System.Drawing.Point(9, 411);
            this.dgvMedicines.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvMedicines.MultiSelect = false;
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicines.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMedicines.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMedicines.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMedicines.RowTemplate.Height = 40;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(827, 232);
            this.dgvMedicines.TabIndex = 65;
            this.dgvMedicines.DoubleClick += new System.EventHandler(this.dgvMedicines_DoubleClick);
            this.dgvMedicines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDiagonses_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Medicine_Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "رقم الدواء";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MedicineName";
            this.Column2.HeaderText = "اسم الدواء";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ScienceName";
            this.Column3.HeaderText = "الاسم العلمي";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.HeaderText = "النوع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(680, 7);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(128, 45);
            this.label4.TabIndex = 49;
            this.label4.Text = "رقم الدواء";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicineID.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMedicineID.BorderRadius = 6;
            this.txtMedicineID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineID.DefaultText = "";
            this.txtMedicineID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedicineID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineID.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.txtMedicineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineID.Location = new System.Drawing.Point(576, 16);
            this.txtMedicineID.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.PlaceholderText = "";
            this.txtMedicineID.ReadOnly = true;
            this.txtMedicineID.SelectedText = "";
            this.txtMedicineID.Size = new System.Drawing.Size(97, 37);
            this.txtMedicineID.TabIndex = 48;
            this.txtMedicineID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(430, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 51;
            this.label1.Text = "اسم الدواء";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicineName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMedicineName.BorderRadius = 6;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Location = new System.Drawing.Point(232, 16);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PlaceholderText = "";
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(191, 37);
            this.txtMedicineName.TabIndex = 50;
            this.txtMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedicineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedicineName_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(65, 7);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(160, 45);
            this.label2.TabIndex = 53;
            this.label2.Text = "الاسم العلمي";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(705, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 2);
            this.panel1.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(667, 341);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 48);
            this.label12.TabIndex = 66;
            this.label12.Text = "قائمة الأدوية";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "توضيح";
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMedicine.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchMedicine.BorderRadius = 6;
            this.txtSearchMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMedicine.DefaultText = "";
            this.txtSearchMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedicine.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedicine.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedicine.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchMedicine.IconLeft")));
            this.txtSearchMedicine.Location = new System.Drawing.Point(82, 352);
            this.txtSearchMedicine.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.PlaceholderText = "";
            this.txtSearchMedicine.SelectedText = "";
            this.txtSearchMedicine.Size = new System.Drawing.Size(334, 37);
            this.txtSearchMedicine.TabIndex = 68;
            this.txtSearchMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSearchMedicine, "يمكن البحث بواسطة الاسم او الرقم الوطني");
            this.txtSearchMedicine.TextChanged += new System.EventHandler(this.txtSearchDiagnose_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 69);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.guna2GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox1.Size = new System.Drawing.Size(827, 118);
            this.guna2GroupBox1.TabIndex = 63;
            this.guna2GroupBox1.Text = "العمليات";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnAddMedicine);
            this.flowLayoutPanel1.Controls.Add(this.btnEditMedicine);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteMedicine);
            this.flowLayoutPanel1.Controls.Add(this.btnRefreshMedicine);
            this.flowLayoutPanel1.Controls.Add(this.btnPrintMedicine);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(819, 64);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Animated = true;
            this.btnNew.AnimatedGIF = true;
            this.btnNew.BorderRadius = 6;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnNew.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnNew.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnNew.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNew.Location = new System.Drawing.Point(654, 14);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 44);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedicine.Animated = true;
            this.btnAddMedicine.AnimatedGIF = true;
            this.btnAddMedicine.BorderRadius = 6;
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnAddMedicine.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMedicine.Location = new System.Drawing.Point(493, 14);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(153, 44);
            this.btnAddMedicine.TabIndex = 15;
            this.btnAddMedicine.Text = "إضافة";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddDiagnose_Click);
            // 
            // btnEditMedicine
            // 
            this.btnEditMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMedicine.Animated = true;
            this.btnEditMedicine.AnimatedGIF = true;
            this.btnEditMedicine.BorderRadius = 6;
            this.btnEditMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEditMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditMedicine.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMedicine.ForeColor = System.Drawing.Color.White;
            this.btnEditMedicine.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEditMedicine.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMedicine.Image")));
            this.btnEditMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditMedicine.Location = new System.Drawing.Point(332, 14);
            this.btnEditMedicine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnEditMedicine.Name = "btnEditMedicine";
            this.btnEditMedicine.Size = new System.Drawing.Size(153, 44);
            this.btnEditMedicine.TabIndex = 16;
            this.btnEditMedicine.Text = "تعديل";
            this.btnEditMedicine.Click += new System.EventHandler(this.btnEditDiagnose_Click);
            // 
            // btnDeleteMedicine
            // 
            this.btnDeleteMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMedicine.Animated = true;
            this.btnDeleteMedicine.AnimatedGIF = true;
            this.btnDeleteMedicine.BorderRadius = 6;
            this.btnDeleteMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDeleteMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnDeleteMedicine.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMedicine.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMedicine.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteMedicine.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMedicine.Image")));
            this.btnDeleteMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteMedicine.Location = new System.Drawing.Point(171, 14);
            this.btnDeleteMedicine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDeleteMedicine.Name = "btnDeleteMedicine";
            this.btnDeleteMedicine.Size = new System.Drawing.Size(153, 44);
            this.btnDeleteMedicine.TabIndex = 17;
            this.btnDeleteMedicine.Text = "حذف";
            this.btnDeleteMedicine.Click += new System.EventHandler(this.btnDeleteDiagnose_Click);
            // 
            // btnRefreshMedicine
            // 
            this.btnRefreshMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshMedicine.Animated = true;
            this.btnRefreshMedicine.AnimatedGIF = true;
            this.btnRefreshMedicine.BorderRadius = 6;
            this.btnRefreshMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRefreshMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnRefreshMedicine.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshMedicine.ForeColor = System.Drawing.Color.White;
            this.btnRefreshMedicine.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRefreshMedicine.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshMedicine.Image")));
            this.btnRefreshMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefreshMedicine.Location = new System.Drawing.Point(585, 72);
            this.btnRefreshMedicine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRefreshMedicine.Name = "btnRefreshMedicine";
            this.btnRefreshMedicine.Size = new System.Drawing.Size(222, 44);
            this.btnRefreshMedicine.TabIndex = 20;
            this.btnRefreshMedicine.Text = "تحديث القائمة";
            this.btnRefreshMedicine.Click += new System.EventHandler(this.btnRefreshDiagnose_Click);
            // 
            // btnPrintMedicine
            // 
            this.btnPrintMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintMedicine.Animated = true;
            this.btnPrintMedicine.AnimatedGIF = true;
            this.btnPrintMedicine.BorderRadius = 6;
            this.btnPrintMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintMedicine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnPrintMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintMedicine.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMedicine.ForeColor = System.Drawing.Color.White;
            this.btnPrintMedicine.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrintMedicine.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMedicine.Image")));
            this.btnPrintMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrintMedicine.Location = new System.Drawing.Point(370, 72);
            this.btnPrintMedicine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnPrintMedicine.Name = "btnPrintMedicine";
            this.btnPrintMedicine.Size = new System.Drawing.Size(207, 44);
            this.btnPrintMedicine.TabIndex = 18;
            this.btnPrintMedicine.Text = "طباعة القائمة";
            this.btnPrintMedicine.Click += new System.EventHandler(this.btnPrintDiagnose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(724, 12);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(112, 38);
            this.lblUserName.TabIndex = 62;
            this.lblUserName.Text = "الأدويــة";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.pnlLine.Location = new System.Drawing.Point(730, 58);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(140, 2);
            this.pnlLine.TabIndex = 61;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.Controls.Add(this.flowLayoutPanel2);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Cairo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(9, 192);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.guna2GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox2.Size = new System.Drawing.Size(827, 130);
            this.guna2GroupBox2.TabIndex = 64;
            this.guna2GroupBox2.Text = "بيانات التشخيص";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtMedicineID);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtMedicineName);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtScinceName);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.cmbMedicineType);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 47);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(819, 76);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // txtScinceName
            // 
            this.txtScinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScinceName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtScinceName.BorderRadius = 6;
            this.txtScinceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScinceName.DefaultText = "";
            this.txtScinceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtScinceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtScinceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScinceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtScinceName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtScinceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScinceName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScinceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScinceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtScinceName.Location = new System.Drawing.Point(601, 71);
            this.txtScinceName.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtScinceName.Name = "txtScinceName";
            this.txtScinceName.PlaceholderText = "";
            this.txtScinceName.SelectedText = "";
            this.txtScinceName.Size = new System.Drawing.Size(206, 37);
            this.txtScinceName.TabIndex = 54;
            this.txtScinceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScinceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScinceName_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(511, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 45);
            this.label3.TabIndex = 55;
            this.label3.Text = "النوع";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMedicineType
            // 
            this.cmbMedicineType.BackColor = System.Drawing.Color.Transparent;
            this.cmbMedicineType.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbMedicineType.BorderRadius = 6;
            this.cmbMedicineType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMedicineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicineType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMedicineType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMedicineType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMedicineType.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbMedicineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMedicineType.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbMedicineType.HoverState.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicineType.ItemHeight = 30;
            this.cmbMedicineType.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.cmbMedicineType.Location = new System.Drawing.Point(381, 65);
            this.cmbMedicineType.Name = "cmbMedicineType";
            this.cmbMedicineType.Size = new System.Drawing.Size(124, 36);
            this.cmbMedicineType.TabIndex = 56;
            this.cmbMedicineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbMedicineType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMedicineType_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(426, 347);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(85, 46);
            this.label13.TabIndex = 69;
            this.label13.Text = "البحث";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.MessageDialog.Caption = "تنبيه";
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.MessageDialog.Parent = null;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageDialog.Text = "تمت العملية بنجاح";
            // 
            // UCMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.txtSearchMedicine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "UCMedicine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(843, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMedicine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnEditMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMedicine;
        private Guna.UI2.WinForms.Guna2Button btnRefreshMedicine;
        private Guna.UI2.WinForms.Guna2Button btnPrintMedicine;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlLine;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtScinceName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMedicineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
    }
}
