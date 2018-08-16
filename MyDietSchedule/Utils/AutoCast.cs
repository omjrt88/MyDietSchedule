using System;
using System.Collections.Generic;
using MyDietSchedule.Data.Controllers;
using MyDietSchedule.Models;
using Newtonsoft.Json.Linq;

namespace MyDietSchedule.Utils
{
    public class AutoCast
    {
        public string jsonData { get; set; }
        public FoodTypeDataBaseController FoodTypeDataBase { get; set; }
        public FoodDataBaseController FoodDataBase { get; set; }

        public AutoCast(string jsonData, FoodTypeDataBaseController FoodTypeDataBase, FoodDataBaseController FoodDataBase)
        {
            this.jsonData = jsonData;
            this.FoodDataBase = FoodDataBase;
            this.FoodTypeDataBase = FoodTypeDataBase;
        }

        public bool Convert2Object()
        {
            JObject objects = JObject.Parse(jsonData);

            foreach (var item in objects)
            {
                Cast2Object(item.Key, objects[item.Key]);
            }

            return false;
        }

        private void Cast2Object(string type, JToken objects)
        {
            switch (type)
            {
                case "FoodType":
                    List<FoodType> foodTypes = objects.ToObject<List<FoodType>>();
                    foodTypes.ForEach((obj) => FoodTypeDataBase.Save(obj));
                    break;
                case "Food":
                    List<Food> food = objects.ToObject<List<Food>>();
                    food.ForEach((obj) => FoodDataBase.Save(obj));
                    break;
                default:
                    break;
            }
        }
    }
}
