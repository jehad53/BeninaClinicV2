namespace BeninaClinic.PL.UC.UCClinic
{
    partial class UCDose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDose));
            this.dgvDoses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchDose = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDose = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditDose = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDose = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshChronic = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintChronic = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtChronicNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoses)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoses
            // 
            this.dgvDoses.AllowUserToAddRows = false;
            this.dgvDoses.AllowUserToDeleteRows = false;
            this.dgvDoses.AllowUserToResizeColumns = false;
            this.dgvDoses.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvDoses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoses.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDoses.EnableHeadersVisualStyles = false;
            this.dgvDoses.Location = new System.Drawing.Point(9, 411);
            this.dgvDoses.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvDoses.MultiSelect = false;
            this.dgvDoses.Name = "dgvDoses";
            this.dgvDoses.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDoses.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDoses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDoses.RowTemplate.Height = 40;
            this.dgvDoses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoses.Size = new System.Drawing.Size(827, 232);
            this.dgvDoses.TabIndex = 65;
            this.dgvDoses.DoubleClick += new System.EventHandler(this.dgvDoses_DoubleClick);
            this.dgvDoses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDoses_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dose_Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "رقم الجرعة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "DoseName";
            this.Column2.HeaderText = "اسم الجرعة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.label4.Text = "رقم الجرعة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDoseID
            // 
            this.txtDoseID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoseID.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDoseID.BorderRadius = 6;
            this.txtDoseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoseID.DefaultText = "";
            this.txtDoseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoseID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoseID.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.txtDoseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoseID.Location = new System.Drawing.Point(517, 28);
            this.txtDoseID.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtDoseID.Name = "txtDoseID";
            this.txtDoseID.PlaceholderText = "";
            this.txtDoseID.ReadOnly = true;
            this.txtDoseID.SelectedText = "";
            this.txtDoseID.Size = new System.Drawing.Size(111, 37);
            this.txtDoseID.TabIndex = 48;
            this.txtDoseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.Text = "اسم الجرعة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDoseName
            // 
            this.txtDoseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoseName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDoseName.BorderRadius = 6;
            this.txtDoseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoseName.DefaultText = "";
            this.txtDoseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoseName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoseName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoseName.Location = new System.Drawing.Point(64, 28);
            this.txtDoseName.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtDoseName.Name = "txtDoseName";
            this.txtDoseName.PlaceholderText = "";
            this.txtDoseName.SelectedText = "";
            this.txtDoseName.Size = new System.Drawing.Size(269, 37);
            this.txtDoseName.TabIndex = 50;
            this.txtDoseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoseName_KeyDown);
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
            this.label2.Text = "وصف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(643, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(573, 341);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 48);
            this.label12.TabIndex = 66;
            this.label12.Text = "قائمة الجرعات";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "توضيح";
            // 
            // txtSearchDose
            // 
            this.txtSearchDose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDose.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchDose.BorderRadius = 6;
            this.txtSearchDose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDose.DefaultText = "";
            this.txtSearchDose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchDose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchDose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchDose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchDose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDose.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchDose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchDose.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchDose.IconLeft")));
            this.txtSearchDose.Location = new System.Drawing.Point(26, 352);
            this.txtSearchDose.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtSearchDose.Name = "txtSearchDose";
            this.txtSearchDose.PlaceholderText = "";
            this.txtSearchDose.SelectedText = "";
            this.txtSearchDose.Size = new System.Drawing.Size(398, 37);
            this.txtSearchDose.TabIndex = 68;
            this.txtSearchDose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSearchDose, "يمكن البحث بواسطة الاسم او الرقم الوطني");
            this.txtSearchDose.TextChanged += new System.EventHandler(this.txtSearchDose_TextChanged);
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
            this.flowLayoutPanel1.Controls.Add(this.btnAddDose);
            this.flowLayoutPanel1.Controls.Add(this.btnEditDose);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteDose);
            this.flowLayoutPanel1.Controls.Add(this.btnRefreshChronic);
            this.flowLayoutPanel1.Controls.Add(this.btnPrintChronic);
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
            this.btnNew.Location = new System.Drawing.Point(637, 14);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(170, 44);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAddDose
            // 
            this.btnAddDose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDose.Animated = true;
            this.btnAddDose.AnimatedGIF = true;
            this.btnAddDose.BorderRadius = 6;
            this.btnAddDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAddDose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDose.ForeColor = System.Drawing.Color.White;
            this.btnAddDose.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnAddDose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddDose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnAddDose.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDose.Image")));
            this.btnAddDose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddDose.Location = new System.Drawing.Point(459, 14);
            this.btnAddDose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddDose.Name = "btnAddDose";
            this.btnAddDose.Size = new System.Drawing.Size(170, 44);
            this.btnAddDose.TabIndex = 15;
            this.btnAddDose.Text = "إضافة";
            this.btnAddDose.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnEditDose
            // 
            this.btnEditDose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDose.Animated = true;
            this.btnEditDose.AnimatedGIF = true;
            this.btnEditDose.BorderRadius = 6;
            this.btnEditDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEditDose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditDose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditDose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDose.ForeColor = System.Drawing.Color.White;
            this.btnEditDose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEditDose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnEditDose.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDose.Image")));
            this.btnEditDose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditDose.Location = new System.Drawing.Point(283, 14);
            this.btnEditDose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnEditDose.Name = "btnEditDose";
            this.btnEditDose.Size = new System.Drawing.Size(168, 44);
            this.btnEditDose.TabIndex = 16;
            this.btnEditDose.Text = "تعديل";
            this.btnEditDose.Click += new System.EventHandler(this.btnEditTest_Click);
            // 
            // btnDeleteDose
            // 
            this.btnDeleteDose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDose.Animated = true;
            this.btnDeleteDose.AnimatedGIF = true;
            this.btnDeleteDose.BorderRadius = 6;
            this.btnDeleteDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDeleteDose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteDose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteDose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnDeleteDose.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDose.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteDose.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteDose.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.btnDeleteDose.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDose.Image")));
            this.btnDeleteDose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteDose.Location = new System.Drawing.Point(108, 14);
            this.btnDeleteDose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDeleteDose.Name = "btnDeleteDose";
            this.btnDeleteDose.Size = new System.Drawing.Size(167, 44);
            this.btnDeleteDose.TabIndex = 17;
            this.btnDeleteDose.Text = "حذف";
            this.btnDeleteDose.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // btnRefreshChronic
            // 
            this.btnRefreshChronic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshChronic.Animated = true;
            this.btnRefreshChronic.AnimatedGIF = true;
            this.btnRefreshChronic.BorderRadius = 6;
            this.btnRefreshChronic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshChronic.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRefreshChronic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshChronic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshChronic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshChronic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshChronic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnRefreshChronic.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshChronic.ForeColor = System.Drawing.Color.White;
            this.btnRefreshChronic.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshChronic.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRefreshChronic.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshChronic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(197)))), ((int)(((byte)(127)))));
            this.btnRefreshChronic.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshChronic.Image")));
            this.btnRefreshChronic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefreshChronic.Location = new System.Drawing.Point(637, 72);
            this.btnRefreshChronic.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnRefreshChronic.Name = "btnRefreshChronic";
            this.btnRefreshChronic.Size = new System.Drawing.Size(170, 44);
            this.btnRefreshChronic.TabIndex = 20;
            this.btnRefreshChronic.Text = "تحديث القائمة";
            this.btnRefreshChronic.Click += new System.EventHandler(this.btnRefreshTest_Click);
            // 
            // btnPrintChronic
            // 
            this.btnPrintChronic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintChronic.Animated = true;
            this.btnPrintChronic.AnimatedGIF = true;
            this.btnPrintChronic.BorderRadius = 6;
            this.btnPrintChronic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintChronic.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnPrintChronic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintChronic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintChronic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintChronic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintChronic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintChronic.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintChronic.ForeColor = System.Drawing.Color.White;
            this.btnPrintChronic.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintChronic.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrintChronic.HoverState.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintChronic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.btnPrintChronic.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintChronic.Image")));
            this.btnPrintChronic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrintChronic.Location = new System.Drawing.Point(442, 72);
            this.btnPrintChronic.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnPrintChronic.Name = "btnPrintChronic";
            this.btnPrintChronic.Size = new System.Drawing.Size(187, 44);
            this.btnPrintChronic.TabIndex = 18;
            this.btnPrintChronic.Text = "طباعة القائمة";
            this.btnPrintChronic.Click += new System.EventHandler(this.btnPrintTest_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(630, 12);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(207, 38);
            this.lblUserName.TabIndex = 62;
            this.lblUserName.Text = "جرعات الأدوية";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            this.pnlLine.Location = new System.Drawing.Point(654, 58);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(191, 2);
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
            this.guna2GroupBox2.Text = "بيانات المـرض";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDoseID);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtDoseName);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtChronicNote);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 47);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(819, 76);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // txtChronicNote
            // 
            this.txtChronicNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChronicNote.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtChronicNote.BorderRadius = 6;
            this.txtChronicNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChronicNote.DefaultText = "";
            this.txtChronicNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChronicNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChronicNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChronicNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChronicNote.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtChronicNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChronicNote.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChronicNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChronicNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChronicNote.Location = new System.Drawing.Point(427, 107);
            this.txtChronicNote.Margin = new System.Windows.Forms.Padding(6, 21, 6, 21);
            this.txtChronicNote.Name = "txtChronicNote";
            this.txtChronicNote.PlaceholderText = "";
            this.txtChronicNote.SelectedText = "";
            this.txtChronicNote.Size = new System.Drawing.Size(269, 37);
            this.txtChronicNote.TabIndex = 54;
            this.txtChronicNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChronicNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChronicNote_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Cairo SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(444, 348);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(114, 46);
            this.label13.TabIndex = 69;
            this.label13.Text = "البحث";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDoses);
            this.Controls.Add(this.txtSearchDose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "UCDose";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(843, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoses)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoses;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDoseID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDoseName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchDose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnAddDose;
        private Guna.UI2.WinForms.Guna2Button btnEditDose;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDose;
        private Guna.UI2.WinForms.Guna2Button btnRefreshChronic;
        private Guna.UI2.WinForms.Guna2Button btnPrintChronic;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlLine;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtChronicNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
