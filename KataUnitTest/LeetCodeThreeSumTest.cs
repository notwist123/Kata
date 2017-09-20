using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    class LeetCodeThreeSumTest
    {
        [Test]
        [TestCase(new[] { -1, 0, 1, 2, -1, -4 , -1 },  new[] { -1, -1, 2 },new[] { -1, 0, 1 })]
        public void BasicTests(int[] inputArray, params object[] outputArray)
        {
            var kata = new LeetCodeThreeSum();

            var actual = kata.ThreeSum(inputArray);
            var excepted = new List<IList<int>>();

            foreach (int[] n in outputArray)
            {
                excepted.Add(n.ToList());
            }

            Assert.AreEqual(excepted, actual);
        }
    }
}
