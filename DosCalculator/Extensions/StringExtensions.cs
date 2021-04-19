namespace DosCalculator.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string self)
        {
            return string.IsNullOrEmpty(self);
        }
    }
}