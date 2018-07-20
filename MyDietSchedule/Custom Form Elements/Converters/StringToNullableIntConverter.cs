﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyDietSchedule.CustomFormElements.Converters
{
    public class StringToNullableIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value as string;

            if (string.IsNullOrEmpty(strValue))
                return null;

            double resultInt;

            if (double.TryParse(strValue, out resultInt))
            {
                return resultInt;
            }
            return null;
        }
    }
}