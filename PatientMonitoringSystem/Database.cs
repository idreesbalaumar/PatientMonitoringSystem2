using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitoringSystem
{
    public class Database
    {
        private static Database instance;
        OleDbConnection conn;
        OleDbCommand cmd;
        static string connStringName = "PatientMonitoringSystem.Properties.Settings.pmsConnectionString";
        private Database()
        {
            conn = new OleDbConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings[connStringName].ConnectionString
            };

        }

        public static Database Instance { 
            get
            {
                if (instance != null) return instance;

                instance = new Database();
                return instance;
            }
        }

        public int GetPatientCount()
        {
            int totalPatientCount = 0;
            try
            {
                conn.Open();
                String query = "Select count(*) from patient";

                cmd = new OleDbCommand(query, conn);
                totalPatientCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }

            return totalPatientCount;
        }

        public int GetDoctorCount()
        {
            int totalDoctorCount = 0;
            try
            {
                conn.Open();
                String query = "Select count(*) from doctor";

                cmd = new OleDbCommand(query, conn);
                totalDoctorCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }

            return totalDoctorCount;
        }

        public int GetNurseCount()
        {
            int totalNurseCount = 0;
            try
            {
                conn.Open();
                String query = "Select count(*) from device";

                cmd = new OleDbCommand(query, conn);
                totalNurseCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return totalNurseCount;
        }

        public int GetDeviceCount()
        {
            int totalDeviceCount = 0;
            try
            {
                conn.Open();
                String query = "Select count(*) from nurse";

                cmd = new OleDbCommand(query, conn);
                totalDeviceCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return totalDeviceCount;
        }
    }
}
