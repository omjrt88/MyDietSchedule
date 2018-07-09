﻿using System;
using System.Reflection;
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

        /***** Methods *****/
        #region Methods

        public bool HasEmptyLoginParameters()
        {
            if (!String.IsNullOrWhiteSpace(this.Email) && !String.IsNullOrWhiteSpace(this.Password))
            {
                return true;
            }
            return false;
        }

        #endregion

        /*Validations*/
        #region
        public bool HasEmptyFields()
        {
            Type type = GetType();
            PropertyInfo[] propertyInfo = type.GetProperties();
            bool hasEmptyValues = false;
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                object value = type.GetProperty(pInfo.Name).GetValue(this);
                if (pInfo.GetType().Name == "String")
                {
                    hasEmptyValues |= string.IsNullOrWhiteSpace((string)value);
                }
            }
            return hasEmptyValues;
        }


        #endregion

    }
}
