using NUnit.Framework;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    class LeetCodeContainsDuplicateIITeset
    {
        [Test]
        [TestCase(new int[] { }, 0, false)]
        [TestCase(new int[] { 1, 1 }, 1, true)]
        [TestCase(new int[] { 99, 99 }, 2, true)]
        [TestCase(new int[] { 1, 0, 1, 1 }, 1, true)]
        public void BasicTests(int[] inputArray, int absoluteDiff, bool excepted)
        {
            var kata = new LeetCodeContainsDuplicateII();

            var actual = kata.ContainsNearbyDuplicate(inputArray, absoluteDiff);

            Assert.AreEqual(excepted, actual);
        }
    }
}
