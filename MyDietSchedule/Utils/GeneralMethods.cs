using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using static System.Activator;

namespace MyDietSchedule.Utils
{
    public class GeneralMethods
    {
        public static Color GetColor(string color)
        {
            return (Color)Application.Current.Resources[color];
        }

        public static bool CheckEmail(string email = "")
        {
            email = email ?? string.Empty;
            return (Regex.IsMatch(email, Constants.emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500))) || string.IsNullOrWhiteSpace(email);
        }

        public static object GetInstance(string strNamesapace)
        {
            Type t = Type.GetType(strNamesapace);
            return CreateInstance(t);
        }

        public static bool HasEmptyFields<T>(T formModel, string validType, string exceptions = "")
        {
            Type type = formModel.GetType();
            PropertyInfo[] propertyInfo = type.GetProperties();
            string[] ruleExceptions = exceptions.Split(',');
            bool hasEmptyValues = false;
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                object value = type.GetProperty(pInfo.Name).GetValue(formModel);
                if (string.IsNullOrWhiteSpace(exceptions) || ruleExceptions.Any(x => !x.Equals(pInfo.Name)))
                {
                    if (pInfo.PropertyType.Name == validType)
                    {
                        hasEmptyValues |= value == null || checkTypeEmpty(value);
                    }   
                }
            }
            return hasEmptyValues;
        }

        private static bool checkTypeEmpty(object value)
        {
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Decimal:
                    return ((Decimal)value).Equals(0);
                case TypeCode.Int32:
                    return ((Decimal)value).Equals(0);
                case TypeCode.String:
                    return string.IsNullOrWhiteSpace((string)value);
                default:
                    return value == null;
            }
        }
    }
}
