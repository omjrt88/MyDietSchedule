using System;
using System.Collections.Generic;
using MyDietSchedule.CustomFormElements;
using MyDietSchedule.Models;
using MyDietSchedule.Utils;
using MyDietSchedule.Views.Users;
using Xamarin.Forms;

namespace MyDietSchedule.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            Init();
        }

        #region Initializers
        void Init()
        {
            DesignInit();
            InitCircleImage();
            ActivitySpinner.IsVisible = false;

            Entry_Username.Completed += (sender, e) => Entry_Password.Focus();
            Entry_Password.Completed += SignInProcedure;
        }

        private void DesignInit()
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void InitCircleImage()
        {
            ImageCircle img = new ImageCircle
            {
                CircleName = "Example",
                HeightRequest = Constants.LoginIconHeight,
                WidthRequest = Constants.LoginIconHeight,
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                Source = "LoginIcon.png",
                Margin = new Thickness(0, 40, 0, 0)
            };

            ImgCircleStack.Children.Add(img);
        }

        #endregion

        #region Event Methods
        async void SignInProcedure(object sender, EventArgs e)
        {
            ActivitySpinner.IsVisible = true;

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Logged)
            {
                await DisplayAlert("Login", "Si Entro esta vez", "Ok");

                ActivitySpinner.IsVisible = false;
                //await Navigation.PushModalAsync(new NavigationPage(new MasterDetail()));
            }
            else
            {
                await DisplayAlert("Login", "Error, Error, Error, Error, Error....", "Ok");
                //await DisplayAlert("Login", "Login Not Correct, empty username or password", "Ok");
                ActivitySpinner.IsVisible = false;
            }
        }

        void RegisterView(object sender, EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            Navigation.PushAsync(new NewUser());
            ActivitySpinner.IsVisible = false;
        }
        #endregion
    }
}
