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
   public class EmployeesManagement
    {

        AuditLogManagement _audit = new AuditLogManagement();

        // Get Employee By Id
        public DataTable GetEmployeeById(int id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Employee_Id", SqlDbType.Int) { Value = id };
                using (Db db = new Db())
                {
                    return db.ReadData("GetEmployeeById", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetEmployeeById --> {ex.Message}");
            }
        }


        // Insert Employee 
        public void InsertEmployee(string EmployeeName, string NationalNum, DateTime DateofBirth ,string Gender,string Phone,string Address, string ContractType, string SocialStatus , DateTime AppointmentDate, decimal Salary, int Job_Id , string Note, int userId)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[12];
                pr[0] = new SqlParameter("@EmployeeName", SqlDbType.NVarChar,100);
                pr[0].Value = EmployeeName;
                pr[1] = new SqlParameter("@NationalNum", SqlDbType.VarChar, 50);
                pr[1].Value = NationalNum;
                pr[2] = new SqlParameter("@DateofBirth", SqlDbType.DateTime);
                pr[2].Value = DateofBirth;

                pr[3] = new SqlParameter("@Gender", SqlDbType.NVarChar, 20);
                pr[3].Value = Gender;
                pr[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                pr[4].Value = Phone;
                pr[5] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                pr[5].Value = Address;
                pr[6] = new SqlParameter("@ContractType", SqlDbType.NVarChar, 50);
                pr[6].Value = ContractType;
                pr[7] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
                pr[7].Value = SocialStatus;
                pr[8] = new SqlParameter("@Salary", SqlDbType.Decimal);
                pr[8].Value = Salary;
                pr[9] = new SqlParameter("@AppointmentDate", SqlDbType.DateTime);
                pr[9].Value = AppointmentDate;
                pr[10] = new SqlParameter("@Job_Id", SqlDbType.Int);
                pr[10].Value = Job_Id;
                pr[11] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[11].Value = Note;

                using (Db db = new Db() )
                {
                    db.ExecuteCommand("InsertEmployee", pr);
                }

                _audit.AddLog("Insert", "Employees", NationalNum, userId, null, $"Name: {EmployeeName}", null);

            }
            catch(Exception ex)
            {
                throw new Exception($"Error in InsertEmployee  --> {ex.Message}");
            }
        }

        // Get All Employees
        public DataTable GetAllEmployees()
        {
            try
            {
                using (Db db = new Db())
                {

                    return db.ReadData("GetAllEmployees", null);
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllEmployees -->  { ex.Message }");
            }
        }



        //Get Job By Department
        public DataTable GetJobsByDep(int Dep_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Dep_Id", SqlDbType.Int);
                pr[0].Value = Dep_Id;
                using (Db db = new Db())
                {

                    return db.ReadData("GetJobsByDep", pr);
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDoctors -->  { ex.Message }");
            }
        }


        public void EditEmployee(string EmployeeName, string NationalNum, DateTime DateofBirth, string Gender, string Phone, string Address, string ContractType, string SocialStatus, DateTime AppointmentDate, decimal Salary, int Job_Id, string Note , int Employee_Id, int userId)
        {
            try 
            {
                SqlParameter[] pr = new SqlParameter[13];
                pr[0] = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 100);
                pr[0].Value = EmployeeName;
                pr[1] = new SqlParameter("@NationalNum", SqlDbType.VarChar, 50);
                pr[1].Value = NationalNum;
                pr[2] = new SqlParameter("@DateofBirth", SqlDbType.DateTime);
                pr[2].Value = DateofBirth;
                pr[3] = new SqlParameter("@Gender", SqlDbType.NVarChar, 20);
                pr[3].Value = Gender;
                pr[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                pr[4].Value = Phone;
                pr[5] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                pr[5].Value = Address;
                pr[6] = new SqlParameter("@ContractType", SqlDbType.NVarChar, 50);
                pr[6].Value = ContractType;
                pr[7] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
                pr[7].Value = SocialStatus;
                pr[8] = new SqlParameter("@Salary", SqlDbType.Decimal);
                pr[8].Value = Salary;
                pr[9] = new SqlParameter("@AppointmentDate", SqlDbType.DateTime);
                pr[9].Value = AppointmentDate;
                pr[10] = new SqlParameter("@Job_Id", SqlDbType.Int);
                pr[10].Value = Job_Id;
                pr[11] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[11].Value = Note;
                pr[12] = new SqlParameter("@Employee_Id", SqlDbType.Int);
                pr[12].Value = Employee_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditEmployee", pr);
                }

                string newValue = $"{EmployeeName} | {NationalNum} | {Phone} | {Job_Id} | {Salary}";
                _audit.AddLog("Update", "Employees", Employee_Id.ToString(), userId, "Check Backup", newValue, null );

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditEmployee  --> {ex.Message}");
            }
        }


        // Method for Delete Employee
        public void DeleteEmployee(int Employee_Id, int userId)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Employee_Id", SqlDbType.Int) { Value = Employee_Id } };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteEmployee", pr);
                }

                _audit.AddLog("Delete", "Employees", Employee_Id.ToString(), userId, "Deleted", "Deleted", null);



            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteEmployee  --> {ex.Message}");
            }
        }

        // Function for Search Employee
        public DataTable SearchEmployeeByNameOrNatNum(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar,50) { Value = Word } };
            using (Db db = new Db())
            {
              return  db.ReadData("SearchEmployeeByNameOrNatNum", pr);
            }

        }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchEmployeeByNameOrNatNum  --> {ex.Message}");
             }
           }


    }
}
