using NUnit.Framework;
using System;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    public class DubstepTest
    { 
        [Test]
        [TestCase("ABC", "WUBWUBABCWUB")]
        [TestCase("R L", "RWUBWUBWUBLWUB")]
        public void BasicTests(string excepted, string inputStirng)
        {
            var kata = new Dubstep();
            var actual = kata.SongDecoder(inputStirng);
            Assert.AreEqual(excepted, actual);
        }
    }
}
