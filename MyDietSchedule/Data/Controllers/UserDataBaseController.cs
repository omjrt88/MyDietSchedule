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
            //database.CreateTable<User>();es            
            if (database.Table<User>() != null)
            {
                database.DropTable<User>();
            }

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

        public User Get(int id)
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Get<User>(id);
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

        public User LogIn(User user)
        {
            lock (locker)
            {
                User userFound = database.Table<User>().Where(u => u.Email == user.Email && u.Password == user.Password).First();
                userFound.Logged = userFound.Id != 0;
                database.Update(userFound);
                return userFound;
            }
        }

        public User LogOut(User user)
        {
            lock (locker)
            {
                User userFound = database.Table<User>().Where(u => u.Email == user.Email && u.Password == user.Password).First();
                userFound.Logged = false;
                database.Update(userFound);
                return userFound;
            }
        }
    }
}
