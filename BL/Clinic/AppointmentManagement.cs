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
    public class AppointmentManagement
    {
        // Insert Appointment
        public void InsertAppointment(int Patient_Id ,int Doctor_Id ,string Appointment_Status ,string AppointmentType , DateTime AppointmentDate ,TimeSpan AppointmentTime ,String Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[7];
                pr[0] = new SqlParameter("@PatientId", SqlDbType.Int);
                pr[0].Value = Patient_Id;
                pr[1] = new SqlParameter("@DoctorId", SqlDbType.Int);
                pr[1].Value = Doctor_Id;
                pr[2] = new SqlParameter("@AppStatus", SqlDbType.NVarChar,150);
                pr[2].Value = Appointment_Status;
                pr[3] = new SqlParameter("@AppType", SqlDbType.NVarChar,150);
                pr[3].Value = AppointmentType;
                pr[4] = new SqlParameter("@AppDate", SqlDbType.Date);
                pr[4].Value = AppointmentDate;
                pr[5] = new SqlParameter("@AppTime", SqlDbType.Time,0);
                pr[5].Value = AppointmentTime;
                pr[6] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[6].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertAppointment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertAppointment  --> {ex.Message}");
            }
        }


        // Get All Appointment
        public DataTable GetAllAppointment()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllAppointments", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllAppointments -->  { ex.Message }");
            }
        }

        // Edit Appointment 
        public void EditAppointment(int App_Id, int Doctor_Id, string Appointment_Status, string AppointmentType, DateTime AppointmentDate, TimeSpan AppointmentTime, String Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[7];
                pr[0] = new SqlParameter("@App_Id", SqlDbType.Int);
                pr[0].Value = App_Id;
                pr[1] = new SqlParameter("@DoctorId", SqlDbType.Int);
                pr[1].Value = Doctor_Id;
                pr[2] = new SqlParameter("@AppStatus", SqlDbType.NVarChar, 150);
                pr[2].Value = Appointment_Status;
                pr[3] = new SqlParameter("@AppType", SqlDbType.NVarChar, 150);
                pr[3].Value = AppointmentType;
                pr[4] = new SqlParameter("@AppDate", SqlDbType.Date);
                pr[4].Value = AppointmentDate;
                pr[5] = new SqlParameter("@AppTime", SqlDbType.Time,0);
                pr[5].Value = AppointmentTime;
                pr[6] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[6].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditAppointment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditAppointment  --> {ex.Message}");
            }
        }

        // Delete Appointment
        public void DeleteAppointment(int App_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@App_Id", SqlDbType.Int);
                pr[0].Value = App_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteAppointment", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteAppointment  --> {ex.Message}");
            }
        }

        // Function for Search Appointment
        public DataTable SearchAppointment(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchAppointment", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchAppointment  --> {ex.Message}");
            }
        }
    }
}

