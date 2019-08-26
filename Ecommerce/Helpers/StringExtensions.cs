namespace Helpers
{
    public static class StringExtensions
    {
        public static string UpperCaseFirstLetter(this string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string RemoveLineBreaks(this string s)
        {
            return string.IsNullOrEmpty(s) ? s : s.Replace("\r\n", " ");
        }
    }
}
