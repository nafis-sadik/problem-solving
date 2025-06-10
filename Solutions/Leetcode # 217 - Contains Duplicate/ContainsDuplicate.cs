// Leetcode # 217 - Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/submissions/1654061794
namespace ContainsDuplicate
{
    public class Solution
    {
        // HashSet to store unique numbers encountered in the array
        HashSet<int> set = new HashSet<int>();

        // Checks if the input array contains any duplicate values
        public bool ContainsDuplicate(int[] nums)
        {
            set.Clear(); // Clear the set before processing a new array

            // Iterate through each number in the array
            foreach (int num in nums)
            {
                // If the number is already in the set, a duplicate is found
                if (set.Contains(num))
                    return true; // Duplicate found

                // Add the number to the set for future duplicate checks
                set.Add(num);
            }

            // If no duplicates are found after checking all numbers
            return false; // No duplicates found
        }

        // Test method to verify the ContainsDuplicate method against an expected result
        public bool Test(int[] nums, bool res)
            => ContainsDuplicate(nums) == res;
    }
}
