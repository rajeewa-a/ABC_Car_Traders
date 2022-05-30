using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;


namespace BLL
{
    public class CustomerBLL
    {
        public static void AddCustomer(customer newcustomer)
        {
            CustomerDAO.AddCustomer(newcustomer);
        }

        public static List<customer> GetCustomer(string id)
        {
            return CustomerDAO.GetCustomer(id);
        }

        public static List<customer> GetCustomers()
        {
            return CustomerDAO.GetCustomers();
        }

        public static void UpdateCustomer(customer customer1)
        {
            CustomerDAO.UpdateCustomer(customer1);
        }

        public static void DeleteCustomer(string customer_id)
        {
            CustomerDAO.DeleteCustomer(customer_id);
        }

        public static List<customer> Search(string text)
        {
            return CustomerDAO.Search(text);
        }
    }
}
