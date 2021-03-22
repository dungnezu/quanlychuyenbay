using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Airports
    {
        private int Airports_ID;
        private int Airports_CountryID;
        private String Airports_IAIACode;
        private String Airports_Name;

        public DTO_Airports()
        {
        }

        public DTO_Airports(int airports_ID, int airports_CountryID, string airports_IAIACode, string airports_Name)
        {
            Airports_ID = airports_ID;
            Airports_CountryID = airports_CountryID;
            Airports_IAIACode = airports_IAIACode;
            Airports_Name = airports_Name;
        }

        public int Airports_ID1 { get => Airports_ID; set => Airports_ID = value; }
        public int Airports_CountryID1 { get => Airports_CountryID; set => Airports_CountryID = value; }
        public string Airports_IAIACode1 { get => Airports_IAIACode; set => Airports_IAIACode = value; }
        public string Airports_Name1 { get => Airports_Name; set => Airports_Name = value; }
    }
}
