// Leetcode # 167 - Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/submissions/1666011233
namespace TwoSum_II
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            for (; left < right;)
            {
                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else
                {
                    return [left + 1, right + 1];
                }
            }

            return [left + 1, right + 1];
        }

        public bool Test(int[] numbers, int target, int[] res)
        {
            int[]? result = TwoSum(numbers, target);
            if (result.Length != res.Length) return false;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != res[i]) return false;
            }
            return true;
        }
    }
}
