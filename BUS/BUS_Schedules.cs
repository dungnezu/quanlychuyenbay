using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Schedules
    {
        DAL_Schedules dal_Schedules = new DAL_Schedules();
        public DataTable getSchedules()
        {
           
            
            return dal_Schedules.getSchedulesList();
        }
        public DataTable getSchedules1(String from, String to,String outbound,int flightnumber)
        {


            return dal_Schedules.getSchedulesList1(from,to,outbound,flightnumber);
        }

        public DataTable getSchedules2(string from)
        {
            return dal_Schedules.getSchedulesList2(from);
        }

        public DataTable getSchedules3(string to)
        {
            return dal_Schedules.getSchedulesList3(to);
        }

        public DataTable getSchedules4(string outbound)
        {
            return dal_Schedules.getSchedulesList4(outbound);
        }

        public DataTable getSchedules5(int flightnumber)
        {
            return dal_Schedules.getSchedulesList5(flightnumber);
        }

        public DataTable getSchedules6(string from, string to)
        {
            return dal_Schedules.getSchedulesList6(from, to);
        }

        public DataTable getSchedules7(string from, string outbound)
        {
            return dal_Schedules.getSchedulesList7(from, outbound);
        }

        public DataTable getSchedules8(string from, int flightnumber)
        {
            return dal_Schedules.getSchedulesList8(from, flightnumber);
        }

        public DataTable getSchedules9(string to, string outbound)
        {
            return dal_Schedules.getSchedulesList9(to, outbound);
        }

        public DataTable getSchedules10(string to, int flightnumber)
        {
            return dal_Schedules.getSchedulesList10(to,  flightnumber);

        }

        public DataTable getSchedules11(string outbound, int flightnumber)
        {
            return dal_Schedules.getSchedulesList11(outbound, flightnumber);
        }

        public DataTable getSchedules12(string to, string outbound, int flightnumber)
        {
            return dal_Schedules.getSchedulesList12(to,outbound, flightnumber);
        }

        public DataTable getSchedules13(string from, string outbound, int flightnumber)
        {
            return dal_Schedules.getSchedulesList13(from,outbound, flightnumber);
        }

        public DataTable getSchedules14(string from, string to, int flightnumber)
        {
            return dal_Schedules.getSchedulesList14(from,to , flightnumber);

        }

        public DataTable getSchedules15(string from, string to, string outbound)
        {
            return dal_Schedules.getSchedulesList15(from, to, outbound);
        }
        public bool cancelFlight(int id)
        {
            return dal_Schedules.updateSchedulesComfirmed(id);
        }
        public bool updateFlight(int id, String date, String time, decimal ecoprice)
        {
            return dal_Schedules.updateDateTimePrice(id, date, time, ecoprice);
        }

        public bool confirmFlight(int id)
        {
            return dal_Schedules.confirmFlight(id);
        }

        public bool addSchedules(string date, string time, int airId, int rouId,decimal ecoprice, int confirmed,int fliNum)
        {
            return dal_Schedules.AddFlight(date, time, airId, rouId, ecoprice, confirmed, fliNum);
        }

        public bool getSchedulesTable(String date, int fliNum)
        {
            return dal_Schedules.getSchedulesListTable(date,fliNum);
        }

        public bool editSchedules(string date1, string time, int airId, int rouId, decimal ecoprice, int confirmed, int fliNum)
        {
            return dal_Schedules.editFlight(date1,time,airId,rouId,ecoprice,confirmed,fliNum);
        }
    }
}
