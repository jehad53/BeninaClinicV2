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
    public class JobManagement
    {
            //Insert Job
            public void InsertJob(string JobName, int Department_Id)
            {
                try
                {
                    SqlParameter[] pr = new SqlParameter[2];
                    pr[0] = new SqlParameter("@JobName", SqlDbType.NVarChar, 100);
                    pr[0].Value = JobName;
                    pr[1] = new SqlParameter("@Department_Id", SqlDbType.Int);
                    pr[1].Value = Department_Id;

                    using (Db db = new Db())
                    {
                        db.ExecuteCommand("InsertJob", pr);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error in InsertJob  --> {ex.Message}");
                }

            }


            // Get All Departments
            public DataTable GetAllJobs()
            {
                try
                {
                    using (Db db = new Db())
                    {
                        return db.ReadData("GetAllJobs", null);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error in GetAllJobs -->  { ex.Message }");
                }
            }

            // Edit Department 
            public void EditJob(int Job_Id, string JobtName, int Department_Id)
            {
                try
                {
                    SqlParameter[] pr = new SqlParameter[3];
                    pr[0] = new SqlParameter("@Job_Id", SqlDbType.Int);
                    pr[0].Value = Job_Id;
                    pr[1] = new SqlParameter("@JobName", SqlDbType.NVarChar, 100);
                    pr[1].Value = JobtName;
                    pr[2] = new SqlParameter("@Dep_Id", SqlDbType.Int);
                    pr[2].Value = Department_Id;

                    using (Db db = new Db())
                    {
                        db.ExecuteCommand("EditJob", pr);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error in EditJob  --> {ex.Message}");
                }

            }

            public void DeleteJob(int Job_Id)
            {
                try
                {
                    SqlParameter[] pr = new SqlParameter[1];
                    pr[0] = new SqlParameter("@Job_Id", SqlDbType.Int);
                    pr[0].Value = Job_Id;

                    using (Db db = new Db())
                    {
                        db.ExecuteCommand("DeleteJob", pr);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error in DeleteJob  --> {ex.Message}");
                }
            }

        // Search Job
        public DataTable SearchJob(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchJob", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchJob -->  { ex.Message }");
            }
        }

    }
    }
