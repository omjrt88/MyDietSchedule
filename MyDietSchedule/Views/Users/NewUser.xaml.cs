using System;
using System.Collections.Generic;
using MyDietSchedule.Models;
using MyDietSchedule.Utils;
using Xamarin.Forms;

namespace MyDietSchedule.Views.Users
{
    public partial class NewUser : ContentPage
    {
        User user;
        public NewUser()
        {
            InitializeComponent();
            Init();
            DesignInit();
            InitUser();
        }

        #region Initializers

        private void Init()
        {
            ActivitySpinner.IsVisible = false;
            Entry_ConfirmPassword.Completed += (sender, e) => Btn_Register.Focus();
        }

        private void DesignInit()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Constants.GetColor("PrimaryColor");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Constants.GetColor("BarTextColor");
        }

        void InitUser()
        {
            user = new User();
            this.BindingContext = user;
            Entry_ConfirmPassword.Text = "";
        }
        #endregion Initializers

        #region Event Methods
        void LoginViewEvent(object sender, System.EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            Navigation.PopAsync();
            ActivitySpinner.IsVisible = false;
        }

        public void RegisterEvent(object sender, System.EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            string[] validations = user.ValidateEmptyFields();

            if (validations.Length == 0 && CheckBehaviors())
            {
                try
                {
                    App.UserDataBase.Save(user);
                    InitUser();
                    //ActivitySpinner.IsVisible = true;
                    //Navigation.PushAsync(new NewMeasures());
                    //ActivitySpinner.IsVisible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                ErrorSection.ErrorMsgs = null;
            }
            else
            {
                ErrorSection.ErrorMsgs = validations;
            }

            ActivitySpinner.IsVisible = false;
        }
        #endregion Event Methods

        #region Private Methods
        bool CheckBehaviors()
        {
            return emailValidator.IsValid && passValidator.IsValid && confirmPassValidator.IsValid;
        }
        #endregion Private Methods
    }
}
