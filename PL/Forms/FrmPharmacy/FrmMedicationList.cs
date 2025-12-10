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
    public partial class FrmMedicationList : Form
    {
        MedicationManagement mm = new MedicationManagement();

        public FrmMedicationList()
        {
            InitializeComponent();
            dgvMedications.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvMedications.AutoGenerateColumns = false;
                dgvMedications.DataSource = mm.GetAllMedications();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddMedication frm = new FrmAddMedication();
            frm.ShowDialog();
            LoadData(); // Refresh on close
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedications.SelectedRows[0].Cells[0].Value);
                FrmAddMedication frm = new FrmAddMedication(id);
                frm.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار دواء للتعديل");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count > 0)
            {
                MessageDialog.Caption = "تأكيد حذف";
                MessageDialog.Text = "هل تريد بالفعل حذف الدواء المحدد من قائمة الأدوية";
                var result = MessageDialog.Show();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dgvMedications.SelectedRows[0].Cells[0].Value);
                        mm.DeleteMedication(id);
                        MessageBox.Show("تم الحذف بنجاح");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار دواء للحذف");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvMedications.DataSource = mm.SearchMedications(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
