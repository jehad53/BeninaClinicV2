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
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;
namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCMedicalReport : UserControl
    {
        public UCMedicalReport()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            txtRptContent.TextAlign = HorizontalAlignment.Right;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            txtRptContent.TextAlign = HorizontalAlignment.Center;

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtRptContent.TextAlign = HorizontalAlignment.Left;

        }

        private void btnTypeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtRptContent.Font = fontDialog1.Font;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicineReportManagement medicinereportmanagement = new MedicineReportManagement();
            if (string.IsNullOrWhiteSpace(txtVisitID.Text) || string.IsNullOrWhiteSpace(txtRptID.Text) || string.IsNullOrWhiteSpace(txtRptContent.Text) || string.IsNullOrWhiteSpace(txtPatientID.Text) ||string.IsNullOrWhiteSpace(txtDoctorID.Text))
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.lblMessage.Text = "يرجى التـأكد من إدخال البيانات";
                frm.ShowDialog();
            }
            else
            {
                medicinereportmanagement.InsertReportMedical(dtpReport.Value, txtRptContent.Text, Convert.ToInt32(txtVisitID.Text), Convert.ToInt32(txtPatientID.Text), txtPatientName.Text, cmbPatientGender.Text, dtpPatientDateofBirth.Value, 24, txtDoctorName.Text, txtClinicName.Text);
                FrmSuccesMessageBox frm = new FrmSuccesMessageBox();
                frm.ShowDialog();
                if (MessageBox.Show("هل تريد طباعة التقرير؟", "تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrintMedicineReport();
                }
            }
        }


        public void PrintMedicineReport()
        {
            try
            {
                RptMedicineReport rptmedicine = new RptMedicineReport();
                rptmedicine.SetParameterValue("Report_Id", txtRptID.Text);
                FrmReport frm = new FrmReport();
                frm.crystalReportViewer1.ReportSource = rptmedicine;
                frm.Show();

            }
            catch
            {
                FrmAlertMessageBox frm = new FrmAlertMessageBox();
                frm.lblMessage.Text = "حدث خطأ أثناء الطباعة";
                frm.ShowDialog();
            }
        }

    }
}
