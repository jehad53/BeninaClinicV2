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
    public partial class UCEmployee : UserControl
    {
       public string conttacttype;

        public UCEmployee()
        {
            InitializeComponent();
            MainFunction.FillComboBox(cmbDepartments, "GetAllDepartments", "DepartmentName", "Department_Id");
            btnAddEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            LoadData();
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchDoctors_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pnlLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        public void ClearTools()
        {
            txtEmployeeID.Text = MainFunction.GetMaxID("tblEmployees", "Employee_Id").ToString();
            txtEmployeeName.Clear();
            txtEmployeeNatNum.Clear();
            txtEmployeeAddress.Clear();
            cmbEmployeeGender.SelectedIndex = -1;
            txtEmployeePhone.Clear();
            txtEmployeeSalary.Clear();
            txtEmployeeNote.Clear();
            txtSearchEmployee.Clear();
            dtpEmpDateofBirth.Value = DateTime.Today;
            dtpEmpAppointment.Value = DateTime.Today;

            cmbDepartments.SelectedIndex = -1;
            cmbContractType.SelectedIndex = -1;
            cmbEmployeeSocial.SelectedIndex = -1;

            btnNew.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnEditEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            txtEmployeeName.Focus();
        }

        private void dtpEmpDateofBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {

        }

        private void cmbJobs_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbDepartments.Text))
                {
                    MessageBox.Show("يـرجـى أخـتـيـار القـسـم ", "تـنبـيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                EmployeesManagement employeesmanagement = new EmployeesManagement();
                cmbJobs.DataSource = employeesmanagement.GetJobsByDep(Convert.ToInt32(cmbDepartments.SelectedValue));
                cmbJobs.DisplayMember = "JobName";
                cmbJobs.ValueMember = "Job_Id";
            }
            catch
            {
                return;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) || string.IsNullOrWhiteSpace(txtEmployeeName.Text) || string.IsNullOrWhiteSpace(txtEmployeeNatNum.Text) || string.IsNullOrWhiteSpace(txtEmployeeSalary.Text) || string.IsNullOrWhiteSpace(cmbDepartments.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                for (int i = 0; i < dgvEmployees.Rows.Count - 1; i++)
                {
                    if (dgvEmployees.Rows[i].Cells[2].Value.ToString() == txtEmployeeNatNum.Text)
                    {
                        FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                        frmalertmessagebox.lblMessage.Text = "الرقم الوطني مدخل مسبقا";
                        frmalertmessagebox.ShowDialog();
                        return;
                    }
                }
                EmployeesManagement employeesmanagement = new EmployeesManagement();
                employeesmanagement.InsertEmployee(txtEmployeeName.Text, txtEmployeeNatNum.Text, dtpEmpDateofBirth.Value, cmbEmployeeGender.Text, txtEmployeePhone.Text, txtEmployeeAddress.Text, cmbContractType.Text, cmbEmployeeSocial.Text, dtpEmpAppointment.Value, Convert.ToDecimal(txtEmployeeSalary.Text), Convert.ToInt32(cmbJobs.SelectedValue), txtEmployeeNote.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //  LoadData();
                ClearTools();
            }
        }


        public void LoadData()
        {
            try
            {
                EmployeesManagement employeesmanagement = new EmployeesManagement();
                dgvEmployees.AutoGenerateColumns = false;
                dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvEmployees.DataSource = employeesmanagement.GetAllEmployees();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل بيانات الموظفين", " تحميل الموظفين", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtEmployeeID.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
                txtEmployeeName.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
                txtEmployeeNatNum.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
                dtpEmpDateofBirth.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
                cmbEmployeeGender.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
                txtEmployeeAddress.Text = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
                txtEmployeePhone.Text = dgvEmployees.CurrentRow.Cells[6].Value.ToString();
                cmbEmployeeSocial.Text = dgvEmployees.CurrentRow.Cells[7].Value.ToString();
                cmbContractType.Text = dgvEmployees.CurrentRow.Cells[8].Value.ToString();
                dtpEmpAppointment.Text = dgvEmployees.CurrentRow.Cells[9].Value.ToString();
                txtEmployeeSalary.Text = dgvEmployees.CurrentRow.Cells[10].Value.ToString();
                cmbJobs.Text = dgvEmployees.CurrentRow.Cells[11].Value.ToString();
                txtEmployeeNote.Text = dgvEmployees.CurrentRow.Cells[12].Value.ToString();
                cmbDepartments.Text = dgvEmployees.CurrentRow.Cells[13].Value.ToString();

                btnNew.Enabled = true;
                btnAddEmployee.Enabled = false;
                btnEditEmployee.Enabled = true;
                btnDeleteEmployee.Enabled = true;
            }
            catch
            {
              return;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) || string.IsNullOrWhiteSpace(txtEmployeeName.Text) || string.IsNullOrWhiteSpace(txtEmployeeNatNum.Text) || string.IsNullOrWhiteSpace(txtEmployeeSalary.Text) || string.IsNullOrWhiteSpace(cmbDepartments.Text) || string.IsNullOrWhiteSpace(cmbJobs.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                EmployeesManagement employeesmanagement = new EmployeesManagement();
                employeesmanagement.EditEmployee(txtEmployeeName.Text, txtEmployeeNatNum.Text, dtpEmpDateofBirth.Value, cmbEmployeeGender.Text, txtEmployeePhone.Text, txtEmployeeAddress.Text, cmbContractType.Text, cmbEmployeeSocial.Text, dtpEmpAppointment.Value, Convert.ToDecimal(txtEmployeeSalary.Text), Convert.ToInt32(cmbJobs.SelectedValue), txtEmployeeNote.Text, Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value));
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // LoadData();
                ClearTools();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Caption = "تأكيد الحذف";
                MessageDialog.Text = "هل تريد بالفعل حذف الموظف المحدد ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvEmployees.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    EmployeesManagement employeesmanagement = new EmployeesManagement();
                    employeesmanagement.DeleteEmployee(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.ShowDialog();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الوظائف ", " حذف قسم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefreshEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الموظفين ", " تحديث قائمة بيانات الموظفين", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintEmployees_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.Rows.Count == 0)
            {
                // MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "القائمة فارغة لا يمكن الطباعة";
                frmalert.ShowDialog();
                return;
            }

            try
            {
                RptListEmployees rptEmployees = new RptListEmployees();

                FrmReport frmrpt = new FrmReport();
                rptEmployees.Refresh();
                frmrpt.crystalReportViewer1.ReportSource = rptEmployees;
                frmrpt.Show();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void btnPrintOneEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                RptOneEmployee rptOneEmployee = new RptOneEmployee();
                //("@Id",this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                rptOneEmployee.SetParameterValue("@Employee_Id", this.dgvEmployees.CurrentRow.Cells[0].Value.ToString());
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptOneEmployee;
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد الموظف ";
                frmalert.ShowDialog();
                // MessageBox.Show("يرجى الـتـأكـد من تحديد الموظف ","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmployeesManagement employeesmanagement = new EmployeesManagement();
                dgvEmployees.AutoGenerateColumns = false;
                dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvEmployees.DataSource = employeesmanagement.SearchEmployeeByNameOrNatNum(txtSearchEmployee.Text);
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في عملية البحث عن موظف", " البحث عن موظف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintEmpContractType_Click(object sender, EventArgs e)
        {

            if (!rdbAsassi.Checked && !rdbMotaon.Checked)
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يـرجـى تـحديد نـوع الـعـقد  ";
                frmalert.ShowDialog();
                return;
            }

            try
            {

                RptListEmployeeByContractType rptempbycontracttype = new RptListEmployeeByContractType();
                //("@Id",this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (rdbAsassi.Checked == true)
                {
                    conttacttype = "أساسي";
                }
                else
                {
                    conttacttype = "متعاون";
                }
                rptempbycontracttype.SetParameterValue("@Word", conttacttype);
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ShowRefreshButton = false;
                frmrpt.crystalReportViewer1.ReportSource = rptempbycontracttype;
                frmrpt.Show();
            }
            catch
            {
                Forms.FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد الموظف ";
                frmalert.ShowDialog();
                // MessageBox.Show("يرجى الـتـأكـد من تحديد الموظف ","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void rdbAsassi_CheckedChanged(object sender, EventArgs e)
        {
          //  conttacttype = "أساسي";
        }

        private void rdbMotaon_CheckedChanged(object sender, EventArgs e)
        {
            // conttacttype = "متعاون";

        }
    }
}
