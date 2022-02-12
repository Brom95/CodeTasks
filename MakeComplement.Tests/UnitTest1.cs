using NUnit.Framework;

namespace MakeComplement.Tests
{
    public class Tests
    {
        
        [Test]
        [TestCase("ATTGC", ExpectedResult = "TAACG")]
        [TestCase("GTAT", ExpectedResult = "CATA")]
        public string Test(string dna)
        {
            return Complementator.MakeComplement(dna);
        }
    }
}