using SQLite;
using Xamarin.Forms;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyDietSchedule.Data.Controllers
{
    public class FoodTypeDataBaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public FoodTypeDataBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();

            if (database.Table<FoodType>() != null)
            {
                database.DropTable<FoodType>();
            }

            database.CreateTable<FoodType>();
        }

        public IEnumerable<FoodType> Get()
        {
            lock (locker)
            {
                if (database.Table<FoodType>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<FoodType>();
                }
            }
        }

        public FoodType Get(int id)
        {
            lock (locker)
            {
                if (database.Table<FoodType>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Get<FoodType>(id);
                }
            }
        }

        public int Save(FoodType foodType)
        {
            lock (locker)
            {
                return database.Insert(foodType);
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return database.Delete<FoodType>(id);
            }
        }
    }
}
