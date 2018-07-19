using System;
using System.Collections.Generic;
using MyDietSchedule.Models;
using Xamarin.Forms;

namespace MyDietSchedule.Views.Users
{
    public partial class NewMeasures : ContentPage
    {
        Measurement measurement;
        public NewMeasures()
        {
            InitializeComponent();
            Init();
            InitMeasurements();
        }

        #region Initializers

        private void Init()
        {
            ActivitySpinner.IsVisible = false;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void InitMeasurements()
        {
            measurement = new Measurement(App.user.Id);
            this.BindingContext = measurement;
        }

        #endregion Initializers

        #region Methods
        public void AddMetrics(object sender, System.EventArgs e)
        {
            ActivitySpinner.IsVisible = true;
            string[] validations = measurement.ValidateEmptyFields();

            if(validations.Length == 0)
            {
                try
                {
                    App.MeasurementDataBase.Save(measurement);
                    DisplayAlert("all good!", "Everything were good!", "Ok");
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
        #endregion Methods
    }
}
