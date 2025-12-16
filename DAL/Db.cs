using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BeninaClinic.DAL
{
   public class Db :IDisposable
    {
        private readonly SqlConnection _con;

        public Db()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["con"]?.ToString();

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'con' not found in configuration.");
            }
            _con = new SqlConnection(connectionString);
        }

        // Method for Open Database Connection
        public void Open()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        // Method for Close Database Connection 
        public void Close()
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }

        // Function for Get&Read Data 
        public DataTable ReadData(string sp, SqlParameter[] param)
        {
            if (string.IsNullOrWhiteSpace(sp))
            {
                throw new ArgumentException("Stored procedure name cannot be null or empty.", nameof(sp));
            }
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            } //end Try

            catch (SqlException ex)
            {
                throw new Exception($"Database error occurred while reading data: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while reading data: {ex.Message}", ex);
            }
        }

        public DataTable ReadDataSQL(string sql, SqlParameter[] param)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentException("SQL query cannot be null or empty.", nameof(sql));
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error occurred while reading data: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while reading data: {ex.Message}", ex);
            }
        }

        // Method for Execute Some Command ex ->  Insert , Update , Delete 
        public void ExecuteCommand(string sp, SqlParameter[] param)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error occurred while executing command: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while executing command: {ex.Message}", ex);
            }
        }


        // Function for Get Max ID 
        public int MaxID(string sp, SqlParameter[] param)
        {
            int Number;
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    Number = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error occurred while executing command: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while getting MaxID: {ex.Message}", ex);
                //Number = 0;
            }
            finally
            {
                Close();
            }
            return Number;
        }

        // Method for Fill Combobox





        // Method for Fill Combobox
        // Method for Execute Command and Return Output Parameter Value (INT)
        public int ExecuteCommandReturnID(string sp, SqlParameter[] param, string outputParamName)
        {
            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    cmd.ExecuteNonQuery();
                    
                    if(cmd.Parameters[outputParamName].Value != DBNull.Value)
                    {
                        return Convert.ToInt32(cmd.Parameters[outputParamName].Value);
                    }
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error occurred while executing command: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while executing command: {ex.Message}", ex);
            }
            finally
            {
                Close();
            }
        }

        public void Dispose()
        {
            if (_con != null)
            {
                _con.Dispose();
            }
        }
    }
}
