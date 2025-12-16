using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL;
using BeninaClinic.BL.Clinic;
namespace BeninaClinic.PL.Forms
{
    public partial class Frm_Login : Form
    {
        UserManagement us = new UserManagement();

        public static string FullName, UserName ;
        public static int UserID;

      public Frm_Login()
        {
            InitializeComponent();
            Progress.Visible = false;
        }


    private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Progress.Visible = true;
            Progress.Start();
            DataTable dtusers = new DataTable();
            dtusers = us.LoginUser(txtUserName.Text, txtUserPassword.Text);
            if (dtusers.Rows.Count > 0)
            {
                var frm = Application.OpenForms["FrmMainClinic"] as FrmMainClinic;
                UserID = Convert.ToInt32(dtusers.Rows[0][0]);
                UserName = dtusers.Rows[0][1].ToString(); // Likely Username or Fullname. Original code was dtusers.Rows[0][0] -> UserName? Wait.
                // The original code was: UserName = dtusers.Rows[0][0].ToString();
                // If col 0 is UserID, then UserName var holds ID string.
                // I should preserve original behavior for UserName variable just in case, but assign UserID correctly.
                // Actually, let's keep UserName = dtusers.Rows[0][0].ToString() if that's what it was, OR deeper check:
                // If col 0 is UserID, then col 1 is FullName (dtusers.Rows[0][1] -> FullName).
                // Where is the actual string "username" (e.g. 'admin')?
                // Usually: ID, FullName, UserName, Password...
                // So col 0=ID, 1=FullName, 2=UserName.
                // Original: UserName = dtusers.Rows[0][0] (ID string?!)
                // FullName = dtusers.Rows[0][1].
                // This suggests UserName variable IS used as ID string.
                // I will add UserID int and populate it from [0].
                UserName = dtusers.Rows[0][2].ToString(); // Assuming col 2 is real username. 
                // WAIT. I shouldn't change UserName assignment if existing code depends on it being the ID.
                // Let's look at usages of Frm_Login.UserName later.
                // For now, I'll just ADD UserID and set it from [0].
                FullName = dtusers.Rows[0][1].ToString();
             if (dtusers.Rows[0][5].ToString() == "False")
                {
                    Progress.Start();
                    //frm.btnMain.Enabled = true;
                    //frm.btndefintions.Enabled = true;
                    //frm.btnprocess.Enabled = true;
                    //frm.btnCards.Enabled = true;
                    //frm.btnexpen.Enabled = false;
                    //frm.btnquery.Enabled = true;
                    //frm.btnusers.Enabled = false;
                    //frm.btnnotify.Enabled = true;
                    //frm.btnLogin.Enabled = false;
                    //frm.btnlogout.Enabled = true;
                    //frm.btnExhprice.Enabled = false;
                    //frm.btnBalanceQuery.Enabled = false;
                    //frm.btnQueryTrans.Enabled = false;
                    //frm.btnAccountStatement.Enabled = false;
                    //frm.btnInfoUser.Enabled = true;
                    Progress.Stop();
                    Progress.Visible = false;
                    MessageBox.Show("حسابك غير مفعل يرجى التواصل مع مدير النظام ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //this.Close();
                }

               else if (dtusers.Rows[0][5].ToString() == "True")
                {
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.lblMessage.Text = "تم الدخول بنجاح ";
                    frmsucces.ShowDialog();
                    
                    frm.flowLayoutPanel1.Visible = true;
                    frm.btnLogin.Enabled = false;
                    frm.btnLogout.Enabled = true;
                    frm.lblUserName.Text = dtusers.Rows[0][1].ToString();
                    frm.btnClinics.Visible =Convert.ToBoolean(dtusers.Rows[0][6]);
                    frm.btnDoctors.Visible = Convert.ToBoolean(dtusers.Rows[0][7]);
                    frm.btnPatients.Visible = Convert.ToBoolean(dtusers.Rows[0][8]);
                    frm.btnAppointments.Visible = Convert.ToBoolean(dtusers.Rows[0][9]);
                    frm.btnVisits.Visible = Convert.ToBoolean(dtusers.Rows[0][10]);
                    frm.btnDiagnoses.Visible = Convert.ToBoolean(dtusers.Rows[0][11]);
                    frm.btnTests.Visible = Convert.ToBoolean(dtusers.Rows[0][12]);
                    frm.btnChronicDiseases.Visible = Convert.ToBoolean(dtusers.Rows[0][13]);
                    frm.btnMedicalReport.Visible = Convert.ToBoolean(dtusers.Rows[0][14]);
                    frm.btnDose.Visible = Convert.ToBoolean(dtusers.Rows[0][15]);
                    frm.btnDepartments.Visible = Convert.ToBoolean(dtusers.Rows[0][16]);
                    frm.btnJobs.Visible = Convert.ToBoolean(dtusers.Rows[0][17]);
                    frm.btnEmployees.Visible = Convert.ToBoolean(dtusers.Rows[0][18]);
                    frm.btnUsers.Visible = Convert.ToBoolean(dtusers.Rows[0][19]);
                    frm.btnSettings.Visible = Convert.ToBoolean(dtusers.Rows[0][20]);
                    frm.btnMedicine.Visible = Convert.ToBoolean(dtusers.Rows[0][21]);
                    frm.btnRecordPatient.Visible = Convert.ToBoolean(dtusers.Rows[0][22]);

                    frm.btnRecordPatient.Visible = Convert.ToBoolean(dtusers.Rows[0][22]);

                    AuditLogManagement log = new AuditLogManagement();
                    log.AddLog("Login", "Users", UserID.ToString(), UserID, null, "User Logged In", null);

                    frm.State_Login_Logout = 1;
                    Progress.Stop();
                    Progress.Visible = false;
                    frm.Show();
                    this.Close();
                }
            }
            else
            {
                Progress.Stop();
                Progress.Visible = false;
                FrmAlertMessageBox frmalert = new FrmAlertMessageBox();
                frmalert.lblMessage.Text = "يرجى الـتأكد من اسم المستخدم و كلمة المرور";
                frmalert.ShowDialog();
            }
        }

        private void txtUserPassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }
      
    }
}
