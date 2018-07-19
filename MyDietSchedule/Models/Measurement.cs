using System;
using System.Collections.Generic;
using MyDietSchedule.Utils;
using SQLite;

namespace MyDietSchedule.Models
{
    public class Measurement
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int AppointmentNumber { get; set; }
        public int UserId { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal FatPercentage { get; set; }
        public decimal MusclePercentage { get; set; }
        public decimal WaterPercentage { get; set; }
        public decimal ViceralFatPercentage { get; set; }
        public decimal PhysicalActivity { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        /***** Constructors *****/
        #region Constructors
        public Measurement(int UserId, decimal Height, decimal Weight, decimal FatPercentage, decimal MusclePercentage, decimal WaterPercentage, decimal ViceralFatPercentage, decimal PhysicalActivity, DateTime Date, string Notes)
        {
            this.UserId = UserId;
            this.Height = Height;
            this.Weight = Weight;
            this.FatPercentage = FatPercentage;
            this.MusclePercentage = MusclePercentage;
            this.WaterPercentage = WaterPercentage;
            this.ViceralFatPercentage = ViceralFatPercentage;
            this.PhysicalActivity = PhysicalActivity;
            this.Date = Date;
            this.Notes = Notes;
        }

        public Measurement(int UserId)
        {
            this.UserId = UserId;
            this.Date = DateTime.Now;
        }

        public Measurement()
        {
            this.Date = DateTime.Now;
        }
        #endregion

        /*Validations*/
        #region Validations
        public string[] ValidateEmptyFields()
        {
            List<string> list = new List<string>();

            if (Date > DateTime.Now)
            {
                list.Add("Date has to be lower than current date.");
            }
            if (GeneralMethods.HasEmptyFields(this, "Decimal", "PhysicalActivity"))
            {
                list.Add("There not has to be an Empty fields.");
            }

            return list.ToArray();
        }
        #endregion
    }
}