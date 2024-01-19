/*
 
https://www.codewars.com/kata/525f50e3b73515a6db000b83/

Create Phone Number

Write a function that accepts an array of 10 integers (between 0 and 9),
that returns a string of those numbers in the form of a phone number.

Example
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
 
 */

using System.Diagnostics;

using System;
using System.Text;

namespace _8.Create_Phone_Number
{
    class CreatePhoneNumberKata
    {
        public static void Main(string[] args)
        {
            string resStr = String.Empty;

            int[] intTestArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            resStr = CreatePhoneNumber(intTestArray1);
            Debug.WriteLine("Resulting phone number: "+ resStr);

            int[] intTestArray2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            resStr = CreatePhoneNumber(intTestArray2);
            Debug.WriteLine("Resulting phone number: " + resStr);
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int number in numbers)
            {
                sb.Append(number);
            }

            sb.Insert(0, '(');
            sb.Insert(4, ')');
            sb.Insert(5, ' ');
            sb.Insert(9, '-');

            return sb.ToString();
        }

    }
}
