using System;
using System.Collections.Generic;
using MyDietSchedule.Models;
using MyDietSchedule.Utils;
using Xamarin.Forms;

namespace MyDietSchedule.Views.Users
{
    public partial class NewUser : ContentPage
    {
        public NewUser()
        {
            InitializeComponent();
            Init();
            DesignInit();
        }

        private void Init()
        {
            ActivitySpinner.IsVisible = false;
        }

        private void DesignInit()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Constants.BackgroundColor;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Constants.MainTextColor;
        }

        #region Event Methods
        void LoginViewEvent(object sender, System.EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            Navigation.PopAsync();
            ActivitySpinner.IsVisible = false;
        }

        async void RegisterEvent(object sender, System.EventArgs e)
        {
            if (CheckEmptyValues())
            {
                await DisplayAlert("Error", "There are empty files, please fill all in", "Ok");
                return;
            }
            if (MinPasswordLength())
            {
                await DisplayAlert("Error", "Password nneds to be equal or greater that 6 characters.", "Ok");
                return;
            }
            if (!ConfirmPassword())
            {
                await DisplayAlert("Error", "Password doesn't match, try again", "Ok");
                return;
            }
            User newUser = new User(Entry_Email.Text, Entry_Password.Text, Entry_FirstName.Text, Entry_LastName.Text, Entry_Phone.Text, BirthDatePicker.Date, Editor_Address.Text);

            // Save User info
        }
        #endregion

        #region Private Methods
        private bool MinPasswordLength()
        {
            return Entry_Password.Text.Length < Constants.MinPasswordLength;
        }

        private bool ConfirmPassword()
        {
            return Entry_Password.Text.Equals(Entry_ConfirmPassword.Text);
        }

        private bool CheckEmptyValues()
        {
            return IsEmpty(Entry_FirstName.Text) ||
                IsEmpty(Entry_LastName.Text) ||
                IsEmpty(Editor_Address.Text) ||
                IsEmpty(Entry_Phone.Text) ||
                IsEmpty(Entry_Email.Text) ||
                IsEmpty(Entry_Password.Text) ||
                IsEmpty(Entry_ConfirmPassword.Text);
        }

        private bool IsEmpty(string value)
        {
            return String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }
        #endregion
    }
}
