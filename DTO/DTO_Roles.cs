using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Roles
    {
        private int Roles_ID;
        private String Roles_Title;

        public DTO_Roles()
        {
        }

        public DTO_Roles(int roles_ID, string roles_Title)
        {
            Roles_ID1 = roles_ID;
            Roles_Title1 = roles_Title;
        }

        public int Roles_ID1 { get => Roles_ID; set => Roles_ID = value; }
        public string Roles_Title1 { get => Roles_Title; set => Roles_Title = value; }
    }
}
