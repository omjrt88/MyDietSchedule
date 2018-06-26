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
                lbl_NoInternet.Text = (!CheckIfInternet()) ? lbl_NoInternet.Text = Constants.NoInternetText : "";
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
