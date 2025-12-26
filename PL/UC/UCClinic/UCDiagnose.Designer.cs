namespace BeninaClinic.PL.UC.UCClinic
{
    partial class UCDiagnose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDiagnose));
            this.dgvDiagonses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiagnoseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiagnoseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchDiagnose = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDiagnose = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditDiagnose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDiagnose = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshDiagnose = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintDiagnose = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDiagnoseNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagonses)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiagonses
            // 
            this.dgvDiagonses.AllowUserToAddRows = false;
            this.dgvDiagonses.AllowUserToDeleteRows = false;
            this.dgvDiagonses.AllowUserToResizeColumns = false;
            this.dgvDiagonses.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvDiagonses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiagonses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiagonses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagonses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagonses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDiagonses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagonses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagonses.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDiagonses.EnableHeadersVisualStyles = false;
            this.dgvDiagonses.Location = new System.Drawing.Point(9, 411);
            this.dgvDiagonses.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvDiagonses.MultiSelect = false;
            this.dgvDiagonses.Name = "dgvDiagonses";
            this.dgvDiagonses.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagonses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDiagonses.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDiagonses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDiagonses.RowTemplate.Height = 40;
            this.dgvDiagonses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagonses.Size = new System.Drawing.Size(827, 232);
            this.dgvDiagonses.TabIndex = 65;
            this.dgvDiagonses.DoubleClick += new System.EventHandler(this.dgvDepartments_DoubleClick);
            this.dgvDiagonses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDiagonses_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Diagnosis_Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "رقم التشخيص";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "DiagnosisName";
            this.Column2.HeaderText = "اسم التشخيص";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "الملاحظات";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(637, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(171, 45);
            this.label4.TabIndex = 49;
            this.label4.Text = "رقم التشخيص";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiagnoseID
            // 
            this.txtDiagnoseID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnoseID.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiagnoseID.BorderRadius = 6;
            this.txtDiagnoseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnoseID.DefaultText = "";
            this.txtDiagnoseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiagnoseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiagnoseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnoseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseID.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.txtDiagnoseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnoseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseID.Location = new System.Drawing.Point(517, 28);
            this.txtDiagnoseID.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtDiagnoseID.Name = "txtDiagnoseID";
            this.txtDiagnoseID.PlaceholderText = "";
            this.txtDiagnoseID.ReadOnly = true;
            this.txtDiagnoseID.SelectedText = "";
            this.txtDiagnoseID.Size = new System.Drawing.Size(111, 37);
            this.txtDiagnoseID.TabIndex = 48;
            this.txtDiagnoseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(342, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 51;
            this.label1.Text = "اسم التشخيص";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiagnoseName
            // 
            this.txtDiagnoseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnoseName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiagnoseName.BorderRadius = 6;
            this.txtDiagnoseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnoseName.DefaultText = "";
            this.txtDiagnoseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiagnoseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiagnoseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnoseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnoseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnoseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseName.Location = new System.Drawing.Point(64, 28);
            this.txtDiagnoseName.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtDiagnoseName.Name = "txtDiagnoseName";
            this.txtDiagnoseName.PlaceholderText = "";
            this.txtDiagnoseName.SelectedText = "";
            this.txtDiagnoseName.Size = new System.Drawing.Size(269, 37);
            this.txtDiagnoseName.TabIndex = 50;
            this.txtDiagnoseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiagnoseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiagnoseName_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(706, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 16, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(101, 45);
            this.label2.TabIndex = 53;
            this.label2.Text = "ملاحظات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(630, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(613, 341);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 48);
            this.label12.TabIndex = 66;
            this.label12.Text = "قائمة التشخيصات";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "توضيح";
            // 
            // txtSearchDiagnose
            // 
            this.txtSearchDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDiagnose.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchDiagnose.BorderRadius = 6;
            this.txtSearchDiagnose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDiagnose.DefaultText = "";
            this.txtSearchDiagnose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDiagnose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDiagnose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchDiagnose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDiagnose.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDiagnose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchDiagnose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDiagnose.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchDiagnose.IconLeft")));
            this.txtSearchDiagnose.Location = new System.Drawing.Point(83, 352);
            this.txtSearchDiagnose.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtSearchDiagnose.Name = "txtSearchDiagnose";
            this.txtSearchDiagnose.PlaceholderText = "";
            this.txtSearchDiagnose.SelectedText = "";
            this.txtSearchDiagnose.Size = new System.Drawing.Size(398, 37);
            this.txtSearchDiagnose.TabIndex = 68;
            this.txtSearchDiagnose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSearchDiagnose, "يمكن البحث بواسطة الاسم او الرقم الوطني");
            this.txtSearchDiagnose.TextChanged += new System.EventHandler(this.txtSearchDiagnose_TextChanged);
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
            this.flowLayoutPanel1.Controls.Add(this.btnAddDiagnose);
            this.flowLayoutPanel1.Controls.Add(this.btnEditDiagnose);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteDiagnose);
            this.flowLayoutPanel1.Controls.Add(this.btnRefreshDiagnose);
            this.flowLayoutPanel1.Controls.Add(this.btnPrintDiagnose);
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
            // btnAddDiagnose
            // 
            this.btnAddDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDiagnose.Animated = true;
            this.btnAddDiagnose.AnimatedGIF = true;
            this.btnAddDiagnose.BorderRadius = 6;
            this.btnAddDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiagnose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAddDiagnose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiagnose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDiagnose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDiagnose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiagnose.ForeColor = System.Drawing.Color.White;
            this.btnAddDiagnose.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnAddDiagnose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDiagnose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddDiagnose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiagnose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDiagnose.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiagnose.Image")));
            this.btnAddDiagnose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddDiagnose.Location = new System.Drawing.Point(493, 14);
            this.btnAddDiagnose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddDiagnose.Name = "btnAddDiagnose";
            this.btnAddDiagnose.Size = new System.Drawing.Size(153, 44);
            this.btnAddDiagnose.TabIndex = 15;
            this.btnAddDiagnose.Text = "إضافة";
            this.btnAddDiagnose.Click += new System.EventHandler(this.btnAddDiagnose_Click);
            // 
            // btnEditDiagnose
            // 
            this.btnEditDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDiagnose.Animated = true;
            this.btnEditDiagnose.AnimatedGIF = true;
            this.btnEditDiagnose.BorderRadius = 6;
            this.btnEditDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDiagnose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEditDiagnose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDiagnose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditDiagnose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDiagnose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiagnose.ForeColor = System.Drawing.Color.White;
            this.btnEditDiagnose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDiagnose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEditDiagnose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiagnose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDiagnose.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDiagnose.Image")));
            this.btnEditDiagnose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditDiagnose.Location = new System.Drawing.Point(332, 14);
            this.btnEditDiagnose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnEditDiagnose.Name = "btnEditDiagnose";
            this.btnEditDiagnose.Size = new System.Drawing.Size(153, 44);
            this.btnEditDiagnose.TabIndex = 16;
            this.btnEditDiagnose.Text = "تعديل";
            this.btnEditDiagnose.Click += new System.EventHandler(this.btnEditDiagnose_Click);
            // 
            // btnDeleteDiagnose
            // 
            this.btnDeleteDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDiagnose.Animated = true;
            this.btnDeleteDiagnose.AnimatedGIF = true;
            this.btnDeleteDiagnose.BorderRadius = 6;
            this.btnDeleteDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDiagnose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDeleteDiagnose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDiagnose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDiagnose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnDeleteDiagnose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiagnose.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDiagnose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteDiagnose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteDiagnose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiagnose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteDiagnose.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDiagnose.Image")));
            this.btnDeleteDiagnose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteDiagnose.Location = new System.Drawing.Point(171, 14);
            this.btnDeleteDiagnose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDeleteDiagnose.Name = "btnDeleteDiagnose";
            this.btnDeleteDiagnose.Size = new System.Drawing.Size(153, 44);
            this.btnDeleteDiagnose.TabIndex = 17;
            this.btnDeleteDiagnose.Text = "حذف";
            this.btnDeleteDiagnose.Click += new System.EventHandler(this.btnDeleteDiagnose_Click);
            // 
            // btnRefreshDiagnose
            // 
            this.btnRefreshDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDiagnose.Animated = true;
            this.btnRefreshDiagnose.AnimatedGIF = true;
            this.btnRefreshDiagnose.BorderRadius = 6;
            this.btnRefreshDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDiagnose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRefreshDiagnose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshDiagnose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshDiagnose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnRefreshDiagnose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDiagnose.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDiagnose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshDiagnose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRefreshDiagnose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDiagnose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshDiagnose.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDiagnose.Image")));
            this.btnRefreshDiagnose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefreshDiagnose.Location = new System.Drawing.Point(585, 72);
            this.btnRefreshDiagnose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRefreshDiagnose.Name = "btnRefreshDiagnose";
            this.btnRefreshDiagnose.Size = new System.Drawing.Size(222, 44);
            this.btnRefreshDiagnose.TabIndex = 20;
            this.btnRefreshDiagnose.Text = "تحديث القائمة";
            this.btnRefreshDiagnose.Click += new System.EventHandler(this.btnRefreshDiagnose_Click);
            // 
            // btnPrintDiagnose
            // 
            this.btnPrintDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDiagnose.Animated = true;
            this.btnPrintDiagnose.AnimatedGIF = true;
            this.btnPrintDiagnose.BorderRadius = 6;
            this.btnPrintDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDiagnose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnPrintDiagnose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintDiagnose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintDiagnose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintDiagnose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintDiagnose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintDiagnose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDiagnose.ForeColor = System.Drawing.Color.White;
            this.btnPrintDiagnose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintDiagnose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrintDiagnose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDiagnose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintDiagnose.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDiagnose.Image")));
            this.btnPrintDiagnose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrintDiagnose.Location = new System.Drawing.Point(370, 72);
            this.btnPrintDiagnose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnPrintDiagnose.Name = "btnPrintDiagnose";
            this.btnPrintDiagnose.Size = new System.Drawing.Size(207, 44);
            this.btnPrintDiagnose.TabIndex = 18;
            this.btnPrintDiagnose.Text = "طباعة القائمة";
            this.btnPrintDiagnose.Click += new System.EventHandler(this.btnPrintDiagnose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(680, 13);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 38);
            this.lblUserName.TabIndex = 62;
            this.lblUserName.Text = "التشخيصات";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.pnlLine.Location = new System.Drawing.Point(680, 58);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(165, 2);
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
            this.flowLayoutPanel2.Controls.Add(this.txtDiagnoseID);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtDiagnoseName);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtDiagnoseNote);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 47);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(819, 76);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // txtDiagnoseNote
            // 
            this.txtDiagnoseNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnoseNote.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDiagnoseNote.BorderRadius = 6;
            this.txtDiagnoseNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnoseNote.DefaultText = "";
            this.txtDiagnoseNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiagnoseNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiagnoseNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnoseNote.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiagnoseNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseNote.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnoseNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnoseNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiagnoseNote.Location = new System.Drawing.Point(427, 107);
            this.txtDiagnoseNote.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtDiagnoseNote.Name = "txtDiagnoseNote";
            this.txtDiagnoseNote.PlaceholderText = "";
            this.txtDiagnoseNote.SelectedText = "";
            this.txtDiagnoseNote.Size = new System.Drawing.Size(269, 37);
            this.txtDiagnoseNote.TabIndex = 54;
            this.txtDiagnoseNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiagnoseNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiagnoseNote_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(491, 348);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(114, 46);
            this.label13.TabIndex = 69;
            this.label13.Text = "البحث";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.MessageDialog.Caption = "تأكيد الحذف";
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.MessageDialog.Parent = null;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageDialog.Text = "تمت العملية بنجاح";
            // 
            // UCDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDiagonses);
            this.Controls.Add(this.txtSearchDiagnose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "UCDiagnose";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(843, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagonses)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiagonses;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnoseID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnoseName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDiagnose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnAddDiagnose;
        private Guna.UI2.WinForms.Guna2Button btnEditDiagnose;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDiagnose;
        private Guna.UI2.WinForms.Guna2Button btnRefreshDiagnose;
        private Guna.UI2.WinForms.Guna2Button btnPrintDiagnose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlLine;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnoseNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
    }
}
