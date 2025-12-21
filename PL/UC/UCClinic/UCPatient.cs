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
using BeninaClinic.PL.Forms.FrmClinic;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCPatient : UserControl
    {
        public UCPatient()
        {
            InitializeComponent();
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddPatient.Enabled = false;
            btnEditPatient.Enabled = false;
            btnDeletePatient.Enabled = false;
            LoadData();


        }



        public void LoadData()
        {
            try
            {
                PatientManagement patientmanagement = new PatientManagement();
                dgvPatients.AutoGenerateColumns = false;
                dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvPatients.DataSource = patientmanagement.GetAllPatients();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل المرضى", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FrmDataPatient frm = new FrmDataPatient();
            frm.txtPatientID.Text = txtPatientID.Text;
            frm.btnAddPatient.Visible = true;
            frm.btnEditPatient.Visible = false;
            frm.ShowDialog();
            //-------------
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
              FrmDataPatient frm = new FrmDataPatient();
              frm.txtPatientID.Text = dgvPatients.CurrentRow.Cells[0].Value.ToString();
              frm.txtPatientName.Text = dgvPatients.CurrentRow.Cells[1].Value.ToString();
              frm.cmbPatientGender.Text = dgvPatients.CurrentRow.Cells[2].Value.ToString();
              frm.cmbbooldtype.Text = dgvPatients.CurrentRow.Cells[3].Value.ToString();
              frm.dtpPatientDateofBirth.Text = dgvPatients.CurrentRow.Cells[4].Value.ToString();
              frm.txtAge.Text = dgvPatients.CurrentRow.Cells[5].Value.ToString();
              frm.txtNatNum.Text = dgvPatients.CurrentRow.Cells[6].Value.ToString();
              frm.txtPhone.Text = dgvPatients.CurrentRow.Cells[7].Value.ToString();
              frm.txtAdderss.Text = dgvPatients.CurrentRow.Cells[8].Value.ToString();
              frm.txtPatientNote.Text = dgvPatients.CurrentRow.Cells[9].Value.ToString();

              frm.txtNatNum.Enabled = false;
              frm.ShowDialog();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Text = "هل تريد بالفعل حذف المريض المحدد ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvPatients.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (result == DialogResult.Yes)
                {
                    PatientManagement patientmanagement = new PatientManagement();
                    patientmanagement.DeletePatient(Convert.ToInt32(dgvPatients.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة المرضـى ", " حذف مريض ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UCPatient_Load(object sender, EventArgs e)
        {

        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                btnNew.Enabled = true;
                btnAddPatient.Enabled = false;
                btnEditPatient.Enabled = true;
                btnDeletePatient.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void btnRefreshPatient_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة المرضى ", " تحديث قائمة المرضى", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintOnePatient_Click(object sender, EventArgs e)
        {
            try
            {
                RptOnePatient rptOnePatient = new RptOnePatient();
                rptOnePatient.SetParameterValue("@Patient_Id", this.dgvPatients.CurrentRow.Cells[0].Value.ToString());
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptOnePatient;
                frmrpt.Show();

            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد المريض ";
                frmalert.ShowDialog();
            }
        }

        private void btnPrintPatient_Click(object sender, EventArgs e)
        {
            try
            {
                RptListPatient rptistpatient = new RptListPatient();
                FrmReport frmrpt = new FrmReport();
                rptistpatient.Refresh();
                frmrpt.crystalReportViewer1.ReportSource = rptistpatient;
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "حدث خطأ اثناء الطباعة ";
                frmalert.ShowDialog();
            }
        }



        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PatientManagement patientmanagement = new PatientManagement();
                dgvPatients.AutoGenerateColumns = false;
                dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvPatients.DataSource = patientmanagement.SearchPatient(txtSearchEmployee.Text);
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في عملية البحث عن مريض", " البحث عن مريض", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFrmHealthData_Click(object sender, EventArgs e)
        {
            FrmDataPatient frm = new FrmDataPatient();
            frm.lbPatientID.Text = txtPatientID.Text;
            frm.ShowDialog();
        }

    

        private void btnFrmHealthData_Click_1(object sender, EventArgs e)
        {
            FrmDataPatient frmpatientdate = new FrmDataPatient();
            frmpatientdate.ShowDialog();
        }
    }
}