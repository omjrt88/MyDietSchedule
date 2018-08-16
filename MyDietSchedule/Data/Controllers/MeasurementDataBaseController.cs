using SQLite;
using Xamarin.Forms;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyDietSchedule.Data.Controllers
{
    public class MeasurementDataBaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public MeasurementDataBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();

            if (database.Table<Measurement>() != null)
            {
                database.DropTable<Measurement>();
            }

            database.CreateTable<Measurement>();

        }

        public Measurement Get(int id)
        {
            lock (locker)
            {
                if (database.Table<Measurement>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Get<Measurement>(id);
                }
            }
        }

        public IEnumerable<Measurement> Get(User user)
        {
            lock (locker)
            {
                if (database.Table<Measurement>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return GetMeasurements(user.Id);
                }
            }
        }

        public Measurement GetLast(User user)
        {
            lock (locker)
            {
                if (database.Table<Measurement>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Measurement>().Where(m => m.UserId == user.Id).OrderBy(m => m.Date).First();
                }
            }
        }

        public int Save(Measurement measurement)
        {
            lock (locker)
            {
                if (measurement.Id != 0)
                {
                    database.Update(measurement);
                    return measurement.Id;
                }
                else
                {
                    measurement.AppointmentNumber = GetMeasurements(measurement.UserId).ToList().Count + 1;
                    return database.Insert(measurement);
                }
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return database.Delete<Measurement>(id);
            }
        }

        private IEnumerable<Measurement> GetMeasurements(int userId)
        {
            return database.Table<Measurement>().Where(m => m.UserId == userId);
        }
    }
}
