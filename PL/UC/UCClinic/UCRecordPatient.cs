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
    public partial class UCRecordPatient: UserControl
    {
        public UCRecordPatient()
        {
            InitializeComponent();
            LoadPatientVisits();
        }


        public void ClearTools()
        {
            //txtPatientID.Text = MainFunction.GetMaxID("tblPatients", "Patient_Id").ToString();
            //txtPatientName.Clear();
            //btnNew.Enabled = false;
            //btnAddPatient.Enabled = true;
            //btnEditPatient.Enabled = false;
            //btnDeletePatient.Enabled = false;
            //txtPatientName.Focus();
        }


        public void LoadPatientVisits()
        {

            int patientId;
            if (!int.TryParse(lbPatientID.Text, out patientId))
            {
                patientId = 0; // أو اجعلها قيمة تتجاهل الشرط
            }

            try
            {
                VisitManagement visitmangement = new VisitManagement();
                dgvVisitHistory.AutoGenerateColumns = false;
                dgvVisitHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvVisitHistory.DataSource = visitmangement.GetAllPatientVisit(patientId , txtNatNum.Text);
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
            //if(string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            //{
            //    // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
            //    frmalertmessagebox.ShowDialog();
            //}
            //else
            //{
            //    try
            //    {
            //        PatientManagement patientmanagement = new PatientManagement();
            //        patientmanagement.InsertPatient(txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text , txtPhone.Text, txtNatNum.Text, txtAdderss.Text);
            //        FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
            //        frmsuccesmessagebox.ShowDialog();
            //        if (MessageBox.Show("هـل تـريد حـجـز مـوعـد للمـريـض ؟", " حـجـز مـوعـد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            FrmAppointment frmAppointment = new FrmAppointment();
            //            frmAppointment.txtPatientID.Text = txtPatientID.Text;
            //            frmAppointment.txtPatientName.Text = txtPatientName.Text;
            //            frmAppointment.ShowDialog();
            //        }
            //        else
            //        {
            //            return;
            //        }
            //        LoadData();
            //        ClearTools();
            //    }
            //    catch
            //    {
            //        FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
            //        frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
            //        frmalertmessagebox.ShowDialog();
            //    }
            //}
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text))
            //{
            //    // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
            //    frmalertmessagebox.ShowDialog();
            //}
            //else
            //{
            //    try
            //    {
            //        PatientManagement patientmanagement = new PatientManagement();
            //        patientmanagement.EditPatient(Convert.ToInt32(txtPatientID.Text), txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text,txtPhone.Text , txtNatNum.Text ,txtAdderss.Text);
            //        FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
            //        frmsuccesmessagebox.ShowDialog();
            //        //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        LoadData();
            //        ClearTools();
            //    }
            //    catch
            //    {
            //        FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
            //        frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
            //        frmalertmessagebox.ShowDialog();
            //    }
            //    }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvPatients.Rows.Count == 0)
            //    {
            //        MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    else if (MessageBox.Show("هل تريد حذف المريض المحدد في قائمة المرضـى بالفعل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        PatientManagement patientmanagement = new PatientManagement();
            //        patientmanagement.DeletePatient(Convert.ToInt32(dgvPatients.CurrentRow.Cells[0].Value));
            //        FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
            //        frmsucces.Show();
            //        ClearTools();
            //        LoadData();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("يوجد خطأ في الحذف من قائمة المرضـى ", " حذف مريض ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void UCPatient_Load(object sender, EventArgs e)
        {

        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    txtPatientID.Text = dgvPatients.CurrentRow.Cells[0].Value.ToString();
            //    txtPatientName.Text = dgvPatients.CurrentRow.Cells[1].Value.ToString();
            //    cmbPatientGender.Text = dgvPatients.CurrentRow.Cells[2].Value.ToString();
            //    dtpPatientDateofBirth.Text = dgvPatients.CurrentRow.Cells[3].Value.ToString();
            //    txtAge.Text = dgvPatients.CurrentRow.Cells[4].Value.ToString();
            //    txtNatNum.Text = dgvPatients.CurrentRow.Cells[5].Value.ToString();
            //    txtPhone.Text = dgvPatients.CurrentRow.Cells[6].Value.ToString();
            //    txtPatientNote.Text = dgvPatients.CurrentRow.Cells[8].Value.ToString();
            //    btnNew.Enabled = true;
            //    btnAddPatient.Enabled = false;
            //    btnEditPatient.Enabled = true;
            //    btnDeletePatient.Enabled = true;
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void btnRefreshPatient_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LoadData();
            //}
            //catch
            //{
            //    MessageBox.Show("يوجد خطأ في تحديث قائمة المرضى ", " تحديث قائمة المرضى", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnPrintOnePatient_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    RptOnePatient rptOnePatient = new RptOnePatient();
            //    rptOnePatient.SetParameterValue("@Patient_Id", this.dgvPatients.CurrentRow.Cells[0].Value.ToString());
            //    FrmReport frmrpt = new FrmReport();
            //    frmrpt.crystalReportViewer1.ReportSource = rptOnePatient;
            //    frmrpt.Show();

            //}
            //catch
            //{
            //    FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
            //    frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد المريض ";
            //    frmalert.ShowDialog();
            //}
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
            //txtAge.Text = (DateTime.Now.Year - dtpPatientDateofBirth.Value.Year).ToString();
        }

        private void dtpPatientDateofBirth_ValueChanged(object sender, EventArgs e)
        {
            CalcAge();
        }

        private void dgvVisitHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPatineNameTab2.Text = lbPatineName.Text;
            lbPaientID.Text = lbPatientID.Text;
            LoadPatientVisits();
        }

        private void lbPatineNameTab2_Click(object sender, EventArgs e)
        {
            LoadPatientVisits();
        }

        private void dgvVisitHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VisitManagement visitmanagement = new VisitManagement();
            dgvViewDTM.AutoGenerateColumns = false;
            if (e.ColumnIndex == 4)
            {
                dgvViewDTM.DataSource = visitmanagement.GetDigonosisByVisitID(Convert.ToInt32(dgvVisitHistory.CurrentRow.Cells[0].Value));
                dgvViewDTM.Columns[0].HeaderText = "رقم التشخيص";
                dgvViewDTM.Columns[1].HeaderText = "اسم التشخيص";
                dgvViewDTM.Columns[0].DataPropertyName = "Diagnosis_Id";
                dgvViewDTM.Columns[1].DataPropertyName = "DiagnosisName";
                dgvViewDTM.Columns[2].DataPropertyName = "Description";
            }
            else if(e.ColumnIndex == 5)
            {
                dgvViewDTM.DataSource = visitmanagement.GetTestsByVisitId(Convert.ToInt32(dgvVisitHistory.CurrentRow.Cells[0].Value));
                dgvViewDTM.Columns[0].HeaderText = "رقم الفحص";
                dgvViewDTM.Columns[1].HeaderText = "اسم الفحص";
                dgvViewDTM.Columns[0].DataPropertyName = "Test_Id";
                dgvViewDTM.Columns[1].DataPropertyName = "TestName";
                dgvViewDTM.Columns[2].DataPropertyName = "Description";
            }
            else if(e.ColumnIndex == 6)
            {
                dgvViewDTM.DataSource = visitmanagement.GetMedicineByVisitId(Convert.ToInt32(dgvVisitHistory.CurrentRow.Cells[0].Value));
                dgvViewDTM.Columns[0].HeaderText = "رقم الدواء";
                dgvViewDTM.Columns[1].HeaderText = "اسم الدواء";
                dgvViewDTM.Columns[0].DataPropertyName = "Medication_Id";
                dgvViewDTM.Columns[1].DataPropertyName = "MedicineName";
                dgvViewDTM.Columns[2].DataPropertyName = "Description";
            }
        }

        private void dgvVisitHistory_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void dgvVisitHistory_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                dgvVisitHistory.Cursor = Cursors.Hand;
            }
        }

        private void dgvVisitHistory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                dgvVisitHistory.Cursor = Cursors.Hand;
            }
        }

        private void dgvVisitHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvVisitHistory.Cursor = Cursors.Default;
        }

        private void txtNatNum_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PatientManagement patient = new PatientManagement();
                DataTable dt = new DataTable();
                dt = patient.GelPatientByNatNum(txtNatNum.Text);
                if (dt.Rows.Count > 0 && dt != null)
                {
                    tabControl1.SelectedIndex = 0;
                    lbPaientID.Text = dt.Rows[0][0].ToString();
                    lbPatineName.Text = dt.Rows[0][1].ToString();
                    lbNatNum.Text = dt.Rows[0][7].ToString();
                    lbAge.Text = dt.Rows[0][4].ToString();
                    lbBOD.Text = dt.Rows[0][3].ToString();
                    LBgENDER.Text = dt.Rows[0][2].ToString();
                    lbPhone.Text = dt.Rows[0][6].ToString();
                    lbAddress.Text = dt.Rows[0][8].ToString();
                    lbBloodType.Text = dt.Rows[0][9].ToString();
                    lbNote.Text = dt.Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("  يرجى التأكد من الرقم الوطني و إعادة المحاولة", "تنبيه");
                }

            }

        }


        public void LoadPatientByNat()
        {
            int patientId;
            if (!int.TryParse(lbPatientID.Text, out patientId))
            {
                patientId = 0; // أو اجعلها قيمة تتجاهل الشرط
            }

            try
            {
                VisitManagement visitmangement = new VisitManagement();
                dgvVisitHistory.AutoGenerateColumns = false;
                dgvVisitHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvVisitHistory.DataSource = visitmangement.GetAllPatientVisit(patientId, txtNatNum.Text);
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل المرضى", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
