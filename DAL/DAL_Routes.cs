using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class DAL_Routes:DBConnect
    {
        public DataTable getRoutesList()
        {
            try
            {
                conn.Open();
                String sqlString = "SELECT * FROM dbo.Routes";
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
        public int getRoutesListIATACode(int apIDfrom, int apIDto)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT ID FROM dbo.Routes where DepartureAirportID={0} and ArrivalAirportID={1} ", apIDfrom,apIDto);
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return int.Parse(dataTable.Rows[0][0].ToString());

            }
            catch
            {
                return 0;

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
