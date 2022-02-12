using NUnit.Framework;

namespace AlphabetPosition.Tests
{
    public class Tests
    {


        [Test]
        [TestCase("The sunset sets at twelve o' clock.", ExpectedResult = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11")]
        public string Test1(string text) => Position.GetAlphabetPosition(text);
    }
}