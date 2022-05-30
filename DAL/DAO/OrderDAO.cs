using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class OrderDAO : DbContext
    {
        public static void AddOrder(order neworder)
        {
            try
            {
                //insert order and save
                db.orders.InsertOnSubmit(neworder);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<order> GetOrders()
        {
            return db.orders.Where(x => x.order_status != "COMPLETE").ToList();
        }

        public static void UpdateOrder(order order1)
        {
            try

            {
                order updorder = db.orders.First(x => x.order_id == order1.order_id);
                updorder.order_status = order1.order_status;
                updorder.payment_status = order1.payment_status;

                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<order> GetMyOrders(string cid)
        {
            return db.orders.Where(x => x.customer_id == cid).ToList();
        }

        public static List<order> Search(string text)
        {
            try
            {
                List<order> list = db.orders.Where(x => x.order_id.ToString() == text || x.customer_id == text || x.order_desc == text).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void DeleteOrder(int order_id)
        {
            try
            {
                order delorder = db.orders.First(x => x.order_id == order_id);
                db.orders.DeleteOnSubmit(delorder);
                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
