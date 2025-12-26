using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    public partial class FrmPharmacyMain : Form
    {
        public FrmPharmacyMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FrmMedicationList frm = new FrmMedicationList();
            frm.ShowDialog();
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
           FrmDispense frm = new FrmDispense();
           frm.ShowDialog();
        }

        private void btnDispenseHistory_Click(object sender, EventArgs e)
        {
            FrmDispenseHistory frm = new FrmDispenseHistory();
            frm.ShowDialog();
        }

        private void FrmPharmacyMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnInventory.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnDispense.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDispenseHistory.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
              //  زر الصرف العام
            }
        }
    }
}
