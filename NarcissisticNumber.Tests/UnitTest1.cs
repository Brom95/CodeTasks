using NUnit.Framework;

namespace NarcisticNumber.Tests
{
    public class Tests
    {

        [Test]
        [TestCase(153, ExpectedResult = true)]
        [TestCase(1938, ExpectedResult = false)]
        public bool Test153(int input)
        {
            return Narcissistic.IsNarcissistic(input);
        }

    }
}