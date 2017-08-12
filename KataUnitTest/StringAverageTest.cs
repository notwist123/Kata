using System;
using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    [TestFixture]
    public class StringAverageTest
    {
        [Test]
        [TestCase("four","zero nine five two")]
        [TestCase("three", "four six two three")]
        [TestCase("three", "one two three four five")]
        [TestCase("four", "five four")]
        [TestCase("zero", "zero zero zero zero zero")]
        [TestCase("two", "one one eight one")]
        [TestCase("n/a", "")]
        public void SampleTests(string expected, string inputString)
        {
            var Kata = new StringAverage();
            var actual = Kata.AverageString(inputString);

            Assert.AreEqual(expected,actual);
        }
    }
}
