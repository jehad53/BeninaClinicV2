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
    public partial class UCChronic : UserControl
    {
        public UCChronic()
        {
            InitializeComponent();
            dgvChronics.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddChronic.Enabled = false;
            btnEditChronic.Enabled = false;
            btnDeleteChronic.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtChronicID.Text = MainFunction.GetMaxID("tblChronics", "Chronic_Id").ToString();
            txtChronicName.Clear();
            txtChronicNote.Clear();
            btnNew.Enabled = false;
            btnAddChronic.Enabled = true;
            btnEditChronic.Enabled = false;
            btnDeleteChronic.Enabled = false;
            txtChronicName.Focus();

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
                ChronicManagement ChronicManagement = new ChronicManagement();
                dgvChronics.AutoGenerateColumns = false;
                dgvChronics.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                dgvChronics.DataSource = ChronicManagement.GetAllChronics();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الأمراض المزمنة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (string.IsNullOrWhiteSpace(txtChronicID.Text) || string.IsNullOrWhiteSpace(txtChronicName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                ChronicManagement ChronicManagement = new ChronicManagement();
                ChronicManagement.InsertChronic(txtChronicName.Text,txtChronicNote.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChronicID.Text) || string.IsNullOrWhiteSpace(txtChronicName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                ChronicManagement ChronicManagement = new ChronicManagement();
                ChronicManagement.EditChronic( Convert.ToInt32(dgvChronics.CurrentRow.Cells[0].Value),txtChronicName.Text, txtChronicNote.Text);
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
                MessageDialog.Caption = "تأكيد الحذف";
                MessageDialog.Text = "هل تريد بالفعل حذف المرض المحدد ";
                MessageDialog.Parent = this.FindForm();
                var result = MessageDialog.Show();
                if (dgvChronics.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    ChronicManagement ChronicManagement = new ChronicManagement();
                    ChronicManagement.DeleteChronic(Convert.ToInt32(dgvChronics.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الفحوصات ", " حذف فحص ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("يوجد خطأ في تحديث قائمة الفحوصات ", " تحديث قائمة الفحوصات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvTests_DoubleClick(object sender, EventArgs e)
        {
            if (dgvChronics.Rows.Count <= 0)
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
                    for (int i = 0; i <= frmvisit.dgvChronics.Rows.Count - 1; i++)
                        if (frmvisit.dgvChronics.Rows[i].Cells[0].Value.ToString() == dgvChronics.CurrentRow.Cells[0].Value.ToString())
                        {
                            FrmAlertMessageBox frm = new FrmAlertMessageBox();
                            frm.lblMessage.Text = "تم إضافة هذا المرض مسبقًا";
                            frm.Focus();
                            frm.ShowDialog();
                            return;
                        }
                    frmvisit.dgvChronics.Rows.Add(); // إضافة صف جديد فارغ
                    int r = frmvisit.dgvChronics.Rows.Count - 1;
                    frmvisit.dgvChronics.Rows[r].Cells[0].Value = dgvChronics.CurrentRow.Cells[0].Value;
                    frmvisit.dgvChronics.Rows[r].Cells[1].Value = dgvChronics.CurrentRow.Cells[1].Value;
                    frmvisit.dgvChronics.Rows[r].Cells[2].Value = dgvChronics.CurrentRow.Cells[2].Value;
                    frmvisit.TabControl1.SelectedIndex = 0;
                    this.FindForm().Close();
                }
                catch { return; }
            } //End Super IF

        }

        private void dgvChronics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtChronicID.Text = dgvChronics.CurrentRow.Cells[0].Value.ToString();
                    txtChronicName.Text = dgvChronics.CurrentRow.Cells[1].Value.ToString();
                    txtChronicNote.Text = dgvChronics.CurrentRow.Cells[2].Value.ToString();
                    btnNew.Enabled = true;
                    btnAddChronic.Enabled = false;
                    btnEditChronic.Enabled = true;
                    btnDeleteChronic.Enabled = true;
                }
                catch
                {
                    return;
                }
            }
        }
    }
}