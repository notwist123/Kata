using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    [TestFixture]
    class NextBiggerNumberTest
    {
        [Test]
        [TestCase(-1, 111)]
        [TestCase(-1, 531)]
        [TestCase(21, 12)]
        [TestCase(531, 513)]
        [TestCase(2071, 2017)]
        [TestCase(441, 414)]
        [TestCase(414, 144)]
        public void BasicTests(long expected, long inputString)
        {
            var kata = new NextBiggerNumber();
            long actual = kata.NextBigger(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
