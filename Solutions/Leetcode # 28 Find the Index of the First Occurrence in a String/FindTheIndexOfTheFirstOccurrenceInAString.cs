// Leetcode # 28 - Find the Index of the First Occurrence in a String
// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/1662795760
namespace FindTheIndexOfTheFirstOccurrenceInAString
{
    public class Solutions
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;
            if (needle.Length == 0) return 0;
            if (needle.Length == haystack.Length) return needle == haystack ? 0 : -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                {
                    int needleIndex = 0;
                    int haystackIndex = i;
                    for (needleIndex = 0; needleIndex < needle.Length; needleIndex++)
                    {
                        if (haystack[haystackIndex] == needle[needleIndex]) haystackIndex++;
                        else break;
                    }

                    if (needleIndex == needle.Length) return i;
                }
            }

            return -1;
        }

        public bool Test(string haystack, string needle, int res)
            => StrStr(haystack, needle) == res;
    }
}
