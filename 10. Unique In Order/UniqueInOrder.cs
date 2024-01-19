/*

https://www.codewars.com/kata/54e6533c92449cc251001667/

Unique In Order

Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements
with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1 ,2 ,3}

*/

using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Unique_In_Order
{
    class UniqueInOrderClass
    {
        static void Main(string[] args)
        {
            string testStr = "";
            var res = UniqueInOrder(testStr);
            if ((string)res == "")
            {
                Debug.WriteLine("The string is empty");
            }
            Debug.WriteLine(String.Empty);

            testStr = "AAAABBBCCDAABBB";

            res = UniqueInOrder(testStr);
            foreach(var elem in res)
            {
                Debug.Write(elem+ " ");
            }
            Debug.WriteLine(String.Empty);

            testStr = "ABBCcAD";
            res = UniqueInOrder(testStr);
            foreach (var elem in res)
            {
                Debug.Write(elem + " ");
            }
            Debug.WriteLine(String.Empty);

            int[] testArr = {1, 2, 2, 3, 3};
            var res2 = UniqueInOrder(testArr);
            foreach (var elem in res2)
            {
                Debug.Write(elem + " ");
            }
            Debug.WriteLine(String.Empty);
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable.Count() == 0)
            {
                return Enumerable.Empty<T>();
            }
            IEnumerable<T> resQuery = new T[] { iterable.First() };

           for (int i=1; i < iterable.Count(); i++)
           {
               if (iterable.ElementAt(i).Equals(iterable.ElementAt(i - 1)))
               {
                  continue;
               } else
               {
                    resQuery = resQuery.Concat(new T[] { iterable.ElementAt(i) });
               }
           }
           return resQuery;
        }
    }
}
