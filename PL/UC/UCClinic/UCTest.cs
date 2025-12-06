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
    public partial class UCTest: UserControl
    {
        public UCTest()
        {
            InitializeComponent();
            dgvTests.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            //  MainFunction.FillComboBox(cmbDepartment , "GetAllDepartments" , "DepartmentName", "Department_Id");
            btnAddTest.Enabled = false;
            btnEditTest.Enabled = false;
            btnDeleteTest.Enabled = false;
            LoadData();
        }

        public void ClearTools()
        {
            txtTestID.Text = MainFunction.GetMaxID("tblTests", "Test_Id").ToString();
            txtTestName.Clear();
            btnNew.Enabled = false;
            btnAddTest.Enabled = true;
            btnEditTest.Enabled = false;
            btnDeleteTest.Enabled = false;
            txtTestName.Focus();

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
                TestManagement testmanagement = new TestManagement();
                dgvTests.AutoGenerateColumns = false;
                dgvTests.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                dgvTests.DataSource = testmanagement.GetAllTests();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الفحوصات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (string.IsNullOrWhiteSpace(txtTestID.Text) || string.IsNullOrWhiteSpace(txtTestName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                TestManagement testmanagement = new TestManagement();
                testmanagement.InsertTest(txtTestName.Text,txtTestNote.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTestID.Text) || string.IsNullOrWhiteSpace(txtTestName.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                TestManagement testmanagement = new TestManagement();
                testmanagement.EditTest( Convert.ToInt32(txtTestID.Text),txtTestName.Text, txtTestNote.Text);
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
                if (dgvTests.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("هل تريد حذف الفحص المحدد في قائمة الفحوصات بالفعل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TestManagement testmanagement = new TestManagement();
                    testmanagement.DeleteTest(Convert.ToInt32(dgvTests.CurrentRow.Cells[0].Value));
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
            if (dgvTests.Rows.Count <= 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                return;
            }

            try
            {
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.lblMessage.Text = "لا يمكن طباعة قائمة الصور والتحاليل";
                frmalertmessagebox.ShowDialog();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
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
            if (dgvTests.Rows.Count <= 0)
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
                    for (int i = 0; i <= frmvisit.dgvTests.Rows.Count - 1; i++)
                        if (frmvisit.dgvTests.Rows[i].Cells[0].Value.ToString() == dgvTests.CurrentRow.Cells[0].Value.ToString())
                        {
                            FrmAlertMessageBox frm = new FrmAlertMessageBox();
                            frm.lblMessage.Text = "تم إضافة هذا الفحص مسبقًا";
                            frm.ShowDialog();
                            return;
                        }
                    frmvisit.dgvTests.Rows.Add(); // إضافة صف جديد فارغ
                    int r = frmvisit.dgvTests.Rows.Count - 1;
                    frmvisit.dgvTests.Rows[r].Cells[0].Value = dgvTests.CurrentRow.Cells[0].Value;
                    frmvisit.dgvTests.Rows[r].Cells[1].Value = dgvTests.CurrentRow.Cells[1].Value;
                    frmvisit.dgvTests.Rows[r].Cells[2].Value = dgvTests.CurrentRow.Cells[2].Value;
                    frmvisit.TabControl1.SelectedIndex = 2;
                    this.FindForm().Close();
                }
                catch { return; }
            }
        }

        private void UCTest_Load(object sender, EventArgs e)
        {

        }

        private void dgvTests_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                if (dgvTests.Rows.Count <= 0)
                {
                    FrmAlertMessageBox frm = new FrmAlertMessageBox();
                    frm.lblMessage.Text = "القائمة فارغة لا يمكن الاختيار";
                    frm.ShowDialog();
                }
                else
                {
                    try
                    {
                            txtTestID.Text = dgvTests.CurrentRow.Cells[0].Value.ToString();
                            txtTestName.Text = dgvTests.CurrentRow.Cells[1].Value.ToString();
                            txtTestNote.Text = dgvTests.CurrentRow.Cells[2].Value.ToString();
                            btnNew.Enabled = true;
                            btnAddTest.Enabled = false;
                            btnEditTest.Enabled = true;
                            btnDeleteTest.Enabled = true;
                     }
                        catch
                        {
                            return;
                        }
                    }
            } //End Super IF
        }

        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchTest_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                TestManagement testmanagement = new TestManagement();
                dgvTests.DataSource = testmanagement.SearchTest(txtSearchTest.Text);
            }
            catch
            {
                return;
            }
        }
    }
}