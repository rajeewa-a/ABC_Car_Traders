using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CustomerDAO : DbContext
    {
        public static void AddCustomer(customer newcustomer)
        {
            try
            {
                db.customers.InsertOnSubmit(newcustomer);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<customer> GetCustomer(string id)
        {
            try
            {
                List<customer> list = db.customers.Where(x => x.customer_id == id).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void DeleteCustomer(string customer_id)
        {
            try
            {
                user delcustomer = db.users.First(x => x.uid == customer_id);
                db.users.DeleteOnSubmit(delcustomer);
                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void UpdateCustomer(customer customer1)
        {
            try

            {
                customer updcustomer = db.customers.First(x => x.customer_id == customer1.customer_id);
                updcustomer.name = customer1.name;
                updcustomer.address = customer1.address;
                updcustomer.dob = customer1.dob;
                updcustomer.contact = customer1.contact;


                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<customer> GetCustomers()
        {
            return db.customers.ToList();
        }

        public static List<customer> Search(string text)
        {
            try
            {
                List<customer> list = db.customers.Where(x => x.customer_id == text || x.name == text).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
