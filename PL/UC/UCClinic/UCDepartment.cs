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
    public partial class UCDepartment : UserControl
    {
        public UCDepartment()
        {
            InitializeComponent();
            dgvDepartments.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            btnAddDepartment.Enabled = false;
            btnEditDepartment.Enabled = false;
            btnDeleteDepartment.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtDepartmentID.Text = MainFunction.GetMaxID("tblDepartments", "Department_Id").ToString();
            txtDepartmentName.Clear();
            txtDepartmentManger.Clear();
            btnNew.Enabled = false;
            btnAddDepartment.Enabled = true;
            btnEditDepartment.Enabled = false;
            btnDeleteDepartment.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentID.Text) || string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DepartmentsManagement departmentsmanagement = new DepartmentsManagement();
                departmentsmanagement.InsertDepartment(txtDepartmentName.Text , txtDepartmentManger.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
               // LoadData();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentID.Text) || string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DepartmentsManagement departmentsmanagement = new DepartmentsManagement();
                departmentsmanagement.EditDepartment(Convert.ToInt32(txtDepartmentID.Text) ,txtDepartmentName.Text, txtDepartmentManger.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                LoadData();
                //  MessageBox.Show("تم تعديل البيانات بنجاح", " تعديل بيانات القسم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTools();
            }
        }

        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtDepartmentID.Text = dgvDepartments.CurrentRow.Cells[0].Value.ToString();
                txtDepartmentName.Text = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
                txtDepartmentManger.Text = dgvDepartments.CurrentRow.Cells[2].Value.ToString();
                btnNew.Enabled = true;
                btnAddDepartment.Enabled = false;
                btnEditDepartment.Enabled = true;
                btnDeleteDepartment.Enabled = true;
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
            DepartmentsManagement departmentsmanagement = new DepartmentsManagement();
            dgvDepartments.AutoGenerateColumns = false;
            dgvDepartments.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
            dgvDepartments.DataSource = departmentsmanagement.GetAllDepartments();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل بيانات الأقسام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartments.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("هل تريد حذف القسم المحدد في قائمة الأقسام بالفعل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DepartmentsManagement departmentsmanagement = new DepartmentsManagement();
                    departmentsmanagement.DeleteDepartment(Convert.ToInt32(dgvDepartments.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الأقسام ", " حذف قسم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefreshDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الأقسام ", " تحديث قائمة بيانات الأقسام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintDepartments_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.Rows.Count == 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                return;
            }

            try
            {
                RptListDepartments rptDepartments  = new RptListDepartments();
                rptDepartments.Refresh();
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptDepartments;
                frmrpt.Show();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void btnPrintJobs_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchDepartments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DepartmentsManagement departmentsmanagement = new DepartmentsManagement();
                dgvDepartments.DataSource = departmentsmanagement.SearchDepartment(txtSearchDepartments.Text);
            }
            catch
            {
                return;
            }
        }
    }
}