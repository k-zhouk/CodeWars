/*
Binary Addition
https://www.codewars.com/kata/551f37452ff852b7bd000139

Implement a function that adds two numbers together and returns their sum in binary.
The conversion can be done before, or after the addition.

The binary number returned should be a string.

Examples:
(Input1, Input2 --> Output (explanation)))
1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)
 */
using System.Diagnostics;

using System;

namespace _12.Binary_Addition
{
    class BinaryAddition
    {
        static void Main(string[] args)
        {
            int testNum1 = 1;
            int testNum2 = 1;
            Debug.WriteLine(Convert.ToString(testNum1, 2) + "+" + Convert.ToString(testNum2, 2) + ": " + AddBinary(testNum1, testNum2));

            testNum1 = 5;
            testNum2 = 9;
            Debug.WriteLine(Convert.ToString(testNum1, 2) + "+" + Convert.ToString(testNum2, 2) + ": " + AddBinary(testNum1, testNum2));
        }
        
        public static string AddBinary(int a, int b) => Convert.ToString(a + b, 2);

    }
}
