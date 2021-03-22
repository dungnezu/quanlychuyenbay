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
   public class DAL_Schedules:DBConnect
    {
        
        public DataTable getSchedulesList()
        {

            try
            {

                conn.Open();
                String sqlString = "SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID";
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

        public DataTable getSchedulesList6(string from, string to)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and a.IATACode='{1}'", from, to);
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

        public DataTable getSchedulesList13(string from, string outbound, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and Date='{1}' and FlightNumber='{2}'", from,  outbound, flightnumber);
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

        public bool editFlight(string date1, string time, int airId, int rouId, decimal ecoprice, int confirmed, int fliNum)
        {
            try
            {
                conn.Open();
                String sqlString = string.Format("UPDATE [dbo].[Schedules] set Time='{0}',AircraftID={1}, RouteID={2},EconomyPrice={3},Confirmed={4} where Date='{5}' and FlightNumber={6}", time,airId,rouId,ecoprice,confirmed,date1,fliNum);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch 
            {

            }
           
            
                conn.Close();
            
            return false;
        }

        public bool getSchedulesListTable(String date, int FliNum)
        {

            try
            {
                conn.Open();
                String sqlString = string.Format("select Date,FlightNumber from Schedules");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, conn);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime date1 = DateTime.Parse(row[0].ToString());
                    String date2 = date1.ToString("yyyy-MM-dd");
                    String f1 = row[1].ToString();
                    if (date.Equals(date2)&&FliNum.ToString().Equals(f1))
                    {
                        conn.Close();
                        return true;
                    }
                }
            }
            catch
            {

            }
            
            conn.Close();
            return false;
            
        }     

        public bool AddFlight(string date, string time,int airId,int rouId, decimal ecoprice, int confirmed, int fliNum)
        {


            try
            {
                conn.Open();
                String sqlString = string.Format("INSERT [dbo].[Schedules] ([Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (CAST(N'{0}' AS Date), CAST(N'{1}' AS Time), {2}, {3}, {4}, {5}, N'{6}')", date, time, airId, rouId, ecoprice, confirmed, fliNum);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch
            {

            }
            conn.Close();
            return false;
        }

        public bool confirmFlight(int id)
        {
            try
            {
                conn.Open();
                String sqlString = string.Format("UPDATE Schedules SET Confirmed=1 where ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public DataTable getSchedulesList14(string from, string to, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and a.IATACode='{1}' and FlightNumber='{2}'", from, to, flightnumber);
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

        public DataTable getSchedulesList15(string from, string to, string outbound)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and a.IATACode='{1}' and Date='{2}' ", from, to, outbound);
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

        public DataTable getSchedulesList12(string to, string outbound, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where a.IATACode='{0}'and Date='{1}' and FlightNumber='{2}'", to, outbound, flightnumber);
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

        public DataTable getSchedulesList7(string from, string outbound)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and Date='{1}'", from, outbound);
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

        public DataTable getSchedulesList8(string from, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and FlightNumber='{1}'", from, flightnumber);
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

        public DataTable getSchedulesList9(string to, string outbound)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where a.IATACode='{0}' and Date='{1}' ", to, outbound);
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

        public DataTable getSchedulesList10(string to, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where a.IATACode='{0}' and FlightNumber='{1}'", to, flightnumber);
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

        public DataTable getSchedulesList11(string outbound, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where  Date='{0}' and FlightNumber='{1}'",  outbound, flightnumber);
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

        public DataTable getSchedulesList5(int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where FlightNumber='{0}'", flightnumber);
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

        public DataTable getSchedulesList4(string outbound)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where Date='{0}'", outbound);
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

        public DataTable getSchedulesList3(string to)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where a.IATACode='{0}'", to);
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

        public DataTable getSchedulesList2(string from)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}'", from);
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

        public DataTable getSchedulesList1(String from, String to, String outbound, int flightnumber)
        {
            try
            {
                conn.Open();
                String sqlString = String.Format("SELECT Date,time,ai.IATACode as FROMS,a.IATACode as TOS,FlightNumber,c.Name as Aircraft,EconomyPrice,(EconomyPrice*1.35) as BusinessPrice, (EconomyPrice*1.35*1.3) as FirstClassPrice ,s.ID,s.Confirmed from [dbo].Airports a join [dbo].Routes r on a.ID = r.ArrivalAirportID join[dbo].Airports ai on ai.ID = r.DepartureAirportID join[dbo].Schedules s on s.RouteID = r.ID join[dbo].Aircrafts c on c.ID = s.AircraftID where ai.IATACode='{0}' and a.IATACode='{1}' and Date='{2}' and FlightNumber='{3}'", from, to, outbound, flightnumber);
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
        public bool updateSchedulesComfirmed(int id)
        {
            try
            {
                conn.Open();
                String sqlString = string.Format("UPDATE Schedules SET Confirmed=0 where ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(sqlString,conn);
                if(cmd.ExecuteNonQuery() > 0){
                    return true;
                }
            }catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool updateDateTimePrice(int id,String date, String time,decimal ecoprice)
        {
            try
            {
                conn.Open();
                String sqlString=string.Format("UPDATE Schedules SET Date='{0}', Time='{1}', EconomyPrice='{2}' where ID='{3}'",date,time,ecoprice,id);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() >0)
                {
                    return true;
                }
              
            }catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
