namespace Solutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region TwoSum
            TwoSum.Solution TwoSumSolution = new TwoSum.Solution();
            if (TwoSumSolution.Test([2, 7, 11, 15], 9, [0, 1]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (TwoSumSolution.Test([3, 2, 4], 6, [1, 2]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (TwoSumSolution.Test([3, 3], 6, [0, 1]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (TwoSumSolution.Test([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11, [5, 11]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            #region ContainsDuplicate
            ContainsDuplicate.Solution ContainsDuplicateSolution = new ContainsDuplicate.Solution();
            if (ContainsDuplicateSolution.Test([1, 2, 3, 1], true))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (ContainsDuplicateSolution.Test([1, 2, 3, 4], false))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (ContainsDuplicateSolution.Test([1, 1, 1, 3, 3, 4, 3, 2, 4, 2], true))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            #region Move Zeroes
            MoveZeroes.Solution sol = new MoveZeroes.Solution();
            if (sol.Test([0, 1, 0, 3, 12], [1, 3, 12, 0, 0]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (sol.Test([0, 0, 1], [1, 0, 0]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (sol.Test([0, 1, 0, 2, 0, 0, 0, 5, 6, 7], [1, 2, 5, 6, 7, 0, 0, 0, 0, 0]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (sol.Test([1, 0, 0, 5], [1, 5, 0, 0]))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            #region Longest Common Prefix
            LongestCommonPrefix.Solutions longestCommonPrefixSolution = new LongestCommonPrefix.Solutions();

            if (longestCommonPrefixSolution.Test(["flower", "flow", "flight"], "fl"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestCommonPrefixSolution.Test(["dog", "racecar", "car"], ""))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestCommonPrefixSolution.Test(["ab", "a"], "a"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestCommonPrefixSolution.Test(["cir", "car"], "c"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            #region Longest Substring Without Repeating Characters
            LongestSubstringWithoutRepeatingCharacters.Solutions longestSubstringWithoutRepeatingCharactersSolution = new LongestSubstringWithoutRepeatingCharacters.Solutions();

            if (longestSubstringWithoutRepeatingCharactersSolution.Test("abcabcbb", 3))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestSubstringWithoutRepeatingCharactersSolution.Test("bbbbb", 1))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestSubstringWithoutRepeatingCharactersSolution.Test("pwwkew", 3))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestSubstringWithoutRepeatingCharactersSolution.Test("abcabcabcdeabc", 5))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (longestSubstringWithoutRepeatingCharactersSolution.Test("abcdbxyz", 6))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            #region Roman To Integer
            RomanToInteger.Solutions romanToIntegerSolution = new RomanToInteger.Solutions();
            if (romanToIntegerSolution.Test("III", 3))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (romanToIntegerSolution.Test("LVIII", 58))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (romanToIntegerSolution.Test("MCMXCIV", 1994))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion
        }
    }
}