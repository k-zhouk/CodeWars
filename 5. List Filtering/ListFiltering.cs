/*
https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/train/csharp

In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

Example

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
*/

using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.List_Filtering
{
    class ListFiltering
    {
        static void Main(string[] args)
        {
            List<object> testList1 = new List<object>() { 1, 2, "a", "b" };
            IEnumerable<int> resInt = GetIntegersFromList(testList1);
            foreach(int num in resInt)
            {
                Debug.Write(num + " ");
            }
            Debug.Write("\n");
            List<object> testList2 = new List<object>() { 1, 2, "a", "b", 0, 15 };
            resInt = GetIntegersFromList(testList2);
            foreach (int num in resInt)
            {
                Debug.Write(num + " ");
            }
            Debug.Write("\n");

            List<object> testList3 = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            resInt = GetIntegersFromList(testList3);
            foreach (int num in resInt)
            {
                Debug.Write(num + " ");
            }
            Debug.Write("\n");
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}
