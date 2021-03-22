using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Users
    {
        private int Users_ID;
        private int Users_RoleID;
        private String Users_Email;
        private String Users_Password;
        private String Users_FirstName;
        private String Users_LastName;
        private int Users_OfficeID;
        private String Users_Birthdate;
        private string Users_Active;

        public DTO_Users()
        {
        }

        public DTO_Users(int users_ID, int users_RoleID, string users_Email, string users_Password, string users_FirstName, string users_LastName, int users_OfficeID, string users_Birthdate, string users_Active)
        {
            Users_ID1 = users_ID;
            Users_RoleID1 = users_RoleID;
            Users_Email1 = users_Email;
            Users_Password1 = users_Password;
            Users_FirstName1 = users_FirstName;
            Users_LastName1 = users_LastName;
            Users_OfficeID1 = users_OfficeID;
            Users_Birthdate1 = users_Birthdate;
            Users_Active1 = users_Active;
        }

        public int Users_ID1 { get => Users_ID; set => Users_ID = value; }
        public int Users_RoleID1 { get => Users_RoleID; set => Users_RoleID = value; }
        public string Users_Email1 { get => Users_Email; set => Users_Email = value; }
        public string Users_Password1 { get => Users_Password; set => Users_Password = value; }
        public string Users_FirstName1 { get => Users_FirstName; set => Users_FirstName = value; }
        public string Users_LastName1 { get => Users_LastName; set => Users_LastName = value; }
        public int Users_OfficeID1 { get => Users_OfficeID; set => Users_OfficeID = value; }
        public string Users_Birthdate1 { get => Users_Birthdate; set => Users_Birthdate = value; }
        public string Users_Active1 { get => Users_Active; set => Users_Active = value; }
    }
}
