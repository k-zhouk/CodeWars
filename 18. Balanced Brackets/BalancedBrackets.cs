using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            // string testStr = ""; // null
            // string testStr = "[])"; // false
            // string testStr = "[[[["; // false
            // string testStr = "]])("; // false
            // string testStr = "([]())"; // true
            // string testStr = "[()(())][]"; // true
            string testStr = "[()]{}{[()()]()}"; // true
            // string testStr = "([]())]["; // false

            bool? res = IsBalanced(testStr);
            if(res== null)
            {
                Debug.WriteLine("The input string is empty");
            }
            else
            {
                Debug.WriteLine("Is the string \"" + testStr + "\" balanced?: " + res.ToString().ToUpper());
            }
        }
        static bool? IsBalanced(string str)
        {
            if (str.Length == 0)
            {
                return null;
            }
            else if (str.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> openBrStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[')
                {
                    openBrStack.Push(str[i]);
                }
                else if (openBrStack.Count>0)
                {
                    if (openBrStack.Peek() == '(' && str[i] != ')')
                    {
                        return false;
                    }
                    if (openBrStack.Peek() == '[' && str[i] != ']')
                    {
                        return false;
                    }
                    openBrStack.Pop();
                }
            }
            if (openBrStack.Count > 0) { return false; } else {return true;}
        }
    }
}
