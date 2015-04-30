using NUnit.Framework;

namespace KataFooBarQix
{
    public class FooBarQixTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void Should_return_the_input_number_when_this_number_is_not_divisible_by_3_by_5_by_7_and_not_contains_3_5_and_7(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, "Foo")]
        [TestCase(9, "Foo")]
        public void Should_return_Foo_when_this_number_is_divisible_by_3(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, "Foo")]
        public void Should_return_Foo_when_this_number_contains_3(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, "FooBarBar")]
        public void Should_return_FooBar_when_this_number_is_divisible_by_3_and_contains_5(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(33, "FooFooFoo")]
        public void Should_return_FooBar_when_this_number_is_divisible_by_3_and_contains_3(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(77, "QixQixQix")]
        public void Should_return_FooBar_when_this_number_is_divisible_by_7_and_contains_7(int input, string expected)
        {
            string actual = new FooBarQix().Generate(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
