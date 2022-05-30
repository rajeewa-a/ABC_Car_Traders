using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class CarBLL
    {
        public static List<car> GetCars()
        {
            return CarDAO.GetCars();
        }

        public static void UpdateCar(car car1)
        {
            CarDAO.UpdateCar(car1);
        }

        public static void DeleteCar(int CarID)
        {
            CarDAO.DeleteCar(CarID);
        }

        public static void AddCar(car newcar)
        {
            CarDAO.AddCar(newcar);
        }

        public static List<car> GetCar(int carid)
        {
            return CarDAO.GetCar(carid);
        }

        public static void UpdateStock(int id, int quantity)
        {
            CarDAO.UpdateStock(id,quantity);
        }

        public static List<car> Search(string text)
        {
            return CarDAO.Search(text);
        }
    }
}
