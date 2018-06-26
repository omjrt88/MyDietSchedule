using System;

using Xamarin.Forms;

namespace MyDietSchedule.Controls
{
    public class NoInternetDisplay : ContentPage
    {
        public NoInternetDisplay()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

