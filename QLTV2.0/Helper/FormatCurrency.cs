﻿using System;

namespace QLTV2._0.Helper
{
    public static class  FormatCurrency
    {
        public static String Vnd(decimal? money)
    {
        var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
        return String.Format(format, "{0:c0}", money);
    }
    }
}
