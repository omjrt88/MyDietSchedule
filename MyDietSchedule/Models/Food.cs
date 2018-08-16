using System;
using SQLite;

namespace MyDietSchedule.Models
{
    public class Food
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public int FoodTypeId { get; set; }

        public decimal PortionSize { get; set; }

        public string PortionMeasureType { get; set; }  // una taza, gramos, media mano, litros, onza, Unidad

        public Food()
        {
        }
    }
}
