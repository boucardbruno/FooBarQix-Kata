using System.Collections.Generic;
using System.Globalization;

namespace KataFooBarQix
{
    public class FooBarQix
    {
        private readonly Dictionary<int, string> _rules = new Dictionary<int, string>
        {
            { 3, "Foo"},
            { 5, "Bar"},
            { 7, "Qix"}
        }; 

        public string Generate(int number)
        {
            string defaultValue = number.ToString(CultureInfo.InvariantCulture);
            string result = string.Empty;
            foreach (var figure in _rules.Keys)
            {
                if (number.IsDivisbleBy(figure))
                    result += HandleDivisible(figure);

                if (number.Contains(figure))
                    result += HandleContain(number, figure);
            }
            return string.IsNullOrEmpty(result) ? defaultValue : result;
        }

        private string HandleDivisible(int figure)
        {
            return _rules[figure];
        }

        private string HandleContain(int number, int figure)
        {
            char target = figure.ToString(CultureInfo.InvariantCulture)[0];
            string result = string.Empty;

            foreach (var source in number.ToString(CultureInfo.InvariantCulture).ToCharArray())
            {
                if (source.Equals(target))
                    result += _rules[figure];
            }
            return result;
        }
    }
}