using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL;
using BeninaClinic.BL.GeneralFunction;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCUsers : UserControl
    {
        public UCUsers()
        {
            InitializeComponent();
            btnAddUser.Enabled = false;
            btnEditUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            LoadUser();
        }

        private void rdbAsassi_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void ClearTools()
        {
            txtUserID.Text = MainFunction.GetMaxID("tblUsers", "UserId").ToString();
            txtFullName.Clear();
            txtUserName.Clear();
            txtUserPass.Clear();
            btnNew.Enabled = false;
            btnAddUser.Enabled = true;
            btnEditUser.Enabled = false;
            btnDeleteUser.Enabled = false;

            CBClinics.Checked = false;
            CBDoctors.Checked = false;
            CBPatients.Checked = false;
            CBAppointment.Checked = false;
            CBVisits.Checked = false;
            CBDiagnosis.Checked = false;
            CBTests.Checked = false;
            CBChronics.Checked = false;
            CBMedicenReport.Checked = false;
            CBDose.Checked = false;
            CBDepartments.Checked = false;
            CBJobs.Checked = false;
            CBEmployees.Checked = false;
            CBUsers.Checked = false;
            CBSettings.Checked = false;
            CBMedince.Checked = false;
            CBRecordPatient.Checked = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }


        public void LoadUser()
        {
            try
            {
                UserManagement usermanagement = new UserManagement();
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvUsers.DataSource = usermanagement.GetAllUsers();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل المستخدمين", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtUserID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
                txtFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtUserName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                txtUserPass.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                cmbUserType.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
                if (dgvUsers.CurrentRow.Cells[5].Value.ToString() == "True")
                {
                    rdbActive.Checked = true;
                }
                else 
                {
                    rdbNotActive.Checked = true;
                }

                CBClinics.Checked =Convert.ToBoolean(dgvUsers.CurrentRow.Cells[6].Value);
                CBDoctors.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[7].Value);
                CBPatients.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[8].Value);
                CBAppointment.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[9].Value);
                CBVisits.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[10].Value);
                CBDiagnosis.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[11].Value);
                CBTests.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[12].Value);
                CBChronics.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[13].Value);
                CBMedicenReport.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[14].Value);
                CBDose.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[15].Value);
                CBDepartments.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[16].Value);
                CBJobs.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[17].Value);
                CBEmployees.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[18].Value);
                CBUsers.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[19].Value);
                CBSettings.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[20].Value);
                CBMedince.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[21].Value);
                CBRecordPatient.Checked = Convert.ToBoolean(dgvUsers.CurrentRow.Cells[22].Value);

                btnNew.Enabled = true;
                btnAddUser.Enabled = false;
                btnEditUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPass.Text) || string.IsNullOrWhiteSpace(cmbUserType.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                bool isActive = rdbActive.Checked ? true : false ; 
                UserManagement UserManagement = new UserManagement();
                UserManagement.InsertUser(txtFullName.Text,txtUserName.Text ,txtUserPass.Text, cmbUserType.Text , isActive , CBClinics.Checked,CBDoctors.Checked,CBPatients.Checked, CBAppointment.Checked ,CBVisits.Checked,CBDiagnosis.Checked,CBTests.Checked ,CBChronics.Checked ,CBMedicenReport.Checked ,CBDose.Checked ,CBDepartments.Checked , CBJobs.Checked,CBEmployees.Checked, CBUsers.Checked,CBSettings.Checked,CBMedince.Checked,CBRecordPatient.Checked);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadUser();
                ClearTools();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPass.Text) || string.IsNullOrWhiteSpace(cmbUserType.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                bool isActive = rdbActive.Checked ? true : false;
                UserManagement UserManagement = new UserManagement();
                UserManagement.EditUser(Convert.ToInt32(txtUserID.Text),txtFullName.Text, txtUserName.Text, txtUserPass.Text, cmbUserType.Text, isActive, CBClinics.Checked, CBDoctors.Checked, CBPatients.Checked, CBAppointment.Checked, CBVisits.Checked, CBDiagnosis.Checked, CBTests.Checked, CBChronics.Checked, CBMedicenReport.Checked, CBDose.Checked, CBDepartments.Checked, CBJobs.Checked, CBEmployees.Checked, CBUsers.Checked, CBSettings.Checked, CBMedince.Checked, CBRecordPatient.Checked);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.lblMessage.Text = "تم تعديل البيانات بنجاح";
                frmsuccesmessagebox.ShowDialog();
                LoadUser();
                ClearTools();
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Caption = "تأكيد الحذف";
                MessageDialog.Text = "هل تريد بالفعل حذف المستخدم المحدد ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvUsers.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (result == DialogResult.Yes)
                {
                    UserManagement UserManagement = new UserManagement();
                    UserManagement.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadUser();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة المستخدمين ", " حذف المستخدم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintUser_Click(object sender, EventArgs e)
        {
            FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
            frmalertmessagebox.lblMessage.Text = "لا يمكن طباعة قائمة المستخدمين";
            frmalertmessagebox.ShowDialog();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            try
            {
                LoadUser();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة المستخدمين ", " تحديث قائمة المستخدمين", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
