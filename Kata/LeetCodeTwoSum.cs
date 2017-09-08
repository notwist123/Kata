namespace Kata
{
    public class LeetCodeTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target) return new[] { i, j };
                }
            }
            return new[] { -1 };
        }
    }
}
