using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Countries
    {
        private int Countries_ID;
        private String Countries_name;

        public DTO_Countries()
        {
        }

        public DTO_Countries(int countries_ID, string countries_name)
        {
            Countries_ID = countries_ID;
            Countries_name = countries_name;
        }

        public int Countries_ID1 { get => Countries_ID; set => Countries_ID = value; }
        public string Countries_name1 { get => Countries_name; set => Countries_name = value; }
    }
}
