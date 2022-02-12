using NUnit.Framework;

namespace NarcisticNumber.Tests
{
    public class Tests
    {

        [Test]
        public void Test153()
        {
            Assert.AreEqual(true, Narcissistic.IsNarcissistic(153));
        }
        [Test]
        public void Test1938()
        {
            Assert.AreEqual(false, Narcissistic.IsNarcissistic(1938));
        }
    }
}