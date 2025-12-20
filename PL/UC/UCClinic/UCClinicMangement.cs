using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic;
using BeninaClinic.BL.Clinic;
using BeninaClinic.BL.GeneralFunction;
using BeninaClinic.PL.Forms;
using BeninaClinic.PL.Reports;
using BeninaClinic.PL.Reports.RptClinic;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCClinicMangement : UserControl
    {
        public UCClinicMangement()
        {
            InitializeComponent();
            btnAddClinic.Enabled = false;
            btnEditClinic.Enabled = false;
            btnDeleteClinic.Enabled = false;

        }

        private void UCClinicMangement_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvClinic.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void ClearTools()
        {
            txtClinicID.Text = MainFunction.GetMaxID("tblClinics", "Clinic_Id").ToString();
            txtClinicName.Clear();
            txtClinicManger.Clear();
            txtClinicPhone.Clear();
            txtClinicName.Focus();
            btnNew.Enabled = false;
            btnAddClinic.Enabled = true;
            btnEditClinic.Enabled = false;
            btnDeleteClinic.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTools();
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClinicID.Text) || string.IsNullOrWhiteSpace(txtClinicName.Text) || string.IsNullOrWhiteSpace(txtClinicManger.Text))
            {
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                ClinicManagement clinemanagement = new ClinicManagement();
                clinemanagement.EditClinics(Convert.ToInt32(txtClinicID.Text),txtClinicName.Text , txtClinicManger.Text , txtClinicPhone.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                LoadData();
               
            }
        }

        //BTN ADD CLINIC
        private void btnAddClinic_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtClinicName.Text) || string.IsNullOrWhiteSpace(txtClinicManger.Text) )
            {
                // MessageBox.Show("يرجى إدخال البيانات", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                FrmAlertMessageBox frmalertmessagebox = new FrmAlertMessageBox();
                frmalertmessagebox.ShowDialog();
            }
            else
            {
                ClinicManagement clinemanagement = new ClinicManagement();
                clinemanagement.InsertClinic(txtClinicName.Text,txtClinicManger.Text,txtClinicPhone.Text);
                FrmSuccesMessageBox frmsuccesmessagebox = new FrmSuccesMessageBox();
                frmsuccesmessagebox.ShowDialog();
                LoadData();
                //  MessageBox.Show("تم إدخال البيانات بنجاح", " إدخال عيادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTools();
            }

        }

        private void btnShowAsForm_Click(object sender, EventArgs e)
        {
          //  FrmTestUserControl frm = new FrmTestUserControl();
            UC.UCClinic.UCClinicMangement userclinic = new UCClinicMangement();
         //   frm.panel1.Controls.Clear();
            userclinic.Dock = DockStyle.Fill;
          //  frm.panel1.Controls.Add(userclinic);
          //  frm.Show();
        }

        private void btnRefreshClinic_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void LoadData()
        {
            ClinicManagement clinemanagement = new ClinicManagement();
            dgvClinic.AutoGenerateColumns = false;
            dgvClinic.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Regular);
            dgvClinic.DataSource = clinemanagement.GetAllClinics();
        }

        private void dgvClinic_DoubleClick(object sender, EventArgs e)
        {
            if(dgvClinic.Rows.Count == 0)
            { 
                MessageBox.Show("القائمة فارغة لا يمكن الاختيار", " تحذير", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           else 
            {
                btnNew.Enabled = true;
                btnAddClinic.Enabled = false;
                btnEditClinic.Enabled = true;
                btnDeleteClinic.Enabled = true;
                txtClinicID.Text = dgvClinic.CurrentRow.Cells[0].Value.ToString();
                txtClinicName.Text = dgvClinic.CurrentRow.Cells[1].Value.ToString();
                txtClinicManger.Text = dgvClinic.CurrentRow.Cells[2].Value.ToString();
                txtClinicPhone.Text = dgvClinic.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnDeleteClinic_Click(object sender, EventArgs e)
        {
            MessageDialog.Caption = "تأكيد الحذف";
            MessageDialog.Text = "هل تريد بالفعل حذف العيادة المحددة ";
            MessageDialog.Parent = this.FindForm();
            var result = MessageDialog.Show();
            if (dgvClinic.Rows.Count == 0)
            {
                MessageBox.Show("القائمة فارغة لا يمكن الحذف", " تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else if ( result == DialogResult.Yes)
            {
                try
                {
                    ClinicManagement clinemanagement = new ClinicManagement();
                    clinemanagement.DeleteClinics(Convert.ToInt32(dgvClinic.CurrentRow.Cells[0].Value));
                    FrmSuccesMessageBox frmsucces = new FrmSuccesMessageBox();
                    frmsucces.Show();
                    ClearTools();
                    LoadData();
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnPrintClinic_Click(object sender, EventArgs e)
        {
            RptListClinic rptListClinic = new RptListClinic();
            FrmReport frmrpt = new FrmReport();
            frmrpt.crystalReportViewer1.ReportSource = rptListClinic;
            frmrpt.Show();
        }
    }
}
