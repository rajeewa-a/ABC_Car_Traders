using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
namespace BLL
{
    public class OrderBLL
    {
        public static void AddOrder(order neworder)
        {
            OrderDAO.AddOrder(neworder);
        }

        public static List<order> GetOrders()
        {
            return OrderDAO.GetOrders();
        }

        public static void UpdateOrder(order order1)
        {
            OrderDAO.UpdateOrder(order1);
        }

        public static List<order> GetMyOrders(string cid)
        {
            return OrderDAO.GetMyOrders(cid);
        }

        public static List<order> Search(string text)
        {
            return OrderDAO.Search(text);
        }

        public static void DeleteOrder(int order_id)
        {
            OrderDAO.DeleteOrder(order_id);
        }
    }
}
