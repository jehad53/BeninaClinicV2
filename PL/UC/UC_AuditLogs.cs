using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL.Clinic;
using BeninaClinic.BL.GeneralFunction;

namespace BeninaClinic.PL.UC
{
    public partial class UC_AuditLogs : UserControl
    {
        AuditLogManagement _auditInfo = new AuditLogManagement();
        int CurrentPage = 1;
        int PageSize = 20;
        int TotalPages = 0;
        public UC_AuditLogs()
        {
            InitializeComponent();
        }

        private void UC_AuditLogs_Load(object sender, EventArgs e)
        {
            TotalPages = MainFunction.GetTotalPagesGeneral("AuditLogs", PageSize);
            LoadPage();
        }

        private void LoadLogs()
        {
            try
            {
               
                DateTime? from = dtpFrom.Value.Date;
                DateTime? to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); // End of day

                int? userId = null;
                int uid;
                if (int.TryParse(txtUserId.Text, out uid))
                {
                    userId = uid;
                }

                string actionType = null;
                if (cmbActionType.SelectedIndex > 0)
                {
                    actionType = cmbActionType.Text;
                }

               // string tableName = string.IsNullOrWhiteSpace(txtTableName.Text) ? null : txtTableName.Text;
                dgvLogs.AutoGenerateColumns = true; 
                dgvLogs.DataSource = _auditInfo.GetLogs(); 
                
                // Styling if needed
                 dgvLogs.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("خطأ في تحميل السجلات: " + ex.Message, "Audit Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPage()
        {
            MainFunction.LoadPagedDataGeneral(
                dgvLogs,
                "AuditLogs",
                "LogId",
                CurrentPage,
                PageSize);

            lblPage.Text = $"Page {CurrentPage} of {TotalPages}";

            btnPrevious.Enabled = CurrentPage > 1;
            btnNext.Enabled = CurrentPage < TotalPages;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

         private void btnPrint_Click(object sender, EventArgs e)
        {
              MessageBox.Show("الطباعة غير متوفرة حالياً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                LoadPage();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                LoadPage();
            }
        }
    }
}
