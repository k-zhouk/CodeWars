using System;
using System.Text;

using System.Diagnostics;

namespace _10_1_Unique_In_Order__String
{
    class UniqueInOrderString
    {
        static void Main(string[] args)
        {
            string testStr, res;

            testStr= "AAAABBBCCDAABBB"; // ABCDAB
            res = UniqueInOrder(testStr);
            Debug.WriteLine(res);

            testStr = "ABBCcAD"; // ABCcAD
            res = UniqueInOrder(testStr);
            Debug.WriteLine(res);

            testStr = "12233"; // 123
            res = UniqueInOrder(testStr);
            Debug.WriteLine(res);

            testStr = "abc"; // abc
            res = UniqueInOrder(testStr);
            Debug.WriteLine(res);
        }

        public static string UniqueInOrder(string str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(str[0]);

            for(int i=1; i< str.Length; ++i)
            {
                if(str[i-1]!= str[i])
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }
    }
}
