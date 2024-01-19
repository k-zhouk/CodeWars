/*
https://www.codewars.com/kata/526571aae218b8ee490006f4/

Write a function that takes an integer as input, and returns the number of bits that are equal to one
in the binary representation of that number. You can guarantee that input is non-negative.

Example:
The binary representation of 1234 is 10011010010, so the function should return 5 in this case
*/

using System.Diagnostics;

using System;
using System.Numerics;


namespace _11.Bit_Counting
{
    class BitCounting
    {
        static void Main(string[] args)
        {
            int num = 0; // 0
            Debug.WriteLine("Number of bits set for " + num + ": " + CountBits(num));

            num = 4; // 1
            Debug.WriteLine("Number of bits set for " + num + ": " + CountBits(num));

            num = 7; // 3
            Debug.WriteLine("Number of bits set for " + num + ": " + CountBits(num));

            num = 9; // 2
            Debug.WriteLine("Number of bits set for " + num + ": " + CountBits(num));

            num = 10; // 2
            Debug.WriteLine("Number of bits set for " + num + ": " + CountBits(num));
        }

        public static int CountBits(int n)
        {
            int bitCounter = 0;

            for (int i = 0; i < 32; i++)
            {
                bitCounter += n & 1;
                n = n >> 1;
            }

            return bitCounter;
        }
    }
}
