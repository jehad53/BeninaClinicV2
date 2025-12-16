using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL;
using BeninaClinic.BL.GeneralFunction;
using BeninaClinic.BL.Clinic;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCDoctor : UserControl
    {
        public string conttacttype;

        public UCDoctor()
        {
            InitializeComponent();
            dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
            MainFunction.FillComboBox(cmbClinics, "GetAllClinics", "ClinicName", "Clinic_Id");
            btnAddDoctor.Enabled = false;
            btnEditDoctor.Enabled = false;
            btnDeleteDoctor.Enabled = false;
            LoadData();
        }

        private void txtClinicID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        void ClearTools()
        {
            txtDoctorID.Text = MainFunction.GetMaxID("tblDoctors", "Doctor_Id").ToString();
            txtDoctorName.Clear();
            txtDoctorNatNum.Clear();
            txtDoctorAddress.Clear();
            txtDoctorPhone.Clear();
            txtSpecialty.Clear();
            txtSearchDoctors.Clear();
            cmbClinics.SelectedIndex = -1;
            cmbContractType.SelectedIndex = -1;
            cmbDoctorGender.SelectedIndex = -1;
            cmbDoctorsSocial.SelectedIndex = -1;
            btnNew.Enabled = false;
            btnAddDoctor.Enabled = true;
            btnEditDoctor.Enabled = false;
            btnDeleteDoctor.Enabled = false;
            txtDoctorName.Focus();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoctorName.Text) || string.IsNullOrWhiteSpace(txtDoctorNatNum.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text) || string.IsNullOrWhiteSpace(txtDoctorPhone.Text) || string.IsNullOrWhiteSpace(txtDoctorAddress.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                for (int i = 0; i < dgvDoctors.Rows.Count - 1; i++)
                {
                    if (dgvDoctors.Rows[i].Cells[2].Value.ToString() == txtDoctorNatNum.Text)
                    {
                        FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                        frmalertmessagebox.lblMessage.Text = "الرقم الوطني مدخل مسبقا";
                        frmalertmessagebox.ShowDialog();
                        return;
                    }
                }
                DoctorsManagement doctorsmanagement = new DoctorsManagement();
                doctorsmanagement.InsertDoctor(txtDoctorName.Text, txtDoctorNatNum.Text, cmbDoctorGender.Text,
                txtDoctorPhone.Text, txtDoctorAddress.Text, cmbContractType.Text, cmbDoctorsSocial.Text, txtSpecialty.Text, Convert.ToInt32(cmbClinics.SelectedValue));
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //LoadData();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        public void LoadData()
        {
            try
            {
                DoctorsManagement doctorsmanagement = new DoctorsManagement();
                dgvDoctors.AutoGenerateColumns = false;
                dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvDoctors.DataSource = doctorsmanagement.GetAllDoctors();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل بيانات الأطباء", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnShowAsForm_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoctors_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtDoctorID.Text = dgvDoctors.CurrentRow.Cells[0].Value.ToString();
                txtDoctorName.Text = dgvDoctors.CurrentRow.Cells[1].Value.ToString();
                txtDoctorNatNum.Text = dgvDoctors.CurrentRow.Cells[2].Value.ToString();
                cmbDoctorGender.Text = dgvDoctors.CurrentRow.Cells[3].Value.ToString();
                txtDoctorPhone.Text = dgvDoctors.CurrentRow.Cells[4].Value.ToString();
                txtDoctorAddress.Text = dgvDoctors.CurrentRow.Cells[5].Value.ToString();
                cmbContractType.Text = dgvDoctors.CurrentRow.Cells[6].Value.ToString();
                cmbDoctorsSocial.Text = dgvDoctors.CurrentRow.Cells[7].Value.ToString();
                txtSpecialty.Text = dgvDoctors.CurrentRow.Cells[8].Value.ToString();
                cmbClinics.Text = dgvDoctors.CurrentRow.Cells[9].Value.ToString();
                btnNew.Enabled = true;
                btnAddDoctor.Enabled = false;
                btnEditDoctor.Enabled = true;
                btnDeleteDoctor.Enabled = true;

            }
            catch
            {
                return;
            }
        }

        private void btnRefreshDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحديث قائمة الأطباء ", " تحديث قائمة بيانات الأطباء", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoctorName.Text) || string.IsNullOrWhiteSpace(txtDoctorNatNum.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text) || string.IsNullOrWhiteSpace(txtDoctorPhone.Text) || string.IsNullOrWhiteSpace(txtDoctorAddress.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                DoctorsManagement doctorsmanagement = new DoctorsManagement();
                doctorsmanagement.EditDoctor(Convert.ToInt32(dgvDoctors.CurrentRow.Cells[0].Value), txtDoctorName.Text, txtDoctorNatNum.Text, cmbDoctorGender.Text,
                txtDoctorPhone.Text, txtDoctorAddress.Text, cmbContractType.Text, cmbDoctorsSocial.Text, txtSpecialty.Text, Convert.ToInt32(cmbClinics.SelectedValue));
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                //  MessageBox.Show("تم تعديل البيانات بنجاح", " تعديل بيانات الطبيب ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                ClearTools();
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try { 
                  MessageDialog.Caption = "تأكيد الحذف";
                  MessageDialog.Text = "هل تريد بالفعل حذف الطبيب المحدد ";
                  MessageDialog.Parent = this.FindForm();
                  var result = MessageDialog.Show();
                  if (dgvDoctors.Rows.Count == 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    DoctorsManagement doctorsmanagement = new DoctorsManagement();
                    doctorsmanagement.DeleteDoctor(Convert.ToInt32(dgvDoctors.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();

                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة الأطباء ", " حذف طبيب ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSearchDoctors_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DoctorsManagement doctorsmanagement = new DoctorsManagement();
                dgvDoctors.DataSource = doctorsmanagement.SearchDoctorByNameOrNatNum(txtSearchDoctors.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnPrintDoctors_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.Rows.Count == 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الطباعة ", "تنبيه", MessageBoxButtons.OK);
                return;
            }

            try
            {
                RptListDoctors rptDoctors = new RptListDoctors();

                FrmReport frmrpt = new FrmReport();
                rptDoctors.Refresh();
                frmrpt.crystalReportViewer1.ReportSource = rptDoctors;
                frmrpt.Show();
            }

            catch
            {
                MessageBox.Show("حدث خطأ أثناء الطباعة يُرجى المحاولة لاحـقًـا", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void btnPrintOne_Click(object sender, EventArgs e)
        {
            try
            {

                RptOneDoctor rptOneDoctor = new RptOneDoctor();
                //("@Id",this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                rptOneDoctor.SetParameterValue("@Doctor_Id", this.dgvDoctors.CurrentRow.Cells[0].Value.ToString());
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptOneDoctor;
                frmrpt.crystalReportViewer1.ShowRefreshButton = false;
                frmrpt.Show();
            }
            catch
            {
                Forms.FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد الطبيب ";
                frmalert.ShowDialog();
                // MessageBox.Show("يرجى الـتـأكـد من تحديد الطبيب ","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
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

                RptListDoctorByContractType rptdocbycontracttype = new RptListDoctorByContractType();
                //("@Id",this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (rdbAsassi.Checked == true)
                {
                    conttacttype = "أساسي";
                }
                else
                {
                    conttacttype = "متعاون";
                }
                rptdocbycontracttype.SetParameterValue("@Word", conttacttype);
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ShowRefreshButton = false;
                frmrpt.crystalReportViewer1.ReportSource = rptdocbycontracttype;
                frmrpt.Show();
            }
            catch
            {
                Forms.FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد نوع العقد ";
                frmalert.ShowDialog();
                // MessageBox.Show("يرجى الـتـأكـد من تحديد الموظف ","تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
