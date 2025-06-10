// Leetcode # 13 - Roman to Integer
// https://leetcode.com/problems/roman-to-integer/submissions/1658348173

namespace RomanToInteger
{
    public class Solutions
    {
        Dictionary<char, int> dict = new Dictionary<char, int>{
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            int sum = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int numCurrent = dict[s[i]];
                int previous = 0;
                if (i >= 1)
                {
                    previous = dict[s[i - 1]];
                }

                if (previous > 0 && previous < numCurrent)
                {
                    sum = (numCurrent - previous) + sum;
                    i--;
                }
                else
                {
                    sum = numCurrent + sum;
                }
            }

            return sum;
        }
        public bool Test(string strs, int res)
            => RomanToInt(strs) == res;
    }        
}
