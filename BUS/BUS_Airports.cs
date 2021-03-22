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
    public class BUS_Airports
    {
        DAL_Airports daL_Airports = new DAL_Airports();
        public DataTable getAirPorts()
        {
            return daL_Airports.getAirportsList();
        }
        public DataTable getAirPorts1(String apID)
        {
            return daL_Airports.getAirportsList1(apID);
        }
        public int getAirPortsIATACode(String apID)
        {
            return daL_Airports.getAirportsListIATACode(apID);
        }

    }
}
