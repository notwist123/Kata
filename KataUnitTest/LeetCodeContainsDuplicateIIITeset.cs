using NUnit.Framework;
using Kata;

namespace KataUnitTest
{
    [TestFixture]
    class LeetCodeContainsDuplicateIIITeset
    {
        [Test]
        [TestCase(new int[] { -1, -1 }, 1, 0, true)]
        [TestCase(new int[] { -3, 3 }, 2, 4, false)]
        [TestCase(new int[] { 4, 2 }, 2, 1, false)]
        [TestCase(new int[] { 2, 0, -2, 2 }, 2, 1, false)]
        [TestCase(new int[] { 7, 2, 8 }, 2, 1, true)]
        [TestCase(new int[] { 3, 6, 0, 4 }, 2, 2, true)]
        public void BasicTests(int[] inputArray, int absoluteDiffIndex, int absoluteDiffNumber, bool excepted)
        {
            var kata = new LeetCodeContainsDuplicateIII();

            var actual = kata.ContainsNearbyAlmostDuplicate(inputArray, absoluteDiffIndex, absoluteDiffNumber);

            Assert.AreEqual(excepted, actual);
        }
    }
}
