﻿using System;
namespace Fardis
{
    public interface IDateTimeHelper
    {
        string ConvertToPersianDate(DateTime? date);
        string ConvertToPersianDatePersianDigit(DateTime? date);
        DateTime ConvertPersianToGregorainDate(string persianDate);
        bool IsPersianYearLeap(int persianYear);
        string AddDatePersian(string sourcePersianDate, int day);
        string DatePartPersian(string datePart, string sourcePersianDate);
        string DateDiffPersian(string datepart, string startdate, string enddate);
        bool IsValidPersianDate(string source);
    }
}
