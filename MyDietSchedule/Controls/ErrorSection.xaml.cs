using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MyDietSchedule.Controls
{
    public partial class ErrorSection : StackLayout
    {
        public ErrorSection()
        {
            InitializeComponent();
            ErrorList.ItemSelected += (sender, e) => ErrorList.SelectedItem = null;;
        }
        private static string[] defaultValue = new string[] { "" };

            public static readonly BindableProperty ErrorMessages = BindableProperty.Create("ErrorMsgs", typeof(string[]), typeof(ErrorSection), null);

        public string[] ErrorMsgs
        {
            get 
            {
                string[] errors = (string[])GetValue(ErrorMessages);
                IsVisible = !IsEmpty(errors);
                errors = IsVisible ? errors : new string[] { "" };
                SetErrorList(errors);
                return errors; 
            }
            set 
            {
                IsVisible = !IsEmpty(value);
                value = IsVisible ? value : new string[] { "" };
                SetValue(ErrorMessages, value); 
                SetErrorList(value);
            }
        }

        private void SetErrorList(string[] errors)
        {
            ErrorList.HeightRequest = 20 * errors.Count();
            ErrorList.ItemsSource = errors.Select(x => $"-{x}");;
        }

        private bool IsEmpty(string[] errors) 
        {
            return errors == null || (errors.Length < 1 || errors[0] == "");
        }
    }
}
