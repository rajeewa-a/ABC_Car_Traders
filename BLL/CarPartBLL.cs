using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class CarPartBLL
    {
        public static void AddPart(car_part newcarpart)
        {
            CarPartDAO.AddPart(newcarpart);
        }

        public static List<car_part> GetCarParts()
        {
            return CarPartDAO.GetCarParts();
        }

        public static void UpdateCarPart(car_part carpartdetail)
        {
            CarPartDAO.UpdatePart(carpartdetail);
        }

        public static void DeleteCarPart(int part_id)
        {
            CarPartDAO.DeletePart(part_id);
        }

        public static List<car_part> GetCarPart(int id)
        {
            return CarPartDAO.GetCarPart(id);
        }

        public static void UpdateStock(int id, int quantity)
        {
            CarPartDAO.UpdateStock(id, quantity);
        }

        public static List<car_part> Search(string text)
        {
            return CarPartDAO.Search(text);
        }
    }
}
