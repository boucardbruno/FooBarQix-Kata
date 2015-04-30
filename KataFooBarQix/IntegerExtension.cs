using System.Globalization;

namespace KataFooBarQix
{
    public static class IntegerExtension
    {
        public static bool Contains(this int number, int figure)
        {
            char target = figure.ToString(CultureInfo.InvariantCulture)[0];

            foreach (var source in number.ToString(CultureInfo.InvariantCulture).ToCharArray())
            {
                if (source.Equals(target))
                    return true;
            }
            return false;
        }

        public static bool IsDivisbleBy(this int number, int figure)
        {
            return number%figure == 0;
        }
    }
}