using System;
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
            App.UserDataBase.Get();
            DesignInit();
            InitCircleImage();
            ActivitySpinner.IsVisible = false;

            Entry_Username.Completed += (sender, e) => Entry_Password.Focus();
            Entry_Password.Completed += SignInProcedureAsync;

            AutoCast autoCast = new AutoCast(Constants.InitialJson, App.FoodTypeDataBase, App.FoodDataBase);
            autoCast.Convert2Object();
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
                //FillColor = GeneralMethods.GetColor("ImgbackgroudColor"),
                Margin = new Thickness(0, 40, 0, 0)
            };

            ImgCircleStack.Children.Add(img);
        }
        #endregion Initializers

        #region Event Methods
        void SignInProcedureAsync(object sender, EventArgs e)
        {
            ActivitySpinner.IsVisible = true;

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            string[] validations = user.ValidateLogin();
            if (validations.Length == 0 && CheckBehaviors())
            {
                ErrorSection.ErrorMsgs = null;
                LoginMethod(ref user);
                ActivitySpinner.IsVisible = false;
                if (user.Id != 0)
                {
                    //await Navigation.PushModalAsync(new NavigationPage(new MasterDetail()));
                    Console.WriteLine("logged");
                }
                ActivitySpinner.IsVisible = false;
            }
            else
            {
                ErrorSection.ErrorMsgs = validations;
                ActivitySpinner.IsVisible = false;
            }
        }
        #endregion Methods


        #region Private Methods
        bool CheckBehaviors()
        {
            return emailValidator.IsValid;
        }

        protected void LoginMethod(ref User user)
        {
            try
            {
                user = App.UserDataBase.LogIn(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ErrorSection.ErrorMsgs = new string[] { Constants.LoginError };
            }
        }

        void RegisterView(object sender, EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            //Navigation.PushAsync(new NewUser());
            Navigation.PushAsync(new UserManagementView());
            ActivitySpinner.IsVisible = false;
        }
        #endregion Private Methods
    }
}
