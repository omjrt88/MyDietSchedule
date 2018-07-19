using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDietSchedule.Utils;
using Xamarin.Forms;

namespace MyDietSchedule.CustomFormElements.Behaviors
{
    public class PasswordValidatorBehavior : Behavior<Entry>
    {
        // Creating BindableProperties with Limited write access: http://iosapi.xamarin.com/index.aspx?link=M%3AXamarin.Forms.BindableObject.SetValue(Xamarin.Forms.BindablePropertyKey%2CSystem.Object) 

        public static readonly BindableProperty ColorDefaultProperty = BindableProperty.Create("ColorDefault", typeof(Color), typeof(EmailValidatorBehavior), Color.Default);

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(NumberValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        static readonly BindablePropertyKey ErrorMessageKey = BindableProperty.CreateReadOnly("ErrorMessage", typeof(string), typeof(NumberValidatorBehavior), "");

        public static readonly BindableProperty ErrorMessageProperty = ErrorMessageKey.BindableProperty;

        public static readonly BindableProperty PasswordConfirmProperty = BindableProperty.Create("PasswordConfirm", typeof(string), typeof(EmailValidatorBehavior), "");

        static readonly BindablePropertyKey EntryValueKey = BindableProperty.CreateReadOnly("EntryValue", typeof(string), typeof(NumberValidatorBehavior), "");

        public static readonly BindableProperty EntryValueProperty = EntryValueKey.BindableProperty;

        // get & set functions
        public Color ColorDefault
        {
            get { return (Color)GetValue(ColorDefaultProperty); }
            set { SetValue(ColorDefaultProperty, value); }
        }

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        public string ErrorMessage
        {
            get { return (string)base.GetValue(ErrorMessageProperty); }
            private set { base.SetValue(ErrorMessageKey, value); }
        }

        public string PasswordConfirm
        {
            get { return (string)base.GetValue(PasswordConfirmProperty); }
            private set { base.SetValue(PasswordConfirmProperty, value); }
        }

        public string EntryValue
        {
            get { return (string)base.GetValue(EntryValueProperty); }
            private set { base.SetValue(EntryValueKey, value); }
        }

        // Methods
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.Unfocused += HandleTextUnfocused;
        }

        void HandleTextUnfocused(object sender, FocusEventArgs e)
        {
            Entry entry = (Entry)sender;
            string password = !string.IsNullOrWhiteSpace(entry.Text) ? entry.Text : "";
            if (string.IsNullOrWhiteSpace(PasswordConfirm))
            {
                ErrorMessage = CheckPassword(password);
            }
            else
            {
                ErrorMessage = ConfirmPassword(password);
            }
            IsValid = string.IsNullOrWhiteSpace(ErrorMessage);
            EntryValue = password;
            ((Entry)sender).TextColor = IsValid ? ColorDefault : GeneralMethods.GetColor("ErrorColor");
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Unfocused -= HandleTextUnfocused;
        }

        string CheckPassword(string password)
        {
            if (MinPasswordLength(password))
            {
                return "Password needs to be equal or greater that 6 characters.";
            }
            return "";
        }

        string ConfirmPassword(string password = "")
        {
            return !PasswordConfirm.Equals(password) ? "Password doesn't match, try again" : "";
        }

        bool MinPasswordLength(string password)
        {
            return password.Length < Constants.MinPasswordLength;
        }
    }
}