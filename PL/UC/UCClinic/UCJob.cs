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
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCJob: UserControl
    {
        public UCJob()
        {
            InitializeComponent();
            dgvJobs.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnJob.Enabled = false;
            btnEditJob.Enabled = false;
            btnDeleteJob.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtJobID.Text = MainFunction.GetMaxID("tblJobs", "Job_Id").ToString();
            txtJobName.Clear();
            btnNew.Enabled = false;
            btnJob.Enabled = true;
            btnEditJob.Enabled = false;
            btnDeleteJob.Enabled = false;
            txtJobName.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
    
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {

        }

        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtJobID.Text = dgvJobs.CurrentRow.Cells[0].Value.ToString();
                txtJobName.Text = dgvJobs.CurrentRow.Cells[1].Value.ToString();
                cmbDepartment.Text = dgvJobs.CurrentRow.Cells[2].Value.ToString();
                btnNew.Enabled = true;
                btnJob.Enabled = false;
                btnEditJob.Enabled = true;
                btnDeleteJob.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        public void LoadData()
        {
            try
            { 
            JobManagement jobmanagement = new JobManagement();
            dgvJobs.AutoGenerateColumns = false;
            dgvJobs.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
            dgvJobs.DataSource = jobmanagement.GetAllJobs();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الوظائف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintDepartments_Click(object sender, EventArgs e)
        {

        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobID.Text) || string.IsNullOrWhiteSpace(txtJobName.Text) || string.IsNullOrWhiteSpace(cmbDepartment.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                JobManagement jobmanagement = new JobManagement();
                jobmanagement.InsertJob(txtJobName.Text,Convert.ToInt32(cmbDepartment.SelectedValue));
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobID.Text) || string.IsNullOrWhiteSpace(txtJobName.Text) || string.IsNullOrWhiteSpace(cmbDepartment.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                JobManagement jobmanagement = new JobManagement();
                jobmanagement.EditJob( Convert.ToInt32(txtJobID.Text),txtJobName.Text, Convert.ToInt32(cmbDepartment.SelectedValue));
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnRefreshJob_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الوظائف ", " تحديث قائمة الوظائف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Text = "هل تريد بالفعل حذف الوظيفة المحددة ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvJobs.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (result == DialogResult.Yes)
                { 
                    JobManagement jobmanagement = new JobManagement();
                    jobmanagement.DeleteJob(Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الوظائف ", " حذف قسم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintJobs_Click(object sender, EventArgs e)
        {
            if (dgvJobs.Rows.Count == 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                return;
            }

            try
            {
                RptListJobs rptJobs = new RptListJobs();
                rptJobs.Refresh();
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptJobs;
                frmrpt.Show();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void txtSearchJob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                JobManagement jobmanagement = new JobManagement();
                dgvJobs.DataSource = jobmanagement.SearchJob(txtSearchJob.Text);
            }
            catch
            {
                return;
            }
        }

        private void txtJobName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDepartment.Focus();
            }
        }

        private void cmbDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnJob.Enabled)
            {
                btnJob.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter && btnEditJob.Enabled)
            {
                btnEditJob.PerformClick();
            }
        }
    }
}