using NUnit.Framework;
using System;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    public class BuildTowerTest
    {
        [Test]
        [TestCase(new[] { "*" }, 1)]
        [TestCase(new[] { " * ", "***" }, 2)]
        [TestCase(new[] { "  *  ", " *** ", "*****" }, 3)]
        public void BasicTests(string[] outputStrings, int inputNum)
        {
            var kata = new BuildTower();

            var actual = string.Join(",", kata.TowerBuilder(inputNum));
            var excepted = string.Join(",", outputStrings);
            
            Assert.AreEqual(excepted,actual);
        }
    }
}
