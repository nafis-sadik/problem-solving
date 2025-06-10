// Leetcode # 3 - Longest Substring Without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1657939491
namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solutions
    {
        Dictionary<char, int> subStrMap = new Dictionary<char, int>();
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            subStrMap.Clear();
            for (int right = 0, left = 0; right < s.Length; right++)
            {
                char currentChar = s[right];
                if (!subStrMap.ContainsKey(currentChar))
                    subStrMap.Add(currentChar, right);
                else
                {
                    if (subStrMap[currentChar] >= left)
                        left = subStrMap[currentChar] + 1;

                    subStrMap[currentChar] = right;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        public bool Test(string s, int expected)
            => LengthOfLongestSubstring(s) == expected;
    }
}
