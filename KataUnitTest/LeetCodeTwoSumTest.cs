using NUnit.Framework;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    class LeetCodeTwoSumTest
    {
        [Test]
        [TestCase(new[] { 0, 1 }, new[] { 2, 7, 11, 15 }, 9)]
        [TestCase(new[] { 1, 2 }, new[] { 2, 7, 11, 15 }, 18)]
        [TestCase(new[] { 1, 2 }, new[] { 3, 2, 4 }, 6)]
        public void BasicTests(int[] outputArray, int[] inputArray, int countingNumber)
        {
            var kata = new LeetCodeTwoSum();

            var actual = kata.TwoSum(inputArray, countingNumber);
            var excepted = outputArray;

            Assert.AreEqual(excepted, actual);
        }
    }
}
