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
    public partial class UCDose : UserControl
    {
        public UCDose()
        {
            InitializeComponent();
            dgvDoses.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddDose.Enabled = false;
            btnEditDose.Enabled = false;
            btnDeleteDose.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtDoseID.Text = MainFunction.GetMaxID("tblDoses", "Dose_Id").ToString();
            txtDoseName.Clear();
            btnNew.Enabled = false;
            btnAddDose.Enabled = true;
            btnEditDose.Enabled = false;
            btnDeleteDose.Enabled = false;
            txtDoseName.Focus();

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

        public void LoadData()
        {
            try
            {
                DoseManagement dosemanagement = new DoseManagement();
                dgvDoses.AutoGenerateColumns = false;
                dgvDoses.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                dgvDoses.DataSource = dosemanagement.GetAllDoses();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الجرعات ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintDepartments_Click(object sender, EventArgs e)
        {

        }



        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoseID.Text) || string.IsNullOrWhiteSpace(txtDoseName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DoseManagement dosemanagement = new DoseManagement();
                dosemanagement.InsertDose(txtDoseName.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoseID.Text) || string.IsNullOrWhiteSpace(txtDoseName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DoseManagement dosemanagement = new DoseManagement();
                dosemanagement.EditDose(Convert.ToInt32(dgvDoses.CurrentRow.Cells[0].Value), txtDoseName.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDoses.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("هل تريد حذف الجرعة المحدد في قائمة الجرعات بالفعل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DoseManagement dosemanagement = new DoseManagement();
                    dosemanagement.DeleteDose(Convert.ToInt32(dgvDoses.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الجرعات ", " حذف جرعة ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshTest_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الجرعات ", " تحديث قائمة الجرعات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvTests_DoubleClick(object sender, EventArgs e)
        {

        }
        private void txtSearchDose_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DoseManagement dosemanagement = new DoseManagement();
                dgvDoses.DataSource = dosemanagement.SearchDose(txtSearchDose.Text);
            }
            catch
            {
                return;
            }
        }

        private void dgvDoses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                if (dgvDoses.Rows.Count <= 0)
                {
                    FrmAlertMessageBox frm = new FrmAlertMessageBox();
                    frm.lblMessage.Text = "القائمة فارغة لا يمكن الاختيار";
                    frm.ShowDialog();
                }
                else
                {
                    try
                    {
                        txtDoseID.Text = dgvDoses.CurrentRow.Cells[0].Value.ToString();
                        txtDoseName.Text = dgvDoses.CurrentRow.Cells[1].Value.ToString();
                        btnNew.Enabled = true;
                        btnAddDose.Enabled = false;
                        btnEditDose.Enabled = true;
                        btnDeleteDose.Enabled = true;
                    }
                    catch
                    {
                        return;
                    }

                }
            } //End Super IF
        }

        private void dgvDoses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDoses.Rows.Count <= 0)
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.lblMessage.Text = "القائمة فارغة لا يمكن الاختيار";
                frm.ShowDialog();
            }
            else
            {
                try
                {
                    var frmvisit = Application.OpenForms["FrmVisit"] as FrmVisit;
                    for (int i = 0; i <= frmvisit.dgvMedicen.Rows.Count - 1 ; i++)
                        if (frmvisit.dgvMedicen.Rows[i].Cells[0].Value.ToString() == GlobalVar.MedcineID)
                        {
                            FrmAlertMessageBox frm = new FrmAlertMessageBox();
                            frm.lblMessage.Text = "تم إضافة هذا الدواء مسبقًا";
                            frm.Focus();
                            frm.ShowDialog();
                            return;
                        }
                    frmvisit.dgvMedicen.Rows.Add(); // إضافة صف جديد فارغ
                    int r = frmvisit.dgvMedicen.Rows.Count - 1;
                    frmvisit.dgvMedicen.Rows[r].Cells[0].Value = GlobalVar.MedcineID;
                    frmvisit.dgvMedicen.Rows[r].Cells[1].Value = GlobalVar.MedcineName;
                    frmvisit.dgvMedicen.Rows[r].Cells[2].Value = GlobalVar.SciniceName;
                    frmvisit.dgvMedicen.Rows[r].Cells[3].Value = GlobalVar.MedcineType;
                    frmvisit.dgvMedicen.Rows[r].Cells[4].Value = dgvDoses.CurrentRow.Cells[1].Value;
                    frmvisit.TabControl1.SelectedIndex = 1;
                    CloseForm();
                }
                catch { return; }
            }

           }

                public void CloseForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FrmSelection)
                    frm.Close();
            }
        }

        }
    }