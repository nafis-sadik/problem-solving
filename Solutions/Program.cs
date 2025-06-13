using System.Collections.Generic;

namespace Solutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Print.Heading("Two Sum");
            #region Two Sum
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

            Print.Heading("Contains Duplicate");
            #region Contains Duplicate
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

            Print.Heading("Move Zeroes");
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

            Print.Heading("Longest Common Prefix");
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

            Print.Heading("Longest Substring Without Repeating Characters");
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

            Print.Heading("Roman To Integer");
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

            Print.Heading("Length of Last Word");
            #region Length of Last Word
            LengthofLastWord.Solutions lengthOfLastWordSolution = new LengthofLastWord.Solutions();
            if (lengthOfLastWordSolution.Test("Hello World", 5))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (lengthOfLastWordSolution.Test("   fly me   to   the moon  ", 4))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (lengthOfLastWordSolution.Test("luffy is still joyboy", 6))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Reverse Words in a String");
            #region Reverse Words in a String
            ReverseWordsInAString.Solutions reverseWordsInAStringSolution = new ReverseWordsInAString.Solutions();
            if (reverseWordsInAStringSolution.Test("the sky is blue", "blue is sky the"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (reverseWordsInAStringSolution.Test("  hello world  ", "world hello"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (reverseWordsInAStringSolution.Test("   a good     example  ", "example good a"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (reverseWordsInAStringSolution.Test("F R  I   E    N     D      S      ", "S D N E I R F"))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Minimum Size Subarray Sum");
            #region Minimum Size Subarray Sum
            MinimumSizeSubarraySum.Solutions minimumSizeSubarraySumSolution = new MinimumSizeSubarraySum.Solutions();
            if (minimumSizeSubarraySumSolution.Test([2, 3, 1, 2, 4, 3], 7, 2))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (minimumSizeSubarraySumSolution.Test([1, 4, 4], 4, 1))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (minimumSizeSubarraySumSolution.Test([1, 1, 1, 1, 1, 1, 1, 1], 11, 0))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (minimumSizeSubarraySumSolution.Test([1, 2, 3, 4, 5], 11, 3))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (minimumSizeSubarraySumSolution.Test([1, 2, 3, 4, 5], 15, 5))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Valid Parentheses");
            #region Valid Parentheses
            ValidParentheses.Solutions validParenthesesSolution = new ValidParentheses.Solutions();
            if (validParenthesesSolution.Test("()", true))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (validParenthesesSolution.Test("()[]{}", true))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (validParenthesesSolution.Test("(]", false))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (validParenthesesSolution.Test("]", false))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Merge Two Sorted Lists");
            #region Merge Two Sorted Lists
            MergeTwoSortedLists.Solutions mergeTwoSortedListsSolution = new MergeTwoSortedLists.Solutions();
            MergeTwoSortedLists.Solutions.ListNode list1 = new MergeTwoSortedLists.Solutions.ListNode(
                1, new MergeTwoSortedLists.Solutions.ListNode(
                    2, new MergeTwoSortedLists.Solutions.ListNode(
                        4)));
            MergeTwoSortedLists.Solutions.ListNode list2 = new MergeTwoSortedLists.Solutions.ListNode(
                1, new MergeTwoSortedLists.Solutions.ListNode(
                    3, new MergeTwoSortedLists.Solutions.ListNode(
                        4)));
            MergeTwoSortedLists.Solutions.ListNode expected = new MergeTwoSortedLists.Solutions.ListNode(
                1, new MergeTwoSortedLists.Solutions.ListNode(
                    1, new MergeTwoSortedLists.Solutions.ListNode(
                        2, new MergeTwoSortedLists.Solutions.ListNode(
                            3, new MergeTwoSortedLists.Solutions.ListNode(
                                4, new MergeTwoSortedLists.Solutions.ListNode(
                                    4))))));
            if (mergeTwoSortedListsSolution.Test(list1, list2, expected))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (mergeTwoSortedListsSolution.Test(null, null, null))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            list1 = new MergeTwoSortedLists.Solutions.ListNode(
                -9, new MergeTwoSortedLists.Solutions.ListNode(3));
            list2 = new MergeTwoSortedLists.Solutions.ListNode(
                5, new MergeTwoSortedLists.Solutions.ListNode(7));
            expected = new MergeTwoSortedLists.Solutions.ListNode(
                -9, new MergeTwoSortedLists.Solutions.ListNode(
                    3, new MergeTwoSortedLists.Solutions.ListNode(
                        5, new MergeTwoSortedLists.Solutions.ListNode(7))));
            if (mergeTwoSortedListsSolution.Test(list1, list2, expected))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Maximum Difference Between Adjacent Elements in a Circular Array");
            #region Maximum Difference Between Adjacent Elements in a Circular Array
            MaximumDifferenceBetweenAdjacentElementsInACircularArray.Solutions maxDiffSolution = new MaximumDifferenceBetweenAdjacentElementsInACircularArray.Solutions();
            if (maxDiffSolution.IsValid([1, 2, 4], 3))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (maxDiffSolution.IsValid([-5, -10, -5], 5))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
            #endregion

            Print.Heading("Find the Index of the First Occurrence in a String");
            FindTheIndexOfTheFirstOccurrenceInAString.Solutions solution = new FindTheIndexOfTheFirstOccurrenceInAString.Solutions();
            if(solution.Test("sadbutsad", "sad", 0))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (solution.Test("leetcode", "leeto", -1))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (solution.Test("a", "a", 0))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");

            if (solution.Test("mississippi", "issip", 4))
                Print.Success("Test passed!");
            else
                Print.Error("Test failed!");
        }
    }
}