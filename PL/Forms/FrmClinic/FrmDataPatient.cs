using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace BeninaClinic.PL.Forms.FrmClinic
{
    public partial class FrmDataPatient : Form
    {
        // 1 for Add 2 for Edit
        public FrmDataPatient()
        {
            InitializeComponent();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //FrmSelection frm = new FrmSelection();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDesies_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiseaseName.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.ShowDialog();
            }
            else
            {
                int rowIndex = dgvDiseases.Rows.Add();
                dgvDiseases.Rows[rowIndex].Cells["DiseaseName"].Value = txtDiseaseName.Text;
                dgvDiseases.Rows[rowIndex].Cells["DiseaseDate"].Value = txtDiseaseDate.Text;
                dgvDiseases.Rows[rowIndex].Cells["Description"].Value = txtDiseaseNote.Text;
                txtDiseaseName.Clear();
                txtDiseaseDate.Clear();
                txtDiseaseNote.Clear();
            }
        }

        private void dgvDiseases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvDiseases.Rows.Count <= 0)
                    return;
                else
                {
                    dgvDiseases.Rows.Remove(dgvDiseases.CurrentRow);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubstance.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.ShowDialog();
                txtSubstance.Focus();
            }
            else
            {
                int rowIndex = dgvAllergies.Rows.Add();
                dgvAllergies.Rows[rowIndex].Cells["TypeAllergies"].Value = cmbAllergiesType.Text;
                dgvAllergies.Rows[rowIndex].Cells["Substance"].Value = txtSubstance.Text;

                cmbAllergiesType.Text = "";
                txtSubstance.Clear();

            }
        }

        private void txtSubstance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddAllergies.PerformClick();
                //  e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void dgvAllergies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dgvAllergies.Rows.Count <= 0)
                    return;
                else
                {
                    dgvAllergies.Rows.Remove(dgvAllergies.CurrentRow);
                }
            }
        }

        private void txtDiseaseName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDiseaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiseaseNote.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void txtDiseaseNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddDesies.PerformClick();

            }
        }

        private void txtSurgerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHospitalName.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void txtHospitalName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSurgeriesNote.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void txtSurgeriesNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddSurgerie.PerformClick();

            }
        }

        private void btnAddSurgerie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurgerie.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.ShowDialog();
                txtSurgerie.Focus();
            }
            else
            {
                int rowIndex = dgvSurgeries.Rows.Add();
                dgvSurgeries.Rows[rowIndex].Cells["SurgeryName"].Value = txtSurgerie.Text;
                dgvSurgeries.Rows[rowIndex].Cells["SurgeryDate"].Value = dtpSurgeriesDate.Text;
                dgvSurgeries.Rows[rowIndex].Cells["HospitalName"].Value = txtHospitalName.Text;
                dgvSurgeries.Rows[rowIndex].Cells["SurgeryNote"].Value = txtSurgeriesNote.Text;

                txtSurgerie.Clear();
                txtSubstance.Clear();
                txtHospitalName.Clear();
                txtSurgeriesNote.Clear();
            }
        }

        private void txtMedicationName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMedicationsTime.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicationName.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.ShowDialog();
                txtSurgerie.Focus();
            }
            else
            {
                int rowIndex = dgvMedications.Rows.Add();
                dgvMedications.Rows[rowIndex].Cells["MedicationName"].Value = txtMedicationName.Text;
                dgvMedications.Rows[rowIndex].Cells["MedicationTime"].Value = txtMedicationsTime.Text;
                dgvMedications.Rows[rowIndex].Cells["MedicationNameStopORContiune"].Value = cmbStopORContiune.Text;


                txtMedicationName.Clear();
                txtMedicationsTime.Clear();
            }
        }

        private void dgvMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvMedications.Rows.Count <= 0)
                    return;
                else
                {
                    dgvMedications.Rows.Remove(dgvMedications.CurrentRow);
                }
            }
        }

        private void dgvSurgeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dgvSurgeries.Rows.Count <= 0)
                    return;
                else
                {
                    dgvSurgeries.Rows.Remove(dgvSurgeries.CurrentRow);
                }
            }
        }

        private void txtFamilyDiseaseName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbRelation.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void cmbRelation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamilyNote.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void btnAddFamilyHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFamilyDiseaseName.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.ShowDialog();
                txtSurgerie.Focus();
            }
            else
            {
                int rowIndex = dgvFamilyHistory.Rows.Add();
                dgvFamilyHistory.Rows[rowIndex].Cells["FamilyDiseaseName"].Value = txtFamilyDiseaseName.Text;
                dgvFamilyHistory.Rows[rowIndex].Cells["Relation"].Value = cmbRelation.Text;
                dgvFamilyHistory.Rows[rowIndex].Cells["NoteFamilyHistpry"].Value = txtFamilyNote.Text;


                txtFamilyDiseaseName.Clear();
                txtFamilyNote.Clear();
            }
        }

        private void txtFamilyNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddFamilyHistory.PerformClick();
            }
        }

        private void dgvFamilyHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvFamilyHistory.Rows.Count <= 0)
                    return;
                else
                {
                    dgvFamilyHistory.Rows.Remove(dgvFamilyHistory.CurrentRow);
                }
            }
        }

        private void FrmDataPatient_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FrmDataPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tabControl1.SelectedIndex = 0;
            }
            else if (e.KeyCode == Keys.F2)
            {
                tabControl1.SelectedIndex = 1;
            }
            else if (e.KeyCode == Keys.F3)
            {
                tabControl1.SelectedIndex = 2;
            }
            else if (e.KeyCode == Keys.F4)
            {
                tabControl1.SelectedIndex = 3;
            }
            else if (e.KeyCode == Keys.F5)
            {
                tabControl1.SelectedIndex = 4;
            }
            else if (e.KeyCode == Keys.F6)
            {
                tabControl1.SelectedIndex = 5;
            }
        }
        // --------------------------------------------------------------------
        private void txtDiseaseName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiseaseDate.Focus();
                e.SuppressKeyPress = true; // لمنع صوت الـ Beep
            }
        }

        private void txtDiseaseName_Enter(object sender, EventArgs e)
        {

        }



        //-------------------------------------- Add & Edit --------------------------------------

      
        private void btnEditPatient_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
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
                    patientmanagement.EditPatient(Convert.ToInt32(txtPatientID.Text), txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text, txtPhone.Text, txtNatNum.Text, txtAdderss.Text, cmbbooldtype.Text);
                    FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                    frmsuccesmessagebox.ShowDialog();
                    //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch
                {
                    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                    frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
                    frmalertmessagebox.ShowDialog();
                }
                ClearTools();

            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
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

                    if (patientmanagement.Patient_NationalNumber_Exists(txtNatNum.Text))
                    {
                        FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                        frmalert.lblMessage.Text = "الرقم الوطني مدخل مسبقاً";
                        frmalert.ShowDialog();
                        txtNatNum.Focus();
                        txtNatNum.SelectAll();
                        return;
                    }
                    patientmanagement.InsertPatient(txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, Convert.ToInt32(txtAge.Text), txtPatientNote.Text, txtPhone.Text, txtNatNum.Text, txtAdderss.Text, cmbbooldtype.Text);
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
                    // LoadData();
                    ClearTools();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                    frmalertmessagebox.lblMessage.Text = "يرجى التأكد من صحة المدخلات";
              //      frmalertmessagebox.ShowDialog();
                }
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

        public void ClearTools()
        {
            txtPatientID.Text = MainFunction.GetMaxID("tblPatients", "Patient_Id").ToString();
            txtPatientName.Clear();
            txtNatNum.Clear();
            txtAge.Clear();
            txtAdderss.Clear();
            txtPhone.Clear();
            txtPatientNote.Clear();
            txtPatientName.Focus();
        }
    }

}

