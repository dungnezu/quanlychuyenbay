using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {

        protected SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-3MK5K7B\SQLEXPRESS;Initial Catalog=Session2;Integrated Security=True");
        


    }
}
