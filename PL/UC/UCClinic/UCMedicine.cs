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
using BeninaClinic.BL.HelperFunction;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Forms.FrmClinic;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCMedicine: UserControl
    {
        public UCMedicine()
        {
            InitializeComponent();
            dgvMedicines.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddMedicine.Enabled = false;
            btnEditMedicine.Enabled = false;
            btnDeleteMedicine.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtMedicineID.Text = MainFunction.GetMaxID("tblMedicines", "Medicine_Id").ToString();
            txtMedicineName.Clear();
            btnNew.Enabled = false;
            btnAddMedicine.Enabled = true;
            btnEditMedicine.Enabled = false;
            btnDeleteMedicine.Enabled = false;
            txtMedicineName.Focus();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }


        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {
       
        }

        public void LoadData()
        {
            try
            {
                  MedicineManagement medicinemanagement = new MedicineManagement();
                  dgvMedicines.AutoGenerateColumns = false;
                  dgvMedicines.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                  dgvMedicines.DataSource = medicinemanagement.GetAllMedicines();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الأدوية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineID.Text) || string.IsNullOrWhiteSpace(txtMedicineName.Text) )
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                MedicineManagement medicinemanagement = new MedicineManagement();
                medicinemanagement.EditMedicine( Convert.ToInt32(txtMedicineID.Text),txtMedicineName.Text, txtScinceName.Text, 10);
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

        }

        private void btnPrintJobs_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiagnose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineID.Text) || string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                MedicineManagement MedicineManagement = new MedicineManagement();
                MedicineManagement.InsertMedicine(txtMedicineName.Text, txtScinceName.Text ,10);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditDiagnose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineID.Text) || string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                MedicineManagement MedicineManagement = new MedicineManagement();
                MedicineManagement.EditMedicine( Convert.ToInt32(txtMedicineID.Text), txtMedicineName.Text, txtScinceName.Text  ,10);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnRefreshDiagnose_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الادوية ", " تحديث قائمة الادوية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteDiagnose_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Text = "هل تريد بالفعل حذف العيادة المحددة ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvMedicines.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (result == DialogResult.Yes)
                {
                    MedicineManagement MedicineManagement = new MedicineManagement();
                    MedicineManagement.DeleteMedicine(Convert.ToInt32(dgvMedicines.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الادوية ", " حذف دواء ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintDiagnose_Click(object sender, EventArgs e)
        {
            if (dgvMedicines.Rows.Count == 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                return;
            }

            try
            {
                //RptListJobs rptJobs = new RptListJobs();
                //rptJobs.Refresh();
                //FrmReport frmrpt = new FrmReport();
                //frmrpt.crystalReportViewer1.ReportSource = rptJobs;
                //frmrpt.Show();
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.lblMessage.Text = "لا يمكن طباعة قائمة الادوية";
                frmalertmessagebox.ShowDialog();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void txtSearchDiagnose_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MedicineManagement MedicineManagement = new MedicineManagement();
                dgvMedicines.DataSource = MedicineManagement.SearchMedicine(txtSearchMedicine.Text);
            }
            catch
            {
                return;
            }
        }

        private void dgvDiagonses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtMedicineID.Text = dgvMedicines.CurrentRow.Cells[0].Value.ToString();
                    txtMedicineName.Text = dgvMedicines.CurrentRow.Cells[1].Value.ToString();
                    txtScinceName.Text = dgvMedicines.CurrentRow.Cells[2].Value.ToString();
                    cmbMedicineType.Text = dgvMedicines.CurrentRow.Cells[3].Value.ToString();
                    btnNew.Enabled = true;
                    btnAddMedicine.Enabled = false;
                    btnEditMedicine.Enabled = true;
                    btnDeleteMedicine.Enabled = true;
                }
                catch
                {
                    return;
                }
            } //End Super IF
        }

        private void dgvMedicines_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMedicines.Rows.Count <= 0)
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.lblMessage.Text = "القائمة فارغة لا يمكن الاختيار";
                frm.ShowDialog();
            }

            else if(Application.OpenForms.OfType<FrmVisit>().Any() == false)
            {
                return;
            }

            else
            {
                try
                {
                    GlobalVar.MedcineID = dgvMedicines.CurrentRow.Cells[0].Value.ToString();
                    GlobalVar.MedcineName = dgvMedicines.CurrentRow.Cells[1].Value.ToString();
                    GlobalVar.SciniceName = dgvMedicines.CurrentRow.Cells[2].Value.ToString();
                    GlobalVar.MedcineType = dgvMedicines.CurrentRow.Cells[3].Value.ToString();
                    FrmSelection frmselection = new FrmSelection();
                    frmselection.pnlTltle.BackColor = Color.FromArgb(224, 164, 46);
                    frmselection.btnClose.FillColor = Color.FromArgb(224, 164, 46);
                    frmselection.btnMinmize.FillColor = Color.FromArgb(224, 164, 46);
                    UCDose ucdose = new UCDose();
                    frmselection.pnlContiner.Controls.Clear();
                    ucdose.Dock = DockStyle.Fill;
                    frmselection.pnlContiner.Controls.Add(ucdose);
                    //frmselection.Width = 1000;
                    //frmselection.Height = 800;
                    frmselection.ShowDialog();
                }
                catch { return; }
            }
        }

        private void txtMedicineName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScinceName.Focus();
            }
        }

        private void txtScinceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbMedicineType.Focus();
            }
        }

        private void cmbMedicineType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnAddMedicine.Enabled)
            {
                btnAddMedicine.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter && btnEditMedicine.Enabled)
            {
                btnEditMedicine.PerformClick();
            }
        }
    }
}