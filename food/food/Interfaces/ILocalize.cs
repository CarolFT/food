﻿
namespace food.Interfaces
{
    using System.Globalization;
    public interface ILocalize
    {
        CultureInfo GetCurrentCulturenInfo();
        void SetLocale(CultureInfo ci);
    }
}
