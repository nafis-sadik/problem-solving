// Leetcode # 20 - Valid Parentheses
// https://leetcode.com/problems/valid-parentheses/submissions/1661980169
namespace ValidParentheses
{
    public class Solutions
    {
        Stack<char> stack = new Stack<char>();
        public bool IsValid(string s)
        {
            stack.Clear();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if((stack.Count <= 0)) return false;
                    if ((stack.Peek().Equals('(') && s[i] == ')') ||
                        (stack.Peek().Equals('{') && s[i] == '}') ||
                        (stack.Peek().Equals('[') && s[i] == ']'))
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }

        public bool Test(string s, bool res)
            => IsValid(s) == res;
    }
}
