
using NUnit.Framework;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    public class DeadAntsTest
    {
        [Test]
        [TestCase(0, "ant ant ant ant")]
        [TestCase(0, null)]
        [TestCase(2, "ant anantt aantnt")]
        [TestCase(1, "ant ant .... a nt")]
        public void BasicTests(int expected, string inputString)
        {
            var kata = new DeadAnts();
            int actual = kata.DeadAntCount(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
