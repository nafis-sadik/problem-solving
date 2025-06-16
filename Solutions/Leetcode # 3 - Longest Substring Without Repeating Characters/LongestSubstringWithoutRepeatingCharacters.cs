// Leetcode # 3 - Longest Substring Without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1666007287
namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solutions
    {
        Dictionary<char, int> subStrMap = new Dictionary<char, int>();
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2) return s.Length;

            this.subStrMap.Clear();
            int subStrLen = 0, left = 0, right = 0;
            for (; right < s.Length; right++)
            {
                if (!subStrMap.ContainsKey(s[right]))
                {
                    subStrMap.Add(s[right], right);
                }
                else
                {
                    if (subStrMap[s[right]] >= left)
                        left = subStrMap[s[right]] + 1;

                    subStrMap[s[right]] = right;
                }

                subStrLen = Math.Max(subStrLen, right - left + 1);
            }

            return subStrLen;
        }

        public bool Test(string s, int expected)
            => LengthOfLongestSubstring(s) == expected;
    }
}
