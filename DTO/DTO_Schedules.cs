using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Schedules
    {
        private int Schedules_ID;
        private String Schedules_Date;
        private String Schedules_Time;
        private int Schedules_AircraftID;
        private int Schedules_RouteID;
        private int Schedules_EconomyPrice;
        private int Schedules_Confirmed;
        private int Schedules_FlightNumber;

        public DTO_Schedules()
        {
        }

        public DTO_Schedules(int schedules_ID, string schedules_Date, string schedules_Time, int schedules_AircraftID, int schedules_RouteID, int schedules_EconomyPrice, int schedules_Confirmed, int schedules_FlightNumber)
        {
            Schedules_ID1 = schedules_ID;
            Schedules_Date1 = schedules_Date;
            Schedules_Time1 = schedules_Time;
            Schedules_AircraftID1 = schedules_AircraftID;
            Schedules_RouteID1 = schedules_RouteID;
            Schedules_EconomyPrice1 = schedules_EconomyPrice;
            Schedules_Confirmed1 = schedules_Confirmed;
            Schedules_FlightNumber1 = schedules_FlightNumber;
        }

        public int Schedules_ID1 { get => Schedules_ID; set => Schedules_ID = value; }
        public string Schedules_Date1 { get => Schedules_Date; set => Schedules_Date = value; }
        public string Schedules_Time1 { get => Schedules_Time; set => Schedules_Time = value; }
        public int Schedules_AircraftID1 { get => Schedules_AircraftID; set => Schedules_AircraftID = value; }
        public int Schedules_RouteID1 { get => Schedules_RouteID; set => Schedules_RouteID = value; }
        public int Schedules_EconomyPrice1 { get => Schedules_EconomyPrice; set => Schedules_EconomyPrice = value; }
        public int Schedules_Confirmed1 { get => Schedules_Confirmed; set => Schedules_Confirmed = value; }
        public int Schedules_FlightNumber1 { get => Schedules_FlightNumber; set => Schedules_FlightNumber = value; }
    }
}
