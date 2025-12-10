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

namespace BeninaClinic.PL.Forms.FrmClinic
{
    public partial class Frm_Select_Patient : Form
    {
        private static Frm_Select_Patient instance;

        public static Frm_Select_Patient GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Frm_Select_Patient();
            }
            return instance;
        }

        public Frm_Select_Patient()
        {
            InitializeComponent();
        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    var frmapp = Application.OpenForms.OfType<FrmAppointment>().FirstOrDefault();
            //    var frmappt = Application.OpenForms["FrmAppointment"] as FrmAppointment;
            //    frmappt.txtPatientID.Text = dgvPatients.CurrentRow.Cells[0].Value.ToString();
            //    frmappt.txtPatientName.Text = dgvPatients.CurrentRow.Cells[1].Value.ToString();
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            this.Close();
        }

        public void LoadPatietns()
        {
            PatientManagement patientmanagement = new PatientManagement();
            dgvPatients.AutoGenerateColumns = false;
            //dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 12, FontStyle.Bold);
            dgvPatients.DataSource = patientmanagement.GetAllPatients();
        }

        private void Frm_Select_Patient_Load(object sender, EventArgs e)
        {
            LoadPatietns();
        }

        private void dgvPatients_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
               
                var frmappt = Application.OpenForms["FrmAppointment"] as FrmAppointment;
                frmappt.txtPatientID.Text = dgvPatients.CurrentRow.Cells[0].Value.ToString();
                frmappt.txtPatientName.Text = dgvPatients.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
