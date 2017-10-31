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
    class ConwayGameTest
    {
        [Test]
        [TestCase(EnumStatus.Alive, 0, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 1, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 2, EnumStatus.Alive)]
        [TestCase(EnumStatus.Alive, 3, EnumStatus.Alive)]
        [TestCase(EnumStatus.Alive, 4, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 5, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 6, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 7, EnumStatus.Dead)]
        [TestCase(EnumStatus.Alive, 8, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 0, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 1, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 2, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 3, EnumStatus.Alive)]
        [TestCase(EnumStatus.Dead, 4, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 5, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 6, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 7, EnumStatus.Dead)]
        [TestCase(EnumStatus.Dead, 8, EnumStatus.Dead)]
        public void BasicTests(EnumStatus status, int aliveNumber, EnumStatus excepted)
        {
            var kata = new ConwayGame(status, aliveNumber);

            var actual = kata.GetNextStatus();

            Assert.AreEqual(excepted, actual);
        }
    }
}
