using System.Collections.Generic;

namespace HackerRank
{
    public static partial class Solution
    {
        public static string isBalanced(string s)
        {
            var charArray = s.ToCharArray();
            var stack = new Stack<char>();

            for (var i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(charArray[i]);
                        break;

                    case '}':
                        if (stack.Count == 0 || stack.Peek() != '{')
                            return "NO";
                        stack.Pop();
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Peek() != '(')
                            return "NO";
                        stack.Pop();
                        break;

                    case ']':
                        if (stack.Count == 0 || stack.Peek() != '[')
                            return "NO";
                        stack.Pop();
                        break;
                }
            }

            return stack.Count == 0
                ? "YES"
                : "NO";
        }
    }
}
