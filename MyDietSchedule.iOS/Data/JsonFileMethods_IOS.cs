using System;
using System.IO;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(JsonFileMethods_IOS))]
namespace MyDietSchedule.iOS.Data
{
    public class JsonFileMethods_IOS : JsonFileMethods
    {
        public JsonFileMethods_IOS()
        {
        }

        public string ReadFile()
        {
            var file = "FoodMyDietschedule.json";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, file);

            var text = File.ReadAllText(path);

            return text;
        }
    }
}
