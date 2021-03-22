using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Aircrafts:DBConnect
    {
        public DataTable getAircraftsList()
        {
            try
            {
                conn.Open();
                String sqlString = "SELECT * FROM dbo.Aircrafts";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch
            {
                return null;

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
