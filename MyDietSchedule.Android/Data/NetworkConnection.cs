using System;
using Android.App;
using Android.Content;
using Android.Net;
using MyDietSchedule.Data.Interfaces;
using MyDietSchedule.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]
namespace MyDietSchedule.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public NetworkConnection()
        {
        }

        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            var ConnectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var ActivityNetworkInfo = ConnectivityManager.ActiveNetworkInfo;

            if(ActivityNetworkInfo != null && ActivityNetworkInfo.IsConnectedOrConnecting)
            {
                IsConnected = true;
            }
            else
            {
                IsConnected = false;
            }
        }
    }
}
