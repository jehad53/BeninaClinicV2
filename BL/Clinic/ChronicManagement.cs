using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;

namespace BeninaClinic.BL.Clinic
{
   public class ChronicManagement
    {
        // Insert Chronic
        public void InsertChronic(string ChronicName, string Description)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@ChronicName", SqlDbType.NVarChar, 150);
                pr[0].Value = ChronicName;
                pr[1] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[1].Value = Description;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertChronic", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertChronic  --> {ex.Message}");
            }
        }


        // Get All Chronic
        public DataTable GetAllChronics()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllChronics", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllChronics -->  { ex.Message }");
            }
        }

        // Edit Chronic 
        public void EditChronic(int Diagnose_Id, string DiagnosetName, string Description)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@Chronic_Id", SqlDbType.Int);
                pr[0].Value = Diagnose_Id;
                pr[1] = new SqlParameter("@ChronicName", SqlDbType.NVarChar, 150);
                pr[1].Value = DiagnosetName;
                pr[2] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[2].Value = Description;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditChronic", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditChronic  --> {ex.Message}");
            }
        }

        // Delete Chronic
        public void DeleteChronic(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Chronic_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteChronic", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteChronic  --> {ex.Message}");
            }
        }

        // Function for Search Chronic
        public DataTable SearchChronic(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchChronic", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchChronic  --> {ex.Message}");
            }
        }
    }
}
