using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CarDAO : DbContext
    {
        public static List<car> GetCars()
        {
            return db.cars.ToList();
        }

        public static List<car> GetCar(int carid)
        {
            try
            {
                List<car> list = db.cars.Where(x => x.car_id == carid).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void UpdateCar(car car1)
        {
            try

            {
                //get the car which is to be updated using the id
                car updcar = db.cars.First(x => x.car_id == car1.car_id);

                //set the new values
                updcar.car_make = car1.car_make;
                updcar.car_model = car1.car_model;
                updcar.car_price = car1.car_price;
                updcar.car_desc = car1.car_desc;
                updcar.car_year = car1.car_year;
                updcar.car_stock = car1.car_stock;

                //save changes
                db.SubmitChanges();

            }
            catch(Exception e)
            {
                throw e;
            }


        }

        public static List<car> Search(string text)
        {
            try
            {
                //query database to find matching model,make,desc
                List<car> list = db.cars.Where(x => x.car_make == text || x.car_model == text || x.car_desc == text).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void UpdateStock(int id, int quantity)
        {
            try
            {
                //using the car id get the relevant car details
                car updstock = db.cars.First(x => x.car_id == id);

                //reduce from the stock
                updstock.car_stock -= quantity;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public static void AddCar(car newcar)
        {
            try
            {
                //insert details to the database and save
                db.cars.InsertOnSubmit(newcar);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static void DeleteCar(int carID)
        {
            try
            {
                car delcar = db.cars.First(x => x.car_id == carID);
                db.cars.DeleteOnSubmit(delcar);
                db.SubmitChanges();              

            }
            catch (Exception e)
            {
                throw e;
            }


        }
    }
}
