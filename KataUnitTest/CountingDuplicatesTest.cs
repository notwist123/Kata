using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    public class CountingDuplicatesTest
    {
        [Test]
        [TestCase(0, "")]
        [TestCase(0, "abcde")]
        [TestCase(2, "aabbcde")]
        [TestCase(2, "aabBcde")]
        [TestCase(1, "Indivisibility")]
        [TestCase(2, "Indivisibilities")]
        public void BasicTests(int excepted, string inputStirng)
        {
            var kata = new CountingDuplicates();
            var actual = kata.DuplicateCount(inputStirng);
            Assert.AreEqual(excepted, actual);
        }
    }
}
