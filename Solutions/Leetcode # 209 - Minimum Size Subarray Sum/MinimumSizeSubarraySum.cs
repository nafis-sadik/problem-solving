// Leetcode # 209 - Minimum Size Subarray Sum
// https://leetcode.com/problems/minimum-size-subarray-sum/submissions/1661218167
namespace MinimumSizeSubarraySum
{
    public class Solutions
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minSubArrLen = int.MaxValue, sum = 0, left = 0, right = 0;

            for(; right < nums.Length; right++)
            {
                sum += nums[right];

                while(sum >= target)
                {
                    minSubArrLen = Math.Min(minSubArrLen, right - left + 1);
                    sum -= nums[left++];
                }
            }
            
            return minSubArrLen != int.MaxValue ? minSubArrLen : 0;
        }

        public bool Test(int[] nums, int target, int res)
            => MinSubArrayLen(target, nums) == res;
    }
}
