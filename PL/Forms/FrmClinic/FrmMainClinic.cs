using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.PL.Forms.FrmClinic;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.UC;
using BeninaClinic.PL.UC.UCClinic;
using BeninaClinic.PL.Forms.FrmPharmacy;

namespace BeninaClinic
{
    public partial class FrmMainClinic : Form
    {

        public int State_Login_Logout { get; set; }

        public FrmMainClinic()
        {
            InitializeComponent();
            USHome();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        public void USHome()
        {
            pnlContainer.Controls.Clear();
            UCHome userControlHome = new UCHome();
            userControlHome.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            USHome();
        }

        private void btnClinics_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCClinicMangement userControlClincManagement = new UCClinicMangement();
            userControlClincManagement.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlClincManagement);

        }

        private void FrmMainClinic_Load(object sender, EventArgs e)
        {
            USHome();
            this.KeyPreview = true;
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCDoctor userControlDoctor = new UCDoctor();
            userControlDoctor.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlDoctor);
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCDepartment userControlDepartment = new UCDepartment();
            userControlDepartment.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlDepartment);
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCJob userControlJob = new UCJob();
            userControlJob.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlJob);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCEmployee userControlEmployee = new UCEmployee();
            userControlEmployee.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlEmployee);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCPatient userControlPatient = new UCPatient();
            userControlPatient.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlPatient);
        }

        private void btnDiagnoses_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCDiagnose userControlDiagnose = new UCDiagnose();
            userControlDiagnose.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlDiagnose);
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCTest userControlTest = new UCTest();
            userControlTest.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlTest);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCSetting userControlSetting = new UCSetting();
            userControlSetting.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlSetting);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnChronicDiseases_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCChronic userControlChronic = new UCChronic();
            userControlChronic.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlChronic);
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCUsers userControlUser = new UCUsers();
            userControlUser.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlUser);
        }

        private void btnMedicalReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCMedicalReport userControlMedicalReport = new UCMedicalReport();
            userControlMedicalReport.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlMedicalReport);
        }

        private void btnReocoedPatient_Click(object sender, EventArgs e)
        {
            FrmVisit frmapp = FrmVisit.GetInstance();
            frmapp.Show();
            frmapp.BringToFront();
            frmapp.Focus();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            FrmAppointment frmapp = FrmAppointment.GetInstance();
            frmapp.Width = 1162; 
            frmapp.Height = 700; 
            frmapp.Show();
            frmapp.BringToFront();
            frmapp.Focus();
        }

        private void btnDose_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCDose userControlDose = new UCDose();
            userControlDose.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlDose);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCMedicine userControlMedicine = new UCMedicine();
            userControlMedicine.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlMedicine);
        }

        private void btnRecordPatient_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UCRecordPatient userControlrecordpatient = new UCRecordPatient();
            userControlrecordpatient.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControlrecordpatient);
        }

        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            MessageDialog.Text = "هل تريد بالفعل إغــلاق النظام";
            var result = MessageDialog.Show();
            if (result == DialogResult.Yes)
            {
               Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Login frmlogin = new Frm_Login();
            frmlogin.ShowDialog();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageDialog.Caption = "تأكيد الخروج";
            MessageDialog.Text = "هل تريد بالفعل تسجيل الخروج من النظام";
            var result = MessageDialog.Show();
            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Visible = false;
                lblUserName.Text = "اسم المستخدم";
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                USHome();
            }
        }

        private void FrmMainClinic_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnLogout.Enabled && e.KeyCode == Keys.Escape)
            {
                btnLogout_Click(null, null);
            }
            else if (btnLogin.Enabled && e.KeyCode == Keys.Insert)
            {
                btnLogin_Click(null, null);
            }
            else if (btnLogout.Enabled ==false && e.KeyCode == Keys.Escape)
            {
                btnCloseSystem_Click(null,null);
            }
        }
            private void btnPharmacy_Click(object sender, EventArgs e)
        {
            FrmPharmacyMain frm = new FrmPharmacyMain();
            frm.ShowDialog();
        }

        private void btnPahrmacy_Click(object sender, EventArgs e)
        {
            USHome();
            FrmPharmacyMain frm = new FrmPharmacyMain();
            frm.ShowDialog();
        }

        private void btnAuditLogs_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            UC_AuditLogs uc = new UC_AuditLogs();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
   

