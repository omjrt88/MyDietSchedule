using System;
using System.Collections.Generic;
using System.Linq;
using MyDietSchedule.Utils;
using SQLite;

namespace MyDietSchedule.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool Logged { get; set; }
        public DateTime NextDate { get; set; }

        /***** Constructors *****/
        #region Constructors

        public User()
        {
            this.Logged = false;
            this.Birthday = DateTime.Now.AddYears(-20);
        }

        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
            this.Logged = false;
        }

        public User(string Email, string Password, string FirstName, string LastName, string Phone, DateTime Birthday, string Address)
        {
            this.Email = Email;
            this.Password = Password;
            this.Phone = Phone;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Logged = false;
        }
        #endregion

        /*Validations*/
        #region
        public string[] ValidateEmptyFields()
        {
            List<string> list = new List<string>();

            if (GeneralMethods.HasEmptyFields(this, "String"))
            {
                list.Add("There not has to be an Empty fields.");
            }
            if (Birthday >= DateTime.Now)
            {
                list.Add("Birthday has to be lower than current date.");
            }
            if (!string.IsNullOrWhiteSpace(Phone) && !Phone.All(c => char.IsDigit(c)))
            {
                list.Add("Phone Number has non numeric values.");
            }

            return list.ToArray();
        }

        public string[] ValidateLogin()
        {
            List<string> list = new List<string>();

            if (HasEmptyLoginParameters())
            {
                list.Add("Username or password is empty.");
            }

            return list.ToArray();
        }
        #endregion

        /***** Methods *****/
        #region Methods

        private bool HasEmptyLoginParameters()
        {
            if (string.IsNullOrWhiteSpace(this.Email) || string.IsNullOrWhiteSpace(this.Password))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
