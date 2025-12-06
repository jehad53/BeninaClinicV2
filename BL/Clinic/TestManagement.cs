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
    public class TestManagement
    {
        // Insert Test
        public void InsertTest(string TestName, string Description)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@TestName", SqlDbType.NVarChar, 150);
                pr[0].Value = TestName;
                pr[1] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[1].Value = Description;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertTest", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertTest  --> {ex.Message}");
            }
        }


        // Get All Test
        public DataTable GetAllTests()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllTests", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllTests -->  { ex.Message }");
            }
        }

        // Edit Test 
        public void EditTest(int Diagnose_Id, string DiagnosetName, string Description)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@Test_Id", SqlDbType.Int);
                pr[0].Value = Diagnose_Id;
                pr[1] = new SqlParameter("@TestName", SqlDbType.NVarChar, 150);
                pr[1].Value = DiagnosetName;
                pr[2] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[2].Value = Description;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditTest", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditTest  --> {ex.Message}");
            }
        }

        // Delete Test
        public void DeleteTest(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Test_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteTest", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteTest  --> {ex.Message}");
            }
        }

        // Function for Search Test
        public DataTable SearchTest(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchTest", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchTest  --> {ex.Message}");
            }
        }

    }
}
