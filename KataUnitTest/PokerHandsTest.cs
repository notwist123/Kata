using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    [TestFixture]
    public class PokerHandsTest
    {
        [Test]
        [TestCase(new[] { "2H", "3D", "5S", "9C", "KD"}, new[] { "2H", "3D", "5S", "9C", "AH"},"White wins. - with highcard: Ace")]
        [TestCase(new[] { "2H", "3D", "5S", "9C", "KD"}, new[] { "2H", "3D", "5S", "9C", "KD"},"Tie.")]

        public void SampleTests(string[] black, string[] white, string expected)
        {
            var Kata = new PokerHands();
            var actual = Kata.WhoWin(black,white);

            Assert.AreEqual(expected, actual);
        }
    }
}
