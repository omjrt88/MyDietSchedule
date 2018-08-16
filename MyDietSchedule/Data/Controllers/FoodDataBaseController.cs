using SQLite;
using Xamarin.Forms;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyDietSchedule.Data.Controllers
{
    public class FoodDataBaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public FoodDataBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();

            if (database.Table<Food>() != null)
            {
                database.DropTable<Food>();
            }

            database.CreateTable<Food>();
        }

        public IEnumerable<Food> Get(FoodType foodType)
        {
            lock (locker)
            {
                if (database.Table<Food>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Food>().Where(f => f.FoodTypeId == foodType.Id).OrderBy(f => f.Name);
                }
            }
        }

        public IEnumerable<Food> Get()
        {
            lock (locker)
            {
                if (database.Table<Food>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Food>();
                }
            }
        }

        public Food Get(int id)
        {
            lock (locker)
            {
                if (database.Table<Food>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Get<Food>(id);
                }
            }
        }


        public int Save(Food food)
        {
            lock (locker)
            {
                return database.Insert(food);
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return database.Delete<Food>(id);
            }
        }
    }
}
