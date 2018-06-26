using SQLite;
using Xamarin.Forms;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Models;

namespace MyDietSchedule.Data.Controllers
{
    public class UserDataBaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public UserDataBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public User Get()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
        }

        public int Save(User user)
        {
            lock (locker)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
    }
}
