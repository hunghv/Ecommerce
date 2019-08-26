using System;
using System.Globalization;

namespace Helpers
{
    public static class DateTimeExtensions
    {
        private const string ShortFriendlyDateFormat = "dd/MM/yyyy";

        public static bool IsMinValue(this DateTime @this) => @this == DateTime.MinValue;

        public static DateTime ThisOrNowIfMinValue(this DateTime @this) => @this.IsMinValue() ? DateTime.Now : @this;

        public static string ToShortFriendlyDateOrPresent(this DateTime? date)
        {
            return date?.ToString(ShortFriendlyDateFormat) ?? "Present";
        }

        public static string ToShortFriendlyDate(this DateTime date)
        {
            return date.ToString(ShortFriendlyDateFormat);
        }

        public static DateTime? ToDateOrDefaultFromShortFriendly(string shortFriendlyDate)
        {
            DateTime date;

            if (DateTime.TryParseExact(shortFriendlyDate, ShortFriendlyDateFormat, null, DateTimeStyles.None, out date))
            {
                return date;
            }

            return null;
        }
    }
}
