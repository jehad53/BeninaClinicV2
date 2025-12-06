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
    public class DepartmentsManagement
    {
        //Insert Department
        public void InsertDepartment(string DepartmentName , string DepartmentManger)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50);
                pr[0].Value = DepartmentName;
                pr[1] = new SqlParameter("@DepartmentManger", SqlDbType.NVarChar, 50);
                pr[1].Value = DepartmentManger;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertDepartment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDepartment  --> {ex.Message}");
            }

        }


        // Get All Departments
        public DataTable GetAllDepartments()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllDepartments", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDepartments -->  { ex.Message }");
            }
        }

        // Edit Department 
        public void EditDepartment(int Department_Id, string DepartmentName, string DepartmentManger)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@Department_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;
                pr[1] = new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50);
                pr[1].Value = DepartmentName;
                pr[2] = new SqlParameter("@DepartmentManger", SqlDbType.NVarChar, 50);
                pr[2].Value = DepartmentManger;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditDepartment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditDepartment  --> {ex.Message}");
            }

        }

        public void DeleteDepartment(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Department_Id",SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteDepartment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteDepartment  --> {ex.Message}");
            }
        }

        // Search Departments
        public DataTable SearchDepartment(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchDepartment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchDepartment -->  { ex.Message }");
            }
        }
    }
}
