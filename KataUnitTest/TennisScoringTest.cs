using NUnit.Framework;
using System;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    public class TennisScoringTest
    {
        [Test]
        [TestCase(0, 0, "Love - Love")]
        [TestCase(1, 0, "Fifteen - Love")]
        [TestCase(2, 0, "Thirty - Love")]
        [TestCase(3, 0, "Forty - Love")]
        [TestCase(3, 1, "Forty - Fifteen")]
        [TestCase(3, 3, "Deuce.")]
        [TestCase(4, 4, "Deuce.")]
        [TestCase(4, 0, "Player1 Win.")]
        [TestCase(1, 4, "Player2 Win.")]
        [TestCase(8, 6, "Player1 Win.")]
        [TestCase(6, 8, "Player2 Win.")]
        [TestCase(4, 5, "Player2 Advantage.")]
        [TestCase(5, 4, "Player1 Advantage.")]
        public void BasicTests(int player1Win, int player2Win, string excepted)
        {
            var kata = new TennisScoring();

            var actual = kata.getScoringResult(player1Win, player2Win);

            Assert.AreEqual(excepted, actual);
        }
    }
}
