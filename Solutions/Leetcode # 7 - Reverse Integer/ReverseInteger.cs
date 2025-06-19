// https://leetcode.com/problems/reverse-integer/submissions/1669692085

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x >= int.MaxValue) return 0;
            if (x <= int.MinValue) return 0;
            int pop = 0;
            System.Int64 result = 0;

            while (x != 0)
            {
                pop = x % 10;
                x /= 10;
                result = (result * 10) + pop;
                if (result >= int.MaxValue) return 0;
                if (result <= int.MinValue) return 0;
            }


            return (int)result;
        }

        public bool Test(int x, int res)
            => Reverse(x) == res;
    }
}
