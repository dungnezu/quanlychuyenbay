using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Routes
    {
        DAL_Routes dal_routes = new DAL_Routes();
        public int getRoutesIATACode(int apIDfrom,int apIDto)
        {
            return dal_routes.getRoutesListIATACode(apIDfrom,apIDto);
        }
    }
}
