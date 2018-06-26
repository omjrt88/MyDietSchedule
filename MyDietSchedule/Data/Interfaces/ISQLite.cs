using System;
using SQLite;
namespace MyDietSchedule.Data.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
