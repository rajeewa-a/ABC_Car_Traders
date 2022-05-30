using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CarPartDAO : DbContext
    {
        public static void AddPart(car_part newcarpart)
        {
            try
            {
                db.car_parts.InsertOnSubmit(newcarpart);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<car_part> GetCarParts()
        {
            return db.car_parts.ToList();
        }

        public static List<car_part> GetCarPart(int part_id)
        {
            try
            {
                List<car_part> list = db.car_parts.Where(x => x.part_id == part_id).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void UpdateStock(int id, int quantity)
        {
            try
            {
                car_part updstock = db.car_parts.First(x => x.part_id == id);
                updstock.part_stock -= quantity;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<car_part> Search(string text)
        {
            try
            {
                List<car_part> list = db.car_parts.Where(x => x.part_name == text || x.part_desc == text).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void UpdatePart(car_part carpartdetail)
        {
            try

            {
                car_part updpart = db.car_parts.First(x => x.part_id == carpartdetail.part_id);
                updpart.part_name = carpartdetail.part_name;
                updpart.part_price = carpartdetail.part_price;
                updpart.part_desc = carpartdetail.part_desc;
                updpart.part_stock = carpartdetail.part_stock;

                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeletePart(int part_id)
        {
            try
            {
                car_part delpart = db.car_parts.First(x => x.part_id == part_id);
                db.car_parts.DeleteOnSubmit(delpart);
                db.SubmitChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
