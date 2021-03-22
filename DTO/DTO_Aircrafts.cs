using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Aircrafts
    {
        private int Aircrafts_ID;
        private String Aircrafts_Name;
        private String Aircrafts_MakeModel;
        private int Aircrafts_TotalSeas;
        private int Aircrafts_EconomySeats;
        private int Aircrafts_BusinessSeats;

        public DTO_Aircrafts()
        {
        }

        public DTO_Aircrafts(int aircrafts_ID, string aircrafts_Name, string aircrafts_MakeModel, int aircrafts_TotalSeas, int aircrafts_EconomySeats, int aircrafts_BusinessSeats)
        {
            Aircrafts_ID = aircrafts_ID;
            Aircrafts_Name = aircrafts_Name;
            Aircrafts_MakeModel = aircrafts_MakeModel;
            Aircrafts_TotalSeas = aircrafts_TotalSeas;
            Aircrafts_EconomySeats = aircrafts_EconomySeats;
            Aircrafts_BusinessSeats = aircrafts_BusinessSeats;
        }

        public int Aircrafts_ID1 { get => Aircrafts_ID; set => Aircrafts_ID = value; }
        public string Aircrafts_Name1 { get => Aircrafts_Name; set => Aircrafts_Name = value; }
        public string Aircrafts_MakeModel1 { get => Aircrafts_MakeModel; set => Aircrafts_MakeModel = value; }
        public int Aircrafts_TotalSeas1 { get => Aircrafts_TotalSeas; set => Aircrafts_TotalSeas = value; }
        public int Aircrafts_EconomySeats1 { get => Aircrafts_EconomySeats; set => Aircrafts_EconomySeats = value; }
        public int Aircrafts_BusinessSeats1 { get => Aircrafts_BusinessSeats; set => Aircrafts_BusinessSeats = value; }
    }
}
