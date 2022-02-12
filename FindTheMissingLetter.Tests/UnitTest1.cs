using NUnit.Framework;

namespace FindTheMissingLetter.Tests
{
    public class Tests
    {


        [Test]
        [TestCase(new char[] { 'a', 'b', 'c', 'd', 'f' }, ExpectedResult = 'e')]
        [TestCase(new char[] { 'O', 'Q', 'R', 'S' }, ExpectedResult = 'P')]
        public char Test1(char[] array) => MissingLettersFinder.FindMissingLetter(array);
    }
}