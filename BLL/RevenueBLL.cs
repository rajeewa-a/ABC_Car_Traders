using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class RevenueBLL
    {
        public static List<revenue> GetRevenue()
        {
            return RevenueDAO.GetRevenue();
        }
    }
}
