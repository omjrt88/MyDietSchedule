using System;
using SQLite;

namespace MyDietSchedule.Models
{
    public class Measurement
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name
        {
            get
            {
                return $"Cita Numero {this.Id}";
            }
        }

        public int UserId { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal FatPercentage { get; set; }
        public decimal MusclePercentage { get; set; }
        public decimal WaterPercentage { get; set; }
        public decimal PhysicalActivity { get; set; }

        public DateTime Date { get; set; }
        public string Notes { get; set; }


        public Measurement(int UserId, decimal Weight, decimal Height, decimal FatPercentage, decimal MusclePercentage, decimal WaterPercentage, decimal PhysicalActivity, DateTime Date, string Notes)
        {
            this.UserId = UserId;
            this.Weight = Weight;
            this.Height = Height;
            this.FatPercentage = FatPercentage;
            this.MusclePercentage = MusclePercentage;
            this.WaterPercentage = WaterPercentage;
            this.PhysicalActivity = PhysicalActivity;
            this.Date =  Date;
            this.Notes = Notes;
        }
    }
}
