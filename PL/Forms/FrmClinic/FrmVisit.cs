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
using BeninaClinic.BL.HelperFunction;
using BeninaClinic.PL.UC.UCClinic;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;
namespace BeninaClinic.PL.Forms.FrmClinic
{
    public partial class FrmVisit : Form
    {
        // Single Instance
        private static FrmVisit instance;

        public static FrmVisit GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmVisit();
            }
            return instance;
        }

        public FrmVisit()
        {
            InitializeComponent();
            GetTodayAppointments();
        }

        private void FrmVisit_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListAppointment_Click(object sender, EventArgs e)
        {
            FrmAppointment frmapp = FrmAppointment.GetInstance();
            frmapp.Width = 1162;
            frmapp.Height = 700;
            frmapp.Show();
            frmapp.BringToFront();
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 3;
            FrmSelection frmselection = new FrmSelection();
            UCDiagnose ucdiagnose = new UCDiagnose();
            frmselection.pnlContiner.Controls.Clear();
            ucdiagnose.Dock = DockStyle.Fill;
            frmselection.pnlContiner.Controls.Add(ucdiagnose);
            frmselection.ShowDialog();
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 2;
            FrmSelection frmselection = new FrmSelection();
            UCTest uctests = new UCTest();
            frmselection.pnlContiner.Controls.Clear();
            uctests.Dock = DockStyle.Fill;
            frmselection.pnlContiner.Controls.Add(uctests);
            frmselection.ShowDialog();
        }

        private void btnChronic_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 0;
            FrmSelection frmselection = new FrmSelection();
            UCChronic ucchronic = new UCChronic();
            frmselection.pnlContiner.Controls.Clear();
            ucchronic.Dock = DockStyle.Fill;
            frmselection.pnlContiner.Controls.Add(ucchronic);
            frmselection.ShowDialog();
        }

        private void btnMedicalReport_Click(object sender, EventArgs e)
        {
            //FrmSelection frmselection = new FrmSelection();
            //UCMedicalReport ucmedrpt = new UCMedicalReport();
            //ucmedrpt.txtRptID.Text = MainFunction.GetMaxID("tblReportMedical", "Report_Id").ToString();
            //ucmedrpt.txtPatientName.Text = txtPatientName.Text;
            //ucmedrpt.txtPatientName.Text = txtPatientName.Text;
            //ucmedrpt.txtPatientNatNum.Text = txtPatientNatNum.Text;
            //ucmedrpt.cmbPatientGender.Text = cmbPatientGender.Text;
            //ucmedrpt.txtPatientPhone.Text = txtPatientPhone.Text;
            //ucmedrpt.txtPatientAddress.Text = txtPatientAddress.Text;
            //ucmedrpt.dtpPatientDateofBirth.Text = dtpEmpDateofBirth.Text;
            //ucmedrpt.dtpPatientVisit.Text = dtpVisitDate.Text;
            //ucmedrpt.dtpReport.Text = DateTime.Now.ToShortDateString();
            //ucmedrpt.txtVisitID.Text = txtVisitID.Text;
            ////مازال رقم التقرير
            //frmselection.pnlContiner.Controls.Clear();
            //ucmedrpt.Dock = DockStyle.Fill;
            //frmselection.pnlContiner.Controls.Add(ucmedrpt);
            //frmselection.ShowDialog();

            // الفكرة الجديدة   
            FrmAppointment frmrptmed = new FrmAppointment();
            frmrptmed.Controls.Clear();
            Panel p = new Panel();
            UCMedicalReport ucmedrpt = new UCMedicalReport();
            ucmedrpt.txtRptID.Text = MainFunction.GetMaxID("tblReportMedical", "Report_Id").ToString();
            ucmedrpt.txtPatientID.Text = txtPatientID.Text;
            ucmedrpt.txtPatientName.Text = txtPatientName.Text;
            ucmedrpt.txtPatientNatNum.Text = txtPatientNatNum.Text;
            ucmedrpt.cmbPatientGender.Text = cmbPatientGender.Text;
            ucmedrpt.txtPatientPhone.Text = txtPatientPhone.Text;
            ucmedrpt.txtPatientAddress.Text = txtPatientAddress.Text;
            ucmedrpt.dtpPatientDateofBirth.Text = dtpEmpDateofBirth.Text;
            ucmedrpt.dtpPatientVisit.Text = dtpVisitDate.Text;
            ucmedrpt.dtpReport.Text = DateTime.Now.ToShortDateString();
            ucmedrpt.txtVisitID.Text = txtVisitID.Text;
            ucmedrpt.txtClinicName.Text = txtClinicName.Text;
            ucmedrpt.txtDoctorID.Text = txtDoctorID.Text;
            ucmedrpt.txtDoctorName.Text = txtDoctorName.Text;
            ////مازال رقم التقرير
            p.Controls.Clear();
            p.Dock = DockStyle.Fill;
            ucmedrpt.Dock = DockStyle.Fill;
            p.Controls.Add(ucmedrpt);
            frmrptmed.Controls.Add(p);
            //frmselection.pnlContiner.Controls.Clear();
            //ucmedrpt.Dock = DockStyle.Fill;
            //frmselection.pnlContiner.Controls.Add(ucmedrpt);
            //frmselection.ShowDialog();
            frmrptmed.ShowDialog();
        }

        public void GetTodayAppointments()
        {
            try
            {
                VisitManagement visitmanagement = new VisitManagement();
                dgvTodayAppointments.AutoGenerateColumns = false;
                // dgvTodayAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
                dgvTodayAppointments.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
                dgvTodayAppointments.DataSource = visitmanagement.GetTodayAppointments();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الوظائف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefreshAppointment_Click(object sender, EventArgs e)
        {
            GetTodayAppointments();
        }

        private void dgvTodayAppointments_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTodayAppointments.Rows.Count <= 0)
            {
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.lblMessage.Text = "القائمة فارغة لا يمكن الاختيار";
                frmalertmessagebox.ShowDialog();
                return;
            }
            try
            {
                txtVisitID.Text = MainFunction.GetMaxID("tblVisits", "Visit_Id").ToString();
                txtPatientID.Text = dgvTodayAppointments.CurrentRow.Cells[9].Value.ToString(); 
                txtDoctorID.Text = dgvTodayAppointments.CurrentRow.Cells[10].Value.ToString(); 
                txtPatientName.Text = dgvTodayAppointments.CurrentRow.Cells[0].Value.ToString();
                txtDoctorName.Text = dgvTodayAppointments.CurrentRow.Cells[1].Value.ToString();
                txtClinicName.Text = dgvTodayAppointments.CurrentRow.Cells[3].Value.ToString();
                dtpVisitDate.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                //باقي بيانات المريض
                txtPatientNatNum.Text = dgvTodayAppointments.CurrentRow.Cells[4].Value.ToString();
                cmbPatientGender.Text = dgvTodayAppointments.CurrentRow.Cells[5].Value.ToString();
                txtPatientPhone.Text = dgvTodayAppointments.CurrentRow.Cells[6].Value.ToString();
                dtpEmpDateofBirth.Text = dgvTodayAppointments.CurrentRow.Cells[7].Value.ToString();
                txtPatientAddress.Text = dgvTodayAppointments.CurrentRow.Cells[8].Value.ToString();
                //txtNote.Text = dgvTodayAppointments.CurrentRow.Cells[8].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvDignoses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if (dgvDignoses.Rows.Count <= 0)
                    return;
                else
                {
                    dgvDignoses.Rows.Remove(dgvDignoses.CurrentRow);
                }
            }
        }

        private void dgvTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvTests.Rows.Count <= 0)
                    return;
                else
                {
                    dgvTests.Rows.Remove(dgvTests.CurrentRow);
                }
            }
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 1;
            FrmSelection frmselection = new FrmSelection();
            UCMedicine ucMedicine = new UCMedicine();
            frmselection.pnlContiner.Controls.Clear();
            ucMedicine.Dock = DockStyle.Fill;
            frmselection.pnlContiner.Controls.Add(ucMedicine);
            frmselection.ShowDialog();
        }

        private void FrmVisit_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.MedcineID = "";
            GlobalVar.MedcineName = "";
            GlobalVar.SciniceName ="";
            GlobalVar.MedcineType = "";
        }

        private void dgvMedicen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (dgvMedicen.Rows.Count <= 0)
                    return;
                else
                {
                    dgvMedicen.Rows.Remove(dgvMedicen.CurrentRow);
                }
            }
        }

        private void dgvChronics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvChronics.Rows.Count <= 0)
                    return;
                else
                {
                    dgvChronics.Rows.Remove(dgvChronics.CurrentRow);
                }
            }
        }

        private void dgvTodayAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnAddVisit_Click(object sender, EventArgs e)
        {
            VisitManagement vm = new VisitManagement();
            if (string.IsNullOrWhiteSpace(txtVisitID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.lblMessage.Text = "يرجى اختيار الحالة";
                frm.ShowDialog();
            }
            else
            {
                vm.InsertVisit(Convert.ToInt32(txtPatientID.Text), Convert.ToInt32(txtDoctorID.Text), dtpVisitDate.Value , txtVisitNote.Text);
               // MessageBox.Show("تم إدخال الزيارة","تنبيه",MessageBoxButtons.OK);
            }
            if (dgvDignoses.Rows.Count > 0)
            {
                for (int i = 0; i <= dgvDignoses.Rows.Count - 1; i++)
                    vm.InsertVisitDiagnosis(Convert.ToInt32(txtVisitID.Text),Convert.ToInt32(dgvDignoses.Rows[i].Cells[0].Value) , dgvDignoses.Rows[i].Cells[1].Value.ToString(), dgvDignoses.Rows[i].Cells[2].Value.ToString(),"Note --> Put Another Time");
            }
            if (dgvTests.Rows.Count > 0)
            {
                for (int i = 0; i <= dgvTests.Rows.Count - 1; i++)
                    vm.InsertVisitTests(Convert.ToInt32(txtVisitID.Text), Convert.ToInt32(dgvTests.Rows[i].Cells[0].Value), dgvTests.Rows[i].Cells[1].Value.ToString(), dgvTests.Rows[i].Cells[2].Value.ToString(), "Note --> Put Another Time");
            }

            // مازال موضوع إدخال الجرعة
            if (dgvMedicen.Rows.Count > 0)
            {
                for (int i = 0; i <= dgvMedicen.Rows.Count - 1; i++)
                    vm.InsertVisitMedications(Convert.ToInt32(txtVisitID.Text), Convert.ToInt32(dgvMedicen.Rows[i].Cells[0].Value), dgvMedicen.Rows[i].Cells[2].Value.ToString(), dgvMedicen.Rows[i].Cells[1].Value.ToString(), "Note --> Put Another Time");
            }
            //  ممكن نضيف الأمراض المزمنة

            FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
            frmsucces.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVisitID.Text))
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى كتابة رقم الزيارة";
                frmalert.ShowDialog();
                return;
            }
            try
            {
                RptGetOneVisit rptonevisit = new RptGetOneVisit();
                rptonevisit.SetParameterValue("@Visit_Id", txtVisitID.Text);
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptonevisit;
                frmrpt.crystalReportViewer1.Refresh();
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "حدث خطأ في الطباعة";
                frmalert.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVisitID.Text))
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى كتابة رقم الزيارة";
                frmalert.ShowDialog();
                return;
            }
            try
            {
                RptGetVisitTest rpttestvisit = new RptGetVisitTest();
                rpttestvisit.SetParameterValue("@Visit_Id", txtVisitID.Text);
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rpttestvisit;
                frmrpt.crystalReportViewer1.Refresh();
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "حدث خطأ في الطباعة";
                frmalert.ShowDialog();
            }
        }

        private void btnAllVisitData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVisitID.Text))
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى كتابة رقم الزيارة";
                frmalert.ShowDialog();
                txtVisitID.FillColor = Color.WhiteSmoke;
                txtVisitID.Focus();
                return;
            }
            try
            {
                RptAllVisitData rptallvisitdata = new RptAllVisitData();
                rptallvisitdata.SetParameterValue("@Visit_Id", txtVisitID.Text);
                rptallvisitdata.SetParameterValue("@Visit_Id", txtVisitID.Text, "RptDiagonsis"); // SubRpt1
                rptallvisitdata.SetParameterValue("@Visit_Id", txtVisitID.Text, "RptTests"); // SubRpt2
                rptallvisitdata.SetParameterValue("@Visit_Id", txtVisitID.Text, "RptMedicines"); // SubRpt3
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ReportSource = rptallvisitdata;
                //frmrpt.crystalReportViewer1.Refresh();
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "حدث خطأ في الطباعة";
                frmalert.ShowDialog();
            }
        }

        private void btnRecordsPatient_Click(object sender, EventArgs e)
        {
            UCRecordPatient ucrecordpatient = new UCRecordPatient();
            FrmAppointment frmselection = new FrmAppointment();
            frmselection.Controls.Clear();
            ucrecordpatient.Dock = DockStyle.Fill;
            frmselection.Controls.Add(ucrecordpatient);
            ucrecordpatient.txtNatNum.ReadOnly =true;
            ucrecordpatient.lbPatientID.Text = txtPatientID.Text;
            ucrecordpatient.txtNatNum.Text = txtPatientNatNum.Text;
            frmselection.Text = "سجل المريض";
            ucrecordpatient.lbPatineName.Text = txtPatientName.Text;
            ucrecordpatient.lbNatNum.Text = txtPatientNatNum.Text;
           // ucrecordpatient.lbAge.Text = Convert.Text; // حساب العمر
            ucrecordpatient.lbBOD.Text = dtpEmpDateofBirth.Text;
            ucrecordpatient.LBgENDER.Text = cmbPatientGender.Text;
            ucrecordpatient.lbPhone.Text = txtPatientPhone.Text;
            ucrecordpatient.lbAddress.Text = txtPatientAddress.Text;
            ucrecordpatient.lbBloodType.Text = "سيتم إضافة فصيلة الدم";

            frmselection.ShowDialog();
        }
    }
}
