using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class SalesBLL
    {
        public static void AddSale(sale newsale)
        {
            SalesDAO.AddSale(newsale);
        }

        public static List<sale> GetSales(DateTime from, DateTime to)
        {
            return SalesDAO.GetSales(from, to);
        }
    }
}
