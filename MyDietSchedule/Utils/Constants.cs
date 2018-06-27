using System;
using Xamarin.Forms;

namespace MyDietSchedule.Utils
{
    public class Constants
    {
        public static bool IsDev = true;

        #region --- GUI Values Design ---
        // Colors
        public static Color BackgroundColor = Color.FromHex("2f4259");
        public static Color SecondaryBackgroundColor = Color.White;
        public static Color BorderColor = Color.Cyan;
        public static Color MainTextColor = Color.FromHex("3ec3d5");
        public static Color TextboxTextColor = Color.Black;

        // Sizes
        public static int LoginIconHeight = 100;
        #endregion

        #region --- Login ---
        public static string LoginUrl = "http://www.test.com/api/Auth/Login";
        public static string NoInternetText = "No Internet Connection, please reconnect.";
        public static string SettingsScreenTitle = "Settings";
        #endregion
    }
}
