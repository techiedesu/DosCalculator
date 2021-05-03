namespace DosCalculator.Core.Expressions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string self)
        {
            return string.IsNullOrEmpty(self);
        }
    }
}