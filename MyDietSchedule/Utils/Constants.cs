using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MyDietSchedule.Utils
{
    public class Constants
    {
        public static bool IsDev = true;

        private const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


        #region --- GUI Values Design ---
        // Sizes
        public static int LoginIconHeight = 150;
        #endregion

        #region --- Login ---
        public static string LoginUrl = "http://www.test.com/api/Auth/Login";
        public static string NoInternetText = "No Internet Connection, please reconnect.";
        public static string LoginError = "The User and the Password don't match.";
        public static string SettingsScreenTitle = "Settings";
        public static int MinPasswordLength = 6;

        public static Color GetColor(string color)
        {
            return (Color)Application.Current.Resources[color];
        }

        public static bool CheckEmail(string email = "")
        {
            email = email ?? string.Empty;
            return (Regex.IsMatch(email, Constants.emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500))) || string.IsNullOrWhiteSpace(email);
        }
        #endregion
    }
}
