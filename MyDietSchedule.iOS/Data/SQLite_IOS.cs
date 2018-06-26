using System;
using System.IO;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.iOS.Data;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace MyDietSchedule.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDietSchedule.db3";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
