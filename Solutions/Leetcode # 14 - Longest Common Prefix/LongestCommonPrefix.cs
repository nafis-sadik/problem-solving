// Leetcode # 14 - Longest Common Prefix
// https://leetcode.com/problems/longest-common-prefix/submissions/1657795237
namespace LongestCommonPrefix
{
    public class Solutions
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            string prefix = strs[0];
            string currentString = string.Empty;
            for (int i = 1; i < strs.Length; i++)
            {
                currentString = strs[i];
                prefix = prefix.Length < currentString.Length ? prefix : prefix.Substring(0, currentString.Length);
                for (int x = 0; x < currentString.Length; x++)
                {
                    if (x < prefix.Length && prefix[x] == currentString[x]) continue;
                    else
                    {
                        prefix = prefix.Substring(0, x);
                        break;
                    }
                }
            }

            return prefix;
        }

        public bool Test(string[] strs, string res)
            => LongestCommonPrefix(strs) == res;
    }
}
