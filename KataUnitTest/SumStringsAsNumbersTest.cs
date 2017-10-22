using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Kata;
using NUnit.Framework;

namespace KataUnitTest
{
    [TestFixture]
    public class SumStringAsNumbersTest
    {
        [Test]
        [TestCase("1079", new[] { "623", "456" })]
        public void SampleTests(string expected, string[] inputString)
        {
            var Kata = new SumStringsAsNumbers();
            var actual = Kata.sumStrings(inputString[0], inputString[1]);

            Assert.AreEqual(expected, actual);
        }
    }
}
