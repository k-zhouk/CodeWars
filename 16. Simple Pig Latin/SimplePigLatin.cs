/*
 * https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
 * 
 * Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched
 * 
 * Examples
 * Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
 * Kata.PigIt("Hello world !");     // elloHay orldway !
*/
using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.Simple_Pig_Latin
{
    class SimplePigLatin
    {
        static void Main(string[] args)
        {
            // string testStr = "Pig latin is cool";
            string testStr = "! Hello , wor . ld !";

            string res = PigIt(testStr);

            Debug.WriteLine(String.Format("Test string is: {0,30}", testStr));
            Debug.WriteLine(String.Format("Pig latin string: {0,30}", res));
        }

        public static string PigIt(string str)
        {
            string[] tempStrings = str.Split(' ');

            string tempString= "";
            string finalString= "";

            foreach(string elem in tempStrings)
            {
                if (elem == "!" || elem == "," || elem== ".")
                {
                    tempString = elem;
                }
                else
                {
                    tempString = elem.Substring(1) + elem[0] + "ay";
                }
                finalString += tempString + " ";
            }
            return finalString.Trim(' ');
        }
    }
}
