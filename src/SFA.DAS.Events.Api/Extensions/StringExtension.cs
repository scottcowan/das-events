﻿using System;
using System.Globalization;
using FluentValidation;

namespace SFA.DAS.Events.Api.Extensions
{
    public static class StringExtension
    {
        public static DateTime ParseDateTime(this string datetime)
        {
            try
            {
                return DateTime.ParseExact(datetime, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new ValidationException($"Bad date format {ex.Message}");
            }
        }
    }
}
