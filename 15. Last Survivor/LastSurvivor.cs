/*
Last Survivor

https://www.codewars.com/kata/609eee71109f860006c377d1/

You are given a string of letters and an array of numbers. The numbers indicate positions of letters that must be removed,
in order, starting from the beginning of the array. After each removal the size of the string decreases (there is no empty space).
Return the only letter left.

Example:
let str = "zbk", arr = [0, 1]
    str = "bk", arr = [1]
    str = "b", arr = []
    return 'b'

Notes:
- The given string will never be empty.
- The length of the array is always one less than the length of the string.
- All numbers are valid.
- There can be duplicate letters and numbers.

*/
using System.Diagnostics;

using System;

namespace _15.Last_Survivor
{
    class LastSurvivorClass
    {
//        [TestCase("abc", new int[] { 1, 1 }, "a", Description = "letters: \"abc\"  coords: [1, 1]")]
//        [TestCase("kbc", new int[] { 0, 1 }, "b", Description = "letters: \"kbc\"  coords: [0, 1]")]
//        [TestCase("zbk", new int[] { 2, 1 }, "z", Description = "letters: \"zbk\"  coords: [2, 1]")]
//        [TestCase("c", new int[0], "c", Description = "letters: \"c\"  coords: []")]

        static void Main(string[] args)
        {
            string testStr = "c";
            int[] testArr = new int[] { 0 };

            Debug.WriteLine("Resulsting str= " + LastSurvivor(testStr, testArr));
        }

        public static string LastSurvivor(string letters, int[] coords)
        {

            string tmpString = letters;

            if (tmpString.Length != 1)
            {
                foreach (var coord in coords)
                {
                    tmpString = tmpString.Remove(coord, 1);
                }
            }
            return tmpString;
        }
    }
}
