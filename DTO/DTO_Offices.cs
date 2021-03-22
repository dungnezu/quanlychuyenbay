using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Offices
    {
        private int Offices_ID;
        private String Offices_CountryID;
        private String Offices_Title;
        private String Offices_Phone;
        private String Offices_Contact;

        public DTO_Offices()
        {
        }

        public DTO_Offices(int offices_ID, string offices_CountryID, string offices_Title, string offices_Phone, string offices_Contact)
        {
            Offices_ID = offices_ID;
            Offices_CountryID = offices_CountryID;
            Offices_Title = offices_Title;
            Offices_Phone = offices_Phone;
            Offices_Contact = offices_Contact;
        }

        public int Offices_ID1 { get => Offices_ID; set => Offices_ID = value; }
        public string Offices_CountryID1 { get => Offices_CountryID; set => Offices_CountryID = value; }
        public string Offices_Title1 { get => Offices_Title; set => Offices_Title = value; }
        public string Offices_Phone1 { get => Offices_Phone; set => Offices_Phone = value; }
        public string Offices_Contact1 { get => Offices_Contact; set => Offices_Contact = value; }
    }
}
