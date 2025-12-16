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
using BeninaClinic.BL.Clinic;
using BeninaClinic.PL.Forms;

namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    public partial class FrmEmployeeDispensing : Form
    {
        EmployeeDispensingManagement edm = new EmployeeDispensingManagement();
        MedicationManagement mm = new MedicationManagement();
        EmployeesManagement em = new EmployeesManagement();
        
        DataTable dtInventory;
        DataTable dtCart;

        // Controls
        private ComboBox cmbEmployees;
        private ComboBox cmbMedication; // Or Search TextBox + List
        private TextBox txtQuantity;
        private Button btnAdd;
        private DataGridView dgvCart;
        private Button btnSave;
        private Label lblTotal;
        private Label lblEmp;
        private Label lblMed;
        private Label lblQty;

        public FrmEmployeeDispensing()
        {
            InitializeComponent();
            InitializeCart();
        }

        private void InitializeComponent()
        {
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbMedication = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "صرف أدوية للموظفين";
            this.Load += new System.EventHandler(this.FrmEmployeeDispensing_Load);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            // Labels
            this.lblEmp.Text = "الموظف:";
            this.lblEmp.Location = new Point(20, 20);
            this.lblEmp.AutoSize = true;

            this.lblMed.Text = "الدواء:";
            this.lblMed.Location = new Point(300, 20);
            this.lblMed.AutoSize = true;

            this.lblQty.Text = "الكمية:";
            this.lblQty.Location = new Point(600, 20);
            this.lblQty.AutoSize = true;

            // cmbEmployees
            this.cmbEmployees.Location = new Point(80, 20);
            this.cmbEmployees.Size = new Size(200, 25);
            this.cmbEmployees.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbEmployees.AutoCompleteSource = AutoCompleteSource.ListItems;

            // cmbMedication
            this.cmbMedication.Location = new Point(350, 20);
            this.cmbMedication.Size = new Size(200, 25);
            this.cmbMedication.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMedication.AutoCompleteSource = AutoCompleteSource.ListItems;

            // txtQuantity
            this.txtQuantity.Location = new Point(650, 20);
            this.txtQuantity.Size = new Size(50, 25);
            this.txtQuantity.Text = "1";

            // btnAdd
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Location = new Point(710, 18);
            this.btnAdd.Size = new Size(70, 30);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            // dgvCart
            this.dgvCart.Location = new Point(20, 70);
            this.dgvCart.Size = new Size(760, 400);
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.ReadOnly = true;

            // btnSave
            this.btnSave.Text = "حفظ وصرف";
            this.btnSave.Location = new Point(20, 500);
            this.btnSave.Size = new Size(150, 40);
            this.btnSave.Click += new EventHandler(btnSave_Click);

            // lblTotal
            this.lblTotal.Text = "الإجمالي: 0.00";
            this.lblTotal.Location = new Point(600, 500);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Arial", 14, FontStyle.Bold);

            // Add Controls
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.cmbMedication);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotal);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void FrmEmployeeDispensing_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadMedications();
        }

        private void InitializeCart()
        {
            dtCart = new DataTable();
            dtCart.Columns.Add("MedicationId", typeof(int));
            dtCart.Columns.Add("Name", typeof(string));
            dtCart.Columns.Add("Price", typeof(decimal));
            dtCart.Columns.Add("Quantity", typeof(int));
            dtCart.Columns.Add("Total", typeof(decimal), "Price * Quantity");
            
            dgvCart.DataSource = dtCart;
            dgvCart.Columns["MedicationId"].Visible = false;
        }

        private void LoadEmployees()
        {
            try
            {
                DataTable dt = em.GetAllEmployees();
                cmbEmployees.DataSource = dt;
                cmbEmployees.DisplayMember = "EmployeeName"; // Assuming Column Name
                cmbEmployees.ValueMember = "Employee_Id"; // Assuming ID Column
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadMedications()
        {
            try
            {
                dtInventory = mm.GetAllMedications();
                cmbMedication.DataSource = dtInventory;
                cmbMedication.DisplayMember = "Name";
                cmbMedication.ValueMember = "Id";
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbMedication.SelectedIndex == -1) return;
            
            try
            {
                int medId = Convert.ToInt32(cmbMedication.SelectedValue);
                int qty = Convert.ToInt32(txtQuantity.Text);
                
                // Check Stock
                DataRow[] rows = dtInventory.Select("Id = " + medId);
                if(rows.Length > 0)
                {
                    int stock = Convert.ToInt32(rows[0]["Quantity"]);
                    if(qty > stock)
                    {
                        MessageBox.Show("الكمية المطلوبة غير متوفرة. المتوفر: " + stock);
                        return;
                    }
                    decimal price = Convert.ToDecimal(rows[0]["SellingPrice"]); // Or PurchasePrice based on policy? Usually Selling.
                    
                    // Add to Cart
                    DataRow newRow = dtCart.NewRow();
                    newRow["MedicationId"] = medId;
                    newRow["Name"] = rows[0]["Name"].ToString();
                    newRow["Price"] = price;
                    newRow["Quantity"] = qty;
                    dtCart.Rows.Add(newRow);
                    
                    UpdateTotal();
                }
            }
            catch { MessageBox.Show("خطأ في البيانات"); }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in dtCart.Rows)
                total += Convert.ToDecimal(row["Total"]);
            lblTotal.Text = "الإجمالي: " + total.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count == 0) return;
            if (cmbEmployees.SelectedIndex == -1) { MessageBox.Show("يرجى اختيار موظف"); return; }

            try
            {
                int empId = Convert.ToInt32(cmbEmployees.SelectedValue);
                string empName = cmbEmployees.Text;

                decimal total = 0;
                foreach (DataRow row in dtCart.Rows) total += Convert.ToDecimal(row["Total"]);

                int userId = Frm_Login.UserID;
                
                int dispId = edm.InsertDispensation(userId, empId, empName, total, "");

                foreach (DataRow row in dtCart.Rows)
                {
                    int medId = Convert.ToInt32(row["MedicationId"]);
                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal cost = Convert.ToDecimal(row["Price"]);
                    edm.InsertDispensationDetail(dispId, medId, qty, cost);
                }
                
                MessageBox.Show("تم الصرف بنجاح");
                dtCart.Rows.Clear();
                lblTotal.Text = "الإجمالي: 0.00";
                LoadMedications(); // Refresh stock
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
