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
    public class VisitManagement
    {
        // Insert Visit
        public void InsertVisit(int Patient_Id, int Doctor_Id, DateTime VisitDate, string Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[4];
                pr[0] = new SqlParameter("@Patient_Id", SqlDbType.Int);
                pr[0].Value = Patient_Id;
                pr[1] = new SqlParameter("@Doctor_Id", SqlDbType.Int);
                pr[1].Value = Doctor_Id;
                pr[2] = new SqlParameter("@VisitDate", SqlDbType.Date);
                pr[2].Value = VisitDate;
                pr[3] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[3].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertVisit", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertVisit  --> {ex.Message}");
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


        // Insert Visit Diagnosis
        public void InsertVisitDiagnosis(int Visit_Id, int Diagnosis_Id, string DiagnosisName, string Description, string Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[5];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;
                pr[1] = new SqlParameter("@Diagnosis_Id", SqlDbType.Int);
                pr[1].Value = Diagnosis_Id;
                pr[2] = new SqlParameter("@DiagnosisName", SqlDbType.NVarChar, 150);
                pr[2].Value = DiagnosisName;
                pr[3] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[3].Value = Description;
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[4].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertVisitDiagnosis", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertVisitDiagnosis  --> {ex.Message}");
            }
        }

        // Insert Visit Tests
        public void InsertVisitTests(int Visit_Id, int Test_Id, string TestName, string Description, string Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[5];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;
                pr[1] = new SqlParameter("@Test_Id", SqlDbType.Int);
                pr[1].Value = Test_Id;
                pr[2] = new SqlParameter("@TestName", SqlDbType.NVarChar, 150);
                pr[2].Value = TestName;
                pr[3] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[3].Value = Description;
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[4].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertVisitTests", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertVisitTests  --> {ex.Message}");
            }
        }


        // Insert Visit Medicine
        public void InsertVisitMedications(int Visit_Id, int Medication_Id, string MedicineName, string ScienceName, string Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[5];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;
                pr[1] = new SqlParameter("@Medication_Id", SqlDbType.Int);
                pr[1].Value = Medication_Id;
                pr[2] = new SqlParameter("@MedicineName", SqlDbType.NVarChar, 150);
                pr[2].Value = MedicineName;
                pr[3] = new SqlParameter("@ScienceName", SqlDbType.NVarChar, 150);
                pr[3].Value = ScienceName;
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[4].Value = Note;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertVisitMedications", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertVisitMedications  --> {ex.Message}");
            }
        }

        // باقي الكود شور المواعيد لانني خذيت منه نسخه ولكن قد نحتاج هذه الأكواد



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
                pr[5] = new SqlParameter("@AppTime", SqlDbType.Time, 0);
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

        // Get Today Appointments
        public DataTable GetTodayAppointments()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetTodayAppointments", null);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetTodayAppointments  --> {ex.Message}");
            }
        }

        // Get All Patient Visit
        public DataTable GetAllPatientVisit(int Patient_Id , string NatNum)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@Patient_Id", SqlDbType.Int);
                pr[0].Value = Patient_Id;
                pr[1] = new SqlParameter("@NatNum", SqlDbType.NVarChar,50);
                pr[1].Value = NatNum;

                using (Db db = new Db())
                {
                    return db.ReadData("GetAllPatientVisit", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllPatientVisit  --> {ex.Message}");
            }

        }

        // Get Digonosis By VisitID
        public DataTable GetDigonosisByVisitID(int Visit_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;

                using (Db db = new Db())
                {
                    return db.ReadData("GetDiagnosisByVisitId", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetDiagnosisByVisitId  --> {ex.Message}");
            }
        }

        // Get Tests By VisitID
        public DataTable GetTestsByVisitId(int Visit_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;

                using (Db db = new Db())
                {
                    return db.ReadData("GetTestsByVisitId", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetTestsByVisitId  --> {ex.Message}");
            }
        }

        public DataTable GetMedicineByVisitId(int Visit_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[0].Value = Visit_Id;

                using (Db db = new Db())
                {
                    return db.ReadData("GetMedicineByVisitId", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetMedicineByVisitId  --> {ex.Message}");
            }
        }
    }
}
