namespace MaximumDifferenceBetweenAdjacentElementsInACircularArray
{
    public class Solutions
    {
        public int MaxAdjacentDistance(int[] nums)
        {
            int res = int.MinValue, temp = 0;
            for (int left = 0, right = 1; left < nums.Length;)
            {
                if (right >= nums.Length)
                    right = 0;

                temp = nums[right++] - nums[left++];
                temp = temp < 0 ? temp * -1 : temp;
                res = Math.Max(res, temp);
            }

            return res < 0 ? res * -1 : res;
        }

        public bool IsValid(int[] nums, int res)
            => MaxAdjacentDistance(nums) == res;
    }
}
