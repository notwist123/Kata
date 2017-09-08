using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    class BandNameGeneratorTest
    {
        [Test]
        [TestCase("The Knife", "knife")]
        [TestCase("Tartart", "tart")]
        [TestCase("Sandlesandles", "sandles")]
        [TestCase("The Bed", "bed")]
        public void BasicTests(string expected, string inputString)
        {
            var kata = new BandNameGenerator();
            string actual = kata.NameGenerator(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}
