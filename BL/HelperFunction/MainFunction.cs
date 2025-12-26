using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;
namespace BeninaClinic.BL.GeneralFunction
{
    public static class MainFunction
    {

        public static int GetMaxID(string tblname, string fieldname)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@tblName", SqlDbType.VarChar, 50);
            prm[0].Value = tblname;
            prm[1] = new SqlParameter("@fieldName", SqlDbType.VarChar, 50);
            prm[1].Value = fieldname;
            try
            {
                Db dbb = new Db();
                using (Db db = new Db())
                {
                    int Num = db.MaxID("GetMaxID", prm);
                    return Num;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error in GETMAXID ", ex.Message);
            }
        }


        public static void FillComboBox(ComboBox combo, string storedName, string displayMember, string valueMember)
        {
            try
            {
                using (Db db = new Db())
                {
                    DataTable dt = db.ReadData(storedName, null);
                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تعبئة القائمة: " + ex.Message);
            }
        }
         // جلب عدد الصفوف 
        public static int GetTotalPages(string storedProcedureName, int pageSize)
        {
            DataTable dt = new DataTable();
            using (Db db = new Db())
                {
                 dt = db.ReadData(storedProcedureName, null);
                }

            int totalRows = Convert.ToInt32(dt.Rows[0]["TotalRows"]);

            int totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
                
            return totalPages;
        }



        // دالة حساب عدد الصفحات العامة
        public static int GetTotalPagesGeneral(string tableName, int pageSize)
        {
            DataTable dt = new DataTable();

            using (Db db = new Db())
           {
                SqlParameter[] param =
             {
            new SqlParameter("@TableName", tableName)
             };
            dt = db.ReadData("GetTotalCount", param);
           } 

            int totalRows = Convert.ToInt32(dt.Rows[0]["TotalRows"]);
            return (int)Math.Ceiling((double)totalRows / pageSize);
        }
    



    // دالة تحميل البيانات بالصفحات خاصة بجدول واحد(Pagination)
    public static void LoadPagedData(
            DataGridView dgv,
            string storedProcedureName,
            int pageNumber,
            int pageSize)
        {
            DataTable dt = new DataTable();
            using (Db db = new Db())
            {
                SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@PageNumber", pageNumber),
            new SqlParameter("@PageSize", pageSize)
            };

                 dt = db.ReadData(storedProcedureName, param);
            }
            dgv.DataSource = dt;
        }

        // دالة تحميل البيانات بالصفحات خاصة بكل الجداول (Pagination)

        public static void LoadPagedDataGeneral(
       DataGridView dgv,
       string tableName,
       string orderByColumn,
       int pageNumber,
       int pageSize)
        {
            DataTable dt = new DataTable();
            using (Db db = new Db())
            {
                SqlParameter[] param = {
            new SqlParameter("@TableName", tableName),
            new SqlParameter("@OrderByCol", orderByColumn),
            new SqlParameter("@PageNumber", pageNumber),
            new SqlParameter("@PageSize", pageSize),
            };
                dt = db.ReadData("GetPagedData", param);
           }
            
            dgv.DataSource = dt;
            }



        }
    }
