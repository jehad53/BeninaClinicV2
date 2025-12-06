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
    }
}
