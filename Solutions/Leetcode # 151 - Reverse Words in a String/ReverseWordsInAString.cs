// Leetcode # 151 - Reverse Words in a String
// https://leetcode.com/problems/reverse-words-in-a-string/submissions/1660143238
using System.Text;

namespace ReverseWordsInAString
{
    public class Solutions
    {
        public string ReverseWords(string s)
        {
            s = s.Trim();
            List<string> words = new List<string>();
            int wordStrat = 0;
            for (int pointer = 0; pointer + 1 < s.Length; pointer++)
            {
                if (s[pointer] == ' ')
                {
                    words.Add(s.Substring(wordStrat, pointer - wordStrat));
                    while (s[pointer] == ' ')
                        pointer++;
                    wordStrat = pointer;
                }
            }

            words.Add(s.Substring(wordStrat, s.Length - wordStrat));

            StringBuilder resultBuilder = new StringBuilder();
            for(int i = words.Count - 1; i >= 0; i--)
            {
                resultBuilder.Append(words[i]);
                if(i > 0)
                    resultBuilder.Append(' ');
            }

            return resultBuilder.ToString();
        }

        public bool Test(string input, string expectedOutput)
            => ReverseWords(input) == expectedOutput;
    }
}
