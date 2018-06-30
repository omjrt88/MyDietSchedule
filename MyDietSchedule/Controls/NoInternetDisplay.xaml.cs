using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Utils;

namespace MyDietSchedule.Controls
{
    public partial class NoInternetDisplay : StackLayout
    {
        public NoInternetDisplay()
        {
            InitializeComponent();
            StartInternetChecking();
        }

        private void StartInternetChecking()
        {
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                if (!CheckIfInternet())
                {
                    lbl_NoInternet.BackgroundColor = Color.Red;
                    lbl_NoInternet.Text = Constants.NoInternetText;
                }
                else
                {
                    lbl_NoInternet.BackgroundColor = Color.Transparent;
                    lbl_NoInternet.Text = "";
                }

                return true;
            });
        }

        private static bool CheckIfInternet()
        {
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            return networkConnection.IsConnected;
        }
    }
}
