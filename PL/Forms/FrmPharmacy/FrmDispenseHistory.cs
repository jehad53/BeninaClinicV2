using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL.Pharmacy;

namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    public partial class FrmDispenseHistory: Form
    {


        public FrmDispenseHistory()
        {
            InitializeComponent();
        }

        private void FrmDispense_Load(object sender, EventArgs e)
        {
            LoadDispensation();
        }

        private void InitializeCart()
        {
           
        }

        private void LoadInventory()
        {
            
        }

        private void LoadNotifications()
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDispensation();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void MatchAndAddToCart(string requestedName)
        {
          
        }

        private void LoadDispensation()
        {
            try {
                DispensationManagement dm = new DispensationManagement();
                dgvHistory.DataSource = dm.GetAllDispensation();
                }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل المصورفات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
 
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFrom.Value > dtpTo.Value)
                   MessageBox.Show("تاريخ البداية لا يمكن أن يكون أكبر من تاريخ النهاية","تنبيه");
                DispensationManagement dm = new DispensationManagement();
                dgvHistory.DataSource = dm.GetDispensationBetweenDates(dtpFrom.Value, dtpTo.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء عرض البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DispensationManagement ds = new DispensationManagement();
                dgvHistory.DataSource = ds.GetDispensationByName(txtSeatch.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnPrintDispenationHistory_Click(object sender, EventArgs e)
        {
            FrmAlertMessageBox frm = new FrmAlertMessageBox();
            frm.lblMessage.Text = "طباعة قائمة المصروفات غير متاحة حاليا !";
            frm.Show();
        }
    }
}
