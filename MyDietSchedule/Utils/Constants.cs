using System;
using Xamarin.Forms;

namespace MyDietSchedule.Utils
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.Black; //Color.FromRgb(80, 80, 00);
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 100;

        //----------Login------------------------

        public static string LoginUrl = "http://www.test.com/api/Auth/Login";

        public static string NoInternetText = "No Internet Connection, please reconnect.";

        public static string SettingsScreenTitle = "Settings";
    }
}
