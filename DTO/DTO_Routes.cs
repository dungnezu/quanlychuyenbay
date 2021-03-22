using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Routes
    {
        private int Routes_ID;
        private int Routes_DepartureAirportID;
        private int Routes_ArrivalAirportID;
        private int Routes_Distance;
        private int Routes_FlightTime;

        public DTO_Routes()
        {
        }

        public DTO_Routes(int routes_ID, int routes_DepartureAirportID, int routes_ArrivalAirportID, int routes_Distance, int routes_FlightTime)
        {
            Routes_ID1 = routes_ID;
            Routes_DepartureAirportID1 = routes_DepartureAirportID;
            Routes_ArrivalAirportID1 = routes_ArrivalAirportID;
            Routes_Distance1 = routes_Distance;
            Routes_FlightTime1 = routes_FlightTime;
        }

        public int Routes_ID1 { get => Routes_ID; set => Routes_ID = value; }
        public int Routes_DepartureAirportID1 { get => Routes_DepartureAirportID; set => Routes_DepartureAirportID = value; }
        public int Routes_ArrivalAirportID1 { get => Routes_ArrivalAirportID; set => Routes_ArrivalAirportID = value; }
        public int Routes_Distance1 { get => Routes_Distance; set => Routes_Distance = value; }
        public int Routes_FlightTime1 { get => Routes_FlightTime; set => Routes_FlightTime = value; }
    }
}
