using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class UserBLL
    {
        public static List<user> GetUsers (string em, string pw)
        {
            return UserDAO.GetUsers(em, pw);
        }

        public static void AddUser(user newuser)
        {
            UserDAO.AddUser(newuser);
        }
    }
}
