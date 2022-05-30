using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO : DbContext
    {
        public static List<user> GetUsers(string em, string pw)
        {
            try
            {
                List<user> list = db.users.Where(x => x.email == em && x.password == pw).ToList();
                return list;
            } 
            catch (Exception e)
            {
                throw;
            }
        }

        public static void AddUser(user newuser)
        {
            try
            {
                db.users.InsertOnSubmit(newuser);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
    }
}
