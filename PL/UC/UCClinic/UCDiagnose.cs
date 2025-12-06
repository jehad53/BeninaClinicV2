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
    public partial class UCDiagnose: UserControl
    {
        public UCDiagnose()
        {
            InitializeComponent();
            dgvDiagonses.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddDiagnose.Enabled = false;
            btnEditDiagnose.Enabled = false;
            btnDeleteDiagnose.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtDiagnoseID.Text = MainFunction.GetMaxID("tblDiagnoses", "Diagnosis_Id").ToString();
            txtDiagnoseName.Clear();
            btnNew.Enabled = false;
            btnAddDiagnose.Enabled = true;
            btnEditDiagnose.Enabled = false;
            btnDeleteDiagnose.Enabled = false;
            txtDiagnoseName.Focus();

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
                if (dgvDiagonses.Rows.Count <= 0)
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
                        for (int i = 0; i <= frmvisit.dgvDignoses.Rows.Count - 1; i++)
                            if (frmvisit.dgvDignoses.Rows[i].Cells[0].Value.ToString() == dgvDiagonses.CurrentRow.Cells[0].Value.ToString())
                            {
                                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                                frm.lblMessage.Text = "تم إضافة هذا التشخيص مسبقًا";
                                frm.Focus();
                                frm.ShowDialog();
                                return;
                            }
                        frmvisit.dgvDignoses.Rows.Add(); // إضافة صف جديد فارغ
                        int r = frmvisit.dgvDignoses.Rows.Count - 1;
                        frmvisit.dgvDignoses.Rows[r].Cells[0].Value = dgvDiagonses.CurrentRow.Cells[0].Value;
                        frmvisit.dgvDignoses.Rows[r].Cells[1].Value = dgvDiagonses.CurrentRow.Cells[1].Value;
                        frmvisit.dgvDignoses.Rows[r].Cells[2].Value = dgvDiagonses.CurrentRow.Cells[2].Value;
                        frmvisit.TabControl1.SelectedIndex = 3;
                        this.FindForm().Close();
                    }
                    catch { return; }
            } //End Super IF
        } 
        

        public void LoadData()
        {
            try
            {
                  DiagnoseManagement diagnosemanagement = new DiagnoseManagement();
                  dgvDiagonses.AutoGenerateColumns = false;
                  dgvDiagonses.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                  dgvDiagonses.DataSource = diagnosemanagement.GetAllDiagnoses();
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

        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnoseID.Text) || string.IsNullOrWhiteSpace(txtDiagnoseName.Text) )
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                JobManagement jobmanagement = new JobManagement();
              //  jobmanagement.EditJob( Convert.ToInt32(txtDiagnoseID.Text),txtDiagnoseName.Text, Convert.ToInt32(cmbDepartment.SelectedValue));
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
            if (string.IsNullOrWhiteSpace(txtDiagnoseID.Text) || string.IsNullOrWhiteSpace(txtDiagnoseName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DiagnoseManagement diagnosemanagement = new DiagnoseManagement();
                diagnosemanagement.InsertDepartment(txtDiagnoseName.Text, txtDiagnoseNote.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditDiagnose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnoseID.Text) || string.IsNullOrWhiteSpace(txtDiagnoseName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DiagnoseManagement diagnosemanagement = new DiagnoseManagement();
                diagnosemanagement.EditDiagnose( Convert.ToInt32(txtDiagnoseID.Text), txtDiagnoseName.Text, txtDiagnoseNote.Text);
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
                MessageBox.Show("يوجد خطأ في تحديث قائمة التشخيصات ", " تحديث قائمة التشخيصات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteDiagnose_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDiagonses.Rows.Count <= 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("هل تريد حذف القسم المحدد في قائمة الأقسام بالفعل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DiagnoseManagement diagnosemanagement = new DiagnoseManagement();
                    diagnosemanagement.DeleteDiagnose(Convert.ToInt32(dgvDiagonses.CurrentRow.Cells[0].Value));
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

        private void btnPrintDiagnose_Click(object sender, EventArgs e)
        {
            if (dgvDiagonses.Rows.Count == 0)
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
                frmalertmessagebox.lblMessage.Text = "لا يمكن طباعة قائمة التشخيصات";
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
                DiagnoseManagement diagnosemanagement = new DiagnoseManagement();
                dgvDiagonses.DataSource = diagnosemanagement.SearchDiagnose(txtSearchDiagnose.Text);
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
                txtDiagnoseID.Text = dgvDiagonses.CurrentRow.Cells[0].Value.ToString();
                txtDiagnoseName.Text = dgvDiagonses.CurrentRow.Cells[1].Value.ToString();
                /// cmbDepartment.Text = dgvJobs.CurrentRow.Cells[2].Value.ToString();
                btnNew.Enabled = true;
                btnAddDiagnose.Enabled = false;
                btnEditDiagnose.Enabled = true;
                btnDeleteDiagnose.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        }
    }
}