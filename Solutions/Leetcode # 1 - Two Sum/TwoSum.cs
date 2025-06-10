// Leetcode # 1 - Two Sum
// https://leetcode.com/problems/two-sum/submissions/1657944163
namespace TwoSum
{
    public class Solution
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2)
                return [0, 1];

            dict.Clear();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
                else
                {
                    if (nums[i] * 2 == target)
                        return [dict[nums[i]], i];
                    else
                        dict[nums[i]] = i;
                }

                if (dict.ContainsKey(target - nums[i]) && dict[target - nums[i]] != i)
                    return [dict[target - nums[i]], i];
            }

            return [0, 1];
        }

        public bool Test(int[] nums, int target, int[] sol)
        {
            HashSet<int> result = TwoSum(nums, target).ToHashSet();
            foreach (int i in sol)
            {
                if (!result.Contains(i)) return false;
            }

            return true;
        }
    }
}
