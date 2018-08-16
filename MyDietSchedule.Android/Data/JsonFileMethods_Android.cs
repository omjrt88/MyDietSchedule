using System;
using System.IO;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(JsonFileMethods_Android))]
namespace MyDietSchedule.Droid.Data
{
    public class JsonFileMethods_Android :JsonFileMethods
    {
        public JsonFileMethods_Android()
        {
        }

        public string ReadFile()
        {
            var file = "FoodMyDietschedule.json";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, file);
            var text = File.ReadAllText(path);

            return text;
        }
    }
}
