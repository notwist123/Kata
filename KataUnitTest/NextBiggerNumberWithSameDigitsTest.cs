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
    class NextBiggerNumberWithSameDigitsTest
    {
        [Test]
        [TestCase(-1, 111)]
        [TestCase(-1, 531)]
        [TestCase(21, 12)]
        [TestCase(531, 513)]
        [TestCase(2071, 2017)]
        [TestCase(441, 414)]
        [TestCase(414, 144)]
        [TestCase(553773769, 553773697)]
        [TestCase(252638589, 252635988)]
        [TestCase(1234567908, 1234567890)]
        [TestCase(59884848483559, 59884848459853)]
        [TestCase(1940003812, 1940003281)]
        public void BasicTests(long expected, long inputString)
        {
            var kata = new NextBiggerNumberWithSameDigits();
            long actual = kata.NextBiggerNumber(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
