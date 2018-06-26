using System;
using SQLite;

namespace MyDietSchedule.Models
{
	public class User
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Logged { get; set; }

        /***** Constructors *****/

        public User() {
            this.Logged = false;
        }

        public User(string Email, string Password) {
            this.Email = Email;
            this.Password = Password;
            this.Logged = false;
        }

        public User(string Email, string Password, string FirstName, string LastName, DateTime Birthday, string Address)
        {
            this.Email = Email;
            this.Password = Password;

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Logged = false;
        }

        /***** Methods *****/

        public bool LoginParameters()
        {
            if (!String.IsNullOrEmpty(this.Email) && !String.IsNullOrEmpty(this.Password))
            {
                return true;
            }
            return false;
        }
    }
}
