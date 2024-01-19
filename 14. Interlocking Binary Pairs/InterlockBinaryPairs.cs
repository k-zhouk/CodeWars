﻿/*
Interlocking Binary Pairs
https://www.codewars.com/kata/628e3ee2e1daf90030239e8a

Task

Write a function that checks if two non-negative integers make an "interlocking binary pair".
Interlock?
- numbers can be interlocked if their binary representations have no 1's in the same place
- comparisons are made by bit position, starting from right to left (see the examples below)
- when representations are of different lengths, the unmatched left-most bits are ignored

Examples
a = 9, b = 4

Stacking representations shows how they can interlock.
9    1001
4     100

Here, no 1's share any position, so the function returns true.
    a = 3, b = 6

These representations do not interlock.
 3      11
 6     110

Finding they both have a 1 in the same position, the function returns false.
Input: Two non-negative integers.
Output: Boolean true or false whether or not these integers are interlockable.
 */

using System.Diagnostics;

using System;

namespace _14.Interlocking_Binary_Pairs
{
    class InterlockBinaryPairs
    {
        static void Main(string[] args)
        {
            ulong testNum1 = 9;
            ulong testNum2 = 4;
            Debug.WriteLine(Interlockable(testNum1, testNum2));

            testNum1 = 3;
            testNum2 = 6;
            Debug.WriteLine(Interlockable(testNum1, testNum2));
        }
        
        public static bool Interlockable(ulong a, ulong b)
        {

            string aStr = Convert.ToString(unchecked((long)a), 2);
            string bStr = Convert.ToString(unchecked((long)b), 2);

            int minStrLen= (aStr.Length < bStr.Length) ? aStr.Length : bStr.Length;

            for(int i = 1; i <= minStrLen; i++)
            {
                if(aStr[aStr.Length - i] == '1' & bStr[bStr.Length - i] == '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
