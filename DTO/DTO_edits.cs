using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_edits
    {
        private int id;
        private String date;
        private String time;
        private String from;
        private String to;
        private int flightnum;
        private String aircraftName;
        private decimal economy;
        private bool confirmed;

        public DTO_edits()
        {
        }

        public DTO_edits(int id, string date, string time, string from, string to, int flightnum, string aircraftName, decimal economy, bool confirmed)
        {
            this.Id = id;
            this.Date = date;
            this.Time = time;
            this.From = from;
            this.To = to;
            this.Flightnum = flightnum;
            this.AircraftName = aircraftName;
            this.Economy = economy;
            this.Confirmed = confirmed;
        }

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public int Flightnum { get => flightnum; set => flightnum = value; }
        public string AircraftName { get => aircraftName; set => aircraftName = value; }
        public decimal Economy { get => economy; set => economy = value; }
        public bool Confirmed { get => confirmed; set => confirmed = value; }
    }
}
