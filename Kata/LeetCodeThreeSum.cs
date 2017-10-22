using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class LeetCodeThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for (var i = 0; i < nums.Length - 2; i++)
            {
                int firstNum = nums[i];

                for (var j = i + 1; j < nums.Length - 1; j++)
                {
                    int nextNum = nums[j];
                    int startSearchIndex = j + 1;
                    int searchLength = nums.Length - startSearchIndex;
                    int searchValue = (firstNum + nextNum) * -1;
                    int thirdNumIndex = Array.BinarySearch(nums, startSearchIndex, searchLength, searchValue);

                    if (thirdNumIndex < 0) continue;

                    int[] addNum = { firstNum, nextNum, nums[thirdNumIndex] };
                    result.Add(addNum);

                    while (j < nums.Length - 1 && nums[j] == nums[j + 1]) j++;
                }
                while (i < nums.Length - 1 && nums[i] == nums[i + 1]) i++;
            }
            return result;
        }
    }
}
