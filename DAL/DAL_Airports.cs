using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class DAL_Airports:DBConnect
    {
        public DataTable getAirportsList()
        {
            try
            {
                conn.Open();
                String sqlString = "SELECT * FROM dbo.Airports";
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
        public int getAirportsListIATACode(String apID)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT ID FROM dbo.Airports where IATACode='{0}'", apID);
               
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return int.Parse(dataTable.Rows[0][0].ToString());

            }
            catch
            {
                return -1;

            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getAirportsList1(String apID)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT * FROM dbo.Airports where IATACode !='{0}'", apID);

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
