using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalesDAO : DbContext
    {
        public static void AddSale(sale newsale)
        {
            try
            {
                db.sales.InsertOnSubmit(newsale);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<sale> GetSales(DateTime from, DateTime to)
        {
            try
            {
                List<sale> list = db.sales.Where(x => x.created_at >= from && x.created_at <= to).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
