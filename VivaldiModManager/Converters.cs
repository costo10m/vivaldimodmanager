﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace VivaldiModManager
{
    public class ButtonTextColorConverter : IValueConverter
    {
        public SolidColorBrush AccentColor { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToBoolean(value) ? "AntiqueWhite" : AccentColor.Color.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ButtonBgColorConverter : IValueConverter
    {
        public SolidColorBrush AccentColor { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToBoolean(value) ? AccentColor.Color.ToString() : "AntiqueWhite";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    
    public class UnableToChangeThisConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToBoolean(value) ? "" : "Unable to change this!\nPlease run this tool as administrator.";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RemoveDotEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = System.Convert.ToString(value).Replace("_", "__");
            if (val.EndsWith(".disabled")) return System.Convert.ToString(val).Replace(".disabled", "");
            else return val;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToString(value) + ".disabled";
        }
    }

    public class RemoveUnderscoreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Replace("_", "");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
