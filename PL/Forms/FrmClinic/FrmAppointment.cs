using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL.GeneralFunction;
using BeninaClinic.BL.Clinic;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.Forms.FrmClinic
{
    public partial class FrmAppointment : Form
    {

        // Single Instance
        private static FrmAppointment instance;

        public static FrmAppointment GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmAppointment();
            }
            return instance;
        }

        public FrmAppointment()
        {
            InitializeComponent();
            
        }




        private void FrmAppointment_Load(object sender, EventArgs e)
        {
            MainFunction.FillComboBox(cmbClinic, "GetAllClinics", "ClinicName", "Clinic_Id");
            FillComboBoxWithTime();
            btnAddApp.Enabled = false;
            btnEditApp.Enabled = false;
            btnDeleteApp.Enabled = false;
            btnFrmListPatient.Enabled = false;
            LoadData();
            this.KeyPreview = true;
            //ClearTools();
        }


        void ClearTools()
        {
            txtAppID.Text = MainFunction.GetMaxID("tblAppointments", "Appointment_Id").ToString();
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtDocID.Clear();
            txtNote.Clear();
            cmbAppStatus.SelectedIndex = -1;
            cmbAppType.SelectedIndex = -1;
            cmbClinic.SelectedIndex = -1;
            cmbDoctorName.SelectedIndex = -1;
            cmbTimes.SelectedIndex = -1;
            dtpDateApp.Value = DateTime.Now;
            btnNew.Enabled = false;
            btnAddApp.Enabled = true;
            btnFrmListPatient.Enabled = true;
            btnEditApp.Enabled = false;
            btnDeleteApp.Enabled = false;
        }

        private void cmbDoctorName_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbClinic.Text))
                {
                    MessageBox.Show("يـرجـى أخـتـيـار العيادة ", "تـنبـيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DoctorsManagement doctorsmanagement = new DoctorsManagement();
                cmbDoctorName.DataSource = doctorsmanagement.GetDoctorsByClinic(Convert.ToInt32(cmbClinic.SelectedValue));
                cmbDoctorName.DisplayMember = "DoctorName";
                cmbDoctorName.ValueMember = "Doctor_Id";
            }
            catch
            {
                return;
            }
        }




        private void FillComboBoxWithTime()
        {
            TimeSpan startTime = TimeSpan.Parse("08:00");
            TimeSpan endTime = TimeSpan.Parse("23:30");
            TimeSpan interval = TimeSpan.FromMinutes(30);

            // تنظيف الـ ComboBox قبل تعبئته
            cmbTimes.Items.Clear();

            TimeSpan currentTime = startTime;

            while (currentTime <= endTime)
            {
                cmbTimes.Items.Add(currentTime.ToString(@"hh\:mm")); //ساعات ودقائق بدون ثواني
                currentTime = currentTime.Add(interval);
            }
        }

        private void btnFrmListPatient_Click(object sender, EventArgs e)
        {
            Frm_Select_Patient frmselectpat = new Frm_Select_Patient();
            frmselectpat.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(cmbDoctorName.Text) || string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(cmbClinic.Text) || string.IsNullOrWhiteSpace(cmbClinic.Text) || string.IsNullOrWhiteSpace(cmbAppStatus.Text) || string.IsNullOrWhiteSpace(cmbAppType.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                AppointmentManagement appointmentmanagement = new AppointmentManagement();
                string Selectedtime = cmbTimes.SelectedItem.ToString();
                TimeSpan timevalue;
                if (TimeSpan.TryParseExact(Selectedtime ,"hh\\:mm",null, out timevalue))
                {
                    try
                    {
                        appointmentmanagement.InsertAppointment(Convert.ToInt32(txtPatientID.Text), Convert.ToInt32(txtDocID.Text), cmbAppStatus.Text, cmbAppType.Text, dtpDateApp.Value, timevalue, txtNote.Text);
                        FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                        frmsuccesmessagebox.ShowDialog();

                        //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LoadData();
                        ClearTools();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                     MessageBox.Show("تنسيق التوقيت غير صحيح !", " حجز موعد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        public void LoadData()
        {
            try
            {
                AppointmentManagement appointmentmanagement = new AppointmentManagement();
                dgvAppointments.AutoGenerateColumns = false;
                // dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
                dgvAppointments.Columns[3].DefaultCellStyle.Format = "hh\\:mm"; // Veryyyyyyyyyyyyyyy Importent
                dgvAppointments.DataSource = appointmentmanagement.GetAllAppointment();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل بيانات الموظفين", " تحميل الموظفين", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditApp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAppID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(cmbDoctorName.Text) || string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(cmbClinic.Text) || string.IsNullOrWhiteSpace(cmbClinic.Text) || string.IsNullOrWhiteSpace(cmbAppStatus.Text) || string.IsNullOrWhiteSpace(cmbAppType.Text))
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                AppointmentManagement appointmentmanagement = new AppointmentManagement();
                string Selectedtime = cmbTimes.SelectedItem.ToString();
                TimeSpan timevalue;
                if (TimeSpan.TryParseExact(Selectedtime, "hh\\:mm", null, out timevalue))
                {
                    try
                    {
                        appointmentmanagement.EditAppointment(Convert.ToInt32(txtAppID.Text), Convert.ToInt32(txtDocID.Text), cmbAppStatus.Text, cmbAppType.Text, dtpDateApp.Value, timevalue, txtNote.Text);
                        FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                        frmsuccesmessagebox.ShowDialog();

                        //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LoadData();
                        ClearTools();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void cmbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDocID.Text = cmbDoctorName.SelectedValue.ToString();
            }
            catch { return; }
        }

        private void dgvAppointments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtAppID.Text = dgvAppointments.CurrentRow.Cells[0].Value.ToString();
                txtPatientName.Text = dgvAppointments.CurrentRow.Cells[1].Value.ToString();
                dtpDateApp.Text = dgvAppointments.CurrentRow.Cells[2].Value.ToString();
                cmbTimes.Text = ((TimeSpan)dgvAppointments.CurrentRow.Cells[3].Value).ToString("hh\\:mm");
                cmbDoctorName.Text = dgvAppointments.CurrentRow.Cells[4].Value.ToString();
                cmbClinic.Text = dgvAppointments.CurrentRow.Cells[5].Value.ToString();
                cmbAppType.Text = dgvAppointments.CurrentRow.Cells[6].Value.ToString();
                cmbAppStatus.Text = dgvAppointments.CurrentRow.Cells[7].Value.ToString();
                txtPatientID.Text = dgvAppointments.CurrentRow.Cells[8].Value.ToString();
                txtDocID.Text = dgvAppointments.CurrentRow.Cells[9].Value.ToString();

                btnNew.Enabled = true;
                btnAddApp.Enabled = false;
                btnEditApp.Enabled = true;
                btnDeleteApp.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            try
            {
                MessageDialog.Caption = "تأكيد الخروج";
                MessageDialog.Text = "هل تريد بالفعل تسجيل الخروج من النظام";
                var result = MessageDialog.Show();
                if (dgvAppointments.Rows.Count <= 0)
                {
                    MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

          
               else if (result == DialogResult.Yes)
                {
                    AppointmentManagement appointmentmanagement = new AppointmentManagement();
                    appointmentmanagement.DeleteAppointment(Convert.ToInt32(dgvAppointments.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في الحذف من قائمة المواعيد ", " حذف موعد ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintApp_Click(object sender, EventArgs e)
        {
            try
            {
                RptOneAppointment rptOneappointment = new RptOneAppointment();
                rptOneappointment.SetParameterValue("@App_Id", this.dgvAppointments.CurrentRow.Cells[0].Value.ToString());
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ShowRefreshButton = false;
                frmrpt.crystalReportViewer1.ReportSource = rptOneappointment;
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتـأكـد من تحديد الموعد ";
                frmalert.ShowDialog();
            }
        }

        private void btnPrintAllApp_Click(object sender, EventArgs e)
        {
            try
           {
                RptTodayAppointments rptTodayappointment = new RptTodayAppointments();
              //rptOneappointment.SetParameterValue("@TodayApp", this.dgvAppointments.CurrentRow.Cells[0].Value.ToString());
                FrmReport frmrpt = new FrmReport();
                frmrpt.crystalReportViewer1.ShowRefreshButton = false;
                frmrpt.crystalReportViewer1.ReportSource = rptTodayappointment;
                frmrpt.Show();
            }
            catch
            {
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "حدث خطأ في الطباعة";
                frmalert.ShowDialog();
            }
        }

        private void txtSearchApp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AppointmentManagement appointmentmanagement = new AppointmentManagement();
                dgvAppointments.AutoGenerateColumns = false;
                dgvAppointments.Columns[3].DefaultCellStyle.Format = "hh\\:mm";
                dgvAppointments.DataSource = appointmentmanagement.SearchAppointment(txtSearchApp.Text);
            }
            catch
            {
                return;
            }
        }

        private void FrmAppointment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("تم تفعيل الازرار","تفعيل الازرار",MessageBoxButtons.OK);

            }
        }

        public void GetDataFromFrm(string PatientID, string PatientName)
        {
            txtPatientID.Text = PatientID;
            txtPatientName.Text = PatientName;
        }

    }
}
