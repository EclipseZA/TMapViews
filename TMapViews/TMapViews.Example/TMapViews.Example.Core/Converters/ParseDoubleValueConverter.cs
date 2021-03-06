﻿using System;
using System.Globalization;
using MvvmCross.Converters;

namespace TMapViews.Example.Core.Converters
{
    // For more information on how to use Value Converter see:
    // https://mvvmcross.com/docs/value-converters
    public class ParseDoubleValueConverter : MvxValueConverter<double, string>
    {
        // Used for changing ViewModel values into View values
        protected override string Convert(double value, Type targetType, object parameter, CultureInfo culture)
            => value.ToString();
    }
}