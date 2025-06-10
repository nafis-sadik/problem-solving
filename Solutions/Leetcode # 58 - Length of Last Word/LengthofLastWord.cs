// Leetcode # 58 - Length of Last Word
// https://leetcode.com/problems/length-of-last-word/submissions/1660078956

namespace LengthofLastWord
{
    public class Solutions
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] strArrp = s.Split(' ');
            return strArrp[strArrp.Length - 1].Length;
        }

        public bool Test(string s, int expected)
        {
            int result = LengthOfLastWord(s);
            return result == expected;
        }
    }
}
