// Leetcode # 283 - Move Zeroes
// https://leetcode.com/problems/move-zeroes/submissions/1657434207
using Solutions;

namespace MoveZeroes
{
    public class Solution
    {
        IList<int> numList = new List<int>();
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;

            numList.Clear();

            foreach (int num in nums)
                if (num != 0)
                    numList.Add(num);

            while (numList.Count < nums.Length)
                numList.Add(0);

            for (int i = 0; i < nums.Length; i++)
                nums[i] = numList[i];
        }

        public void MoveZeroes2(int[] nums)
        {
            if (nums.Length <= 1) return;

            int pointer = 0, right = 0;
            foreach(int num in nums)
            {
                if(num != 0)
                {
                    nums.Swap(pointer, right);
                    pointer++;
                }

                right++;
            }

            for(; nums.Length < pointer; pointer++)
            {
                nums[pointer] = 0;
            }
        }

        public bool Test(int[] nums, int[] res)
        {
            MoveZeroes2(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != res[i]) return false;
            }

            return true;
        }
    }
}
