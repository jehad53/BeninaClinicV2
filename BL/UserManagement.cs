using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;

namespace BeninaClinic.BL
{
   public class UserManagement
    {
        // Insert Chronic
        public void InsertUser( string FullName, string UserName, string Password, string UserType,
            bool IsActive,
            bool SClinic,
            bool SDcotors,
            bool SPatients,
            bool SAppointments,
            bool SVisists,
            bool SDiagnosis,
            bool STests,
            bool SChronics,
            bool SMedicineReports,
            bool SDoses,
            bool SDepartments,
            bool SJobs,
            bool SEmployees,
            bool SUsers,
            bool SSettings,
            bool SMedciens,
            bool SRecordPatient)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[22];
                pr[0] = new SqlParameter("@FullName", SqlDbType.NVarChar, 150);
                pr[0].Value = FullName;
                pr[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 150);
                pr[1].Value = UserName;
                pr[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                pr[2].Value = Password;
                pr[3] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
                pr[3].Value = UserType;
                pr[4] = new SqlParameter("@IsActive", SqlDbType.Bit);
                pr[4].Value = IsActive;
                pr[5] = new SqlParameter("@SClinic", SqlDbType.Bit);
                pr[5].Value = SClinic;
                pr[6] = new SqlParameter("@SDcotors", SqlDbType.Bit);
                pr[6].Value = SDcotors;
                pr[7] = new SqlParameter("@SPatients", SqlDbType.Bit);
                pr[7].Value = SPatients;
                pr[8] = new SqlParameter("@SAppointments", SqlDbType.Bit);
                pr[8].Value = SAppointments;
                pr[9] = new SqlParameter("@SVisists", SqlDbType.Bit);
                pr[9].Value = SVisists;
                pr[10] = new SqlParameter("@SDiagnosis", SqlDbType.Bit);
                pr[10].Value = SDiagnosis;
                pr[11] = new SqlParameter("@STests", SqlDbType.Bit);
                pr[11].Value = STests;
                pr[12] = new SqlParameter("@SChronics", SqlDbType.Bit);
                pr[12].Value = SChronics;
                pr[13] = new SqlParameter("@SMedicineReports", SqlDbType.Bit);
                pr[13].Value = SMedicineReports;
                pr[14] = new SqlParameter("@SDoses", SqlDbType.Bit);
                pr[14].Value = SDoses;
                pr[15] = new SqlParameter("@SDepartments", SqlDbType.Bit);
                pr[15].Value = SDepartments;
                pr[16] = new SqlParameter("@SJobs", SqlDbType.Bit);
                pr[16].Value = SJobs;
                pr[17] = new SqlParameter("@SEmployees", SqlDbType.Bit);
                pr[17].Value = SEmployees;
                pr[18] = new SqlParameter("@SUsers", SqlDbType.Bit);
                pr[18].Value = SUsers;
                pr[19] = new SqlParameter("@SSettings", SqlDbType.Bit);
                pr[19].Value = SSettings;
                pr[20] = new SqlParameter("@SMedciens", SqlDbType.Bit);
                pr[20].Value = SMedciens;
                pr[21] = new SqlParameter("@SRecordPatient", SqlDbType.Bit);
                pr[21].Value = SRecordPatient;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertUser", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertUser  --> {ex.Message}");
            }
        }


        // Get All Users
        public DataTable GetAllUsers()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllUsers", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllUsers -->  { ex.Message }");
            }
        }

        // Edit Chronic 
        public void EditUser(int UserID , string FullName, string UserName, string Password, string UserType,
            bool IsActive,  
            bool SClinic,
            bool SDcotors,
            bool SPatients,
            bool SAppointments,
            bool SVisists,
            bool SDiagnosis,
            bool STests,
            bool SChronics,
            bool SMedicineReports,
            bool SDoses,
            bool SDepartments,
            bool SJobs,
            bool SEmployees,
            bool SUsers,
            bool SSettings,
            bool SMedciens,
            bool SRecordPatient )
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[23];
                pr[0] = new SqlParameter("@UserID", SqlDbType.Int);
                pr[0].Value = UserID;
                pr[1] = new SqlParameter("@FullName", SqlDbType.NVarChar, 150);
                pr[1].Value = FullName;
                pr[2] = new SqlParameter("@UserName", SqlDbType.NVarChar , 150);
                pr[2].Value = UserName;
                pr[3] = new SqlParameter("@Password", SqlDbType.NVarChar ,50);
                pr[3].Value = Password;
                pr[4] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
                pr[4].Value = UserType;

                pr[5] = new SqlParameter("@IsActive", SqlDbType.Bit);
                pr[5].Value = IsActive;
                pr[6] = new SqlParameter("@SClinic", SqlDbType.Bit);
                pr[6].Value = SClinic;
                pr[7] = new SqlParameter("@SDcotors", SqlDbType.Bit);
                pr[7].Value = SDcotors;
                pr[8] = new SqlParameter("@SPatients", SqlDbType.Bit);
                pr[8].Value = SPatients;
                pr[9] = new SqlParameter("@SAppointments", SqlDbType.Bit);
                pr[9].Value = SAppointments;
                pr[10] = new SqlParameter("@SVisists", SqlDbType.Bit);
                pr[10].Value = SVisists;
                pr[11] = new SqlParameter("@SDiagnosis", SqlDbType.Bit);
                pr[11].Value = SDiagnosis;
                pr[12] = new SqlParameter("@STests", SqlDbType.Bit);
                pr[12].Value = STests;
                pr[13] = new SqlParameter("@SChronics", SqlDbType.Bit);
                pr[13].Value = SChronics;
                pr[14] = new SqlParameter("@SMedicineReports", SqlDbType.Bit);
                pr[14].Value = SMedicineReports;
                pr[15] = new SqlParameter("@SDoses", SqlDbType.Bit);
                pr[15].Value = SDoses;
                pr[16] = new SqlParameter("@SDepartments", SqlDbType.Bit);
                pr[16].Value = SDepartments;
                pr[17] = new SqlParameter("@SJobs", SqlDbType.Bit);
                pr[17].Value = SJobs;
                pr[18] = new SqlParameter("@SEmployees", SqlDbType.Bit);
                pr[18].Value = SEmployees;
                pr[19] = new SqlParameter("@SUsers", SqlDbType.Bit);
                pr[19].Value = SUsers;
                pr[20] = new SqlParameter("@SSettings", SqlDbType.Bit);
                pr[20].Value = SSettings;
                pr[21] = new SqlParameter("@SMedciens", SqlDbType.Bit);
                pr[21].Value = SMedciens;
                pr[22] = new SqlParameter("@SRecordPatient", SqlDbType.Bit);
                pr[22].Value = SRecordPatient;
                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditUser", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditUser  --> {ex.Message}");
            }
        }

        // Delete User
        public void DeleteUser(int User_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@UserID", SqlDbType.Int);
                pr[0].Value = User_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteUser", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteUser  --> {ex.Message}");
            }
        }
        // مااااااااااااازاااااااااااااااااال
        // Function for Search User
        public DataTable SearchUser(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchUser", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchUser  --> {ex.Message}");
            }
        }


        public DataTable LoginUser(string UserName , string Password)
        {
            try
            {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 150);
            pr[0].Value = UserName;
            pr[1] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 50);
            pr[1].Value = Password;
            using (Db db = new Db())
            {
               return db.ReadData("LoginUser", pr);
            }
           }
            catch (Exception ex)
            {
                throw new Exception($"Error in LoginUser  --> {ex.Message}");
    }
}
    }
}
