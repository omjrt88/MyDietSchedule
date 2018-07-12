using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDietSchedule.Utils;
using Xamarin.Forms;

namespace MyDietSchedule.CustomFormElements.Behaviors
{
    public class EmailValidatorBehavior : Behavior<Entry>
    {
        // Creating BindableProperties with Limited write access: http://iosapi.xamarin.com/index.aspx?link=M%3AXamarin.Forms.BindableObject.SetValue(Xamarin.Forms.BindablePropertyKey%2CSystem.Object) 

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(EmailValidatorBehavior), true);

        public static readonly BindableProperty ColorDefaultProperty = BindableProperty.Create("ColorDefault", typeof(Color), typeof(EmailValidatorBehavior), Color.Default);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

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

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.Unfocused += HandleTextUnfocused;
        }

        void HandleTextUnfocused(object sender, FocusEventArgs e)
        {
            Entry entry = (Entry)sender;
            string data = !string.IsNullOrWhiteSpace(entry.Text) ? entry.Text : "";
            IsValid = Constants.CheckEmail(data);
            ((Entry)sender).TextColor = IsValid ? ColorDefault : Color.Red;
        }


        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Unfocused -= HandleTextUnfocused;
        }
    }
}