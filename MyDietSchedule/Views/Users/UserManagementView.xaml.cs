using System;
using System.Collections.Generic;
using System.Linq;
using MyDietSchedule.Utils;
using Xamarin.Forms;

namespace MyDietSchedule.Views.Users
{
    public partial class UserManagementView : TabbedPage
    {
        public UserManagementView()
        {
            InitializeComponent();
            DesignInit();
            MessagingCenter.Subscribe<object>(this, "MeasuresPageCall", (sender) => Navigate("User Measures", "NewMeasures"));
        }

        private void DesignInit()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = GeneralMethods.GetColor("PrimaryColor");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = GeneralMethods.GetColor("SecondayColor");

            BarBackgroundColor = GeneralMethods.GetColor("ThirdColor");
            BarTextColor = GeneralMethods.GetColor("SecondayColor");

            //NewMeasures.IsEnabled = false;
        }

        private NavigationPage SetDefaultValues(string title, ContentPage contentPage)
        {
            NavigationPage page = new NavigationPage(contentPage);
            page.Title = title;
            page.Icon = "ruler.png";

            return page;
        }

        private void Navigate(string title, string type) 
        {
            int pages = this.Children.Where(x => x.Title == title).Count();
            if (pages == 0)
            {
                ContentPage contentPage = (ContentPage)GeneralMethods.GetInstance($"{GetType().Namespace}.{type}");
                this.Children.Add(SetDefaultValues(title, contentPage));
            }

            CurrentPage = this.Children.Where(x => x.Title == title).First();
        }


    }
}
