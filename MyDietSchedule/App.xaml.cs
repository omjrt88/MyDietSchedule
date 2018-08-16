using System;
using MyDietSchedule.Data.Controllers;
using MyDietSchedule.Models;
using MyDietSchedule.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyDietSchedule
{
    public partial class App : Application
    {
        static UserDataBaseController userDataBase;
        static MeasurementDataBaseController measurementData;
        static FoodTypeDataBaseController foodTypeData;
        static FoodDataBaseController foodData;
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

        public static FoodTypeDataBaseController FoodTypeDataBase
        {
            get
            {
                if (foodTypeData == null)
                {
                    foodTypeData = new FoodTypeDataBaseController();
                }
                return foodTypeData;
            }
        }

        public static FoodDataBaseController FoodDataBase
        {
            get
            {
                if (foodData == null)
                {
                    foodData = new FoodDataBaseController();
                }
                return foodData;
            }
        }
    }
}
