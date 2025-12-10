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


        public void ClearTools()
        {
            txtPatientID.Text = MainFunction.GetMaxID("tblPatients", "Patient_Id").ToString();
            txtPatientName.Clear();
            btnNew.Enabled = false;
            btnAddPatient.Enabled = true;
            btnEditPatient.Enabled = false;
            btnDeletePatient.Enabled = false;
            txtPatientName.Focus();
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
            ClearTools();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                try
                {
                    for (int i = 0; i < dgvPatients.Rows.Count - 1; i++)
                    {
                        if (dgvPatients.Rows[i].Cells[5].Value.ToString() == txtNatNum.Text)
                        {
                           FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                           frmalertmessagebox.lblMessage.Text = "الرقم الوطني مدخل مسبقا";
                           frmalertmessagebox.ShowDialog();
                           return;
                        }
                    }
                    PatientManagement patientmanagement = new PatientManagement();
                    patientmanagement.InsertPatient(txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text , txtPhone.Text, txtNatNum.Text, txtAdderss.Text);
                    FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                    frmsuccesmessagebox.ShowDialog();
                    if (MessageBox.Show("هـل تـريد حـجـز مـوعـد للمـريـض ؟", " حـجـز مـوعـد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmAppointment frmAppointment = new FrmAppointment();
                        frmAppointment.txtPatientID.Text = txtPatientID.Text;
                        frmAppointment.txtPatientName.Text = txtPatientName.Text;
                        frmAppointment.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                    LoadData();
                    ClearTools();
                }
                catch
                {
                    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                    frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
                    frmalertmessagebox.ShowDialog();
                }
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                try
                {
                    PatientManagement patientmanagement = new PatientManagement();
                    patientmanagement.EditPatient(Convert.ToInt32(txtPatientID.Text), txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text,txtPhone.Text , txtNatNum.Text ,txtAdderss.Text);
                    FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                    frmsuccesmessagebox.ShowDialog();
                    //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LoadData();
                    ClearTools();
                }
                catch
                {
                    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                    frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
                    frmalertmessagebox.ShowDialog();
                }
                }
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
                    ClearTools();
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
                txtPatientID.Text = dgvPatients.CurrentRow.Cells[0].Value.ToString();
                txtPatientName.Text = dgvPatients.CurrentRow.Cells[1].Value.ToString();
                cmbPatientGender.Text = dgvPatients.CurrentRow.Cells[2].Value.ToString();
                dtpPatientDateofBirth.Text = dgvPatients.CurrentRow.Cells[3].Value.ToString();
                txtAge.Text = dgvPatients.CurrentRow.Cells[4].Value.ToString();
                txtNatNum.Text = dgvPatients.CurrentRow.Cells[5].Value.ToString();
                txtPhone.Text = dgvPatients.CurrentRow.Cells[6].Value.ToString();
                txtPatientNote.Text = dgvPatients.CurrentRow.Cells[8].Value.ToString();
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

        // Method for Calculate Age
        public void CalcAge()
        {
            txtAge.Text = (DateTime.Now.Year - dtpPatientDateofBirth.Value.Year).ToString();
        }

        private void dtpPatientDateofBirth_ValueChanged(object sender, EventArgs e)
        {
            CalcAge();
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
    }
}
