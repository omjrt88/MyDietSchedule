using System;
using MyDietSchedule.Data.Controllers;
using MyDietSchedule.Models;
using MyDietSchedule.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyDietSchedule
{
    public partial class App : Application
    {
        static UserDataBaseController userDataBase;
        static MeasurementDataBaseController measurementData;
        public static User user;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static UserDataBaseController UserDataBase
        {
            get
            {
                if (userDataBase == null)
                {
                    userDataBase = new UserDataBaseController();
                }
                return userDataBase;
            }
        }

        public static MeasurementDataBaseController MeasurementDataBase
        {
            get
            {
                if (measurementData == null)
                {
                    measurementData = new MeasurementDataBaseController();
                }
                return measurementData;
            }
        }
    }
}
