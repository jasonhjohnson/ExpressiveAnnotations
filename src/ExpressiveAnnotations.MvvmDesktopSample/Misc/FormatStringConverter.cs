﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ExpressiveAnnotations.MvvmDesktopSample.Misc
{
    public class FormatStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value.ToString();

            var formatterString = parameter.ToString();
            return string.IsNullOrEmpty(formatterString) ? value.ToString() : string.Format(culture, formatterString, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
