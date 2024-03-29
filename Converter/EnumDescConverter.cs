﻿using Jaywapp.Infrastructure.Sys;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Jaywapp.Infrastructure.Converter
{
    public class EnumDescConverter : IValueConverter
    {
        private Type _currentType;
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Enum target))
                return null;

            _currentType = target.GetType();

            return target.GetDescriptionOrToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string target) 
                || _currentType == null
                || !EnumHelper.TryParseValueFromDescription(target, _currentType, out object parsed))
                return null;

            return parsed;
        }
    }

    public class EnumDescConverter<TEnum> : IValueConverter
        where TEnum : struct, IConvertible
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Enum target))
                return null;

            return target.GetDescriptionOrToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string target) || !EnumHelper.TryParseValueFromDescription(target, out TEnum parsed))
                return null;

            return parsed;
        }
    }
}
