/*
https://www.codewars.com/kata/517abf86da9663f1d2000003

Complete the method/function so that it converts dash/underscore delimited words into camel casing.
The first word within the output should be capitalized only if the original word was capitalized
(known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.

Examples

"the-stealth-warrior" gets converted to "theStealthWarrior"
"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

 */

using System.Diagnostics;

using System;
using System.Text;

namespace _7.Convert_string_to_camel_case
{
    class StringToCamelCase
    {
        static void Main(string[] args)
        {
            string testStr1 = "the-stealth-warrior";
            string resStr = ToCamelCase(testStr1);
            Debug.WriteLine("Test trsing:" + testStr1 + ". Converted string: " + resStr);
            
            string testStr2 = "The_Stealth_Warrior";
            resStr = ToCamelCase(testStr2);
            Debug.WriteLine("Test trsing:" + testStr2 + ". Converted string: " + resStr);
        }

        public static string ToCamelCase(string str)
        {
            string[] strArray = str.Split('-', '_');

            for (int i = 1; i < strArray.Length; ++i)
            {
                char[] charArray = strArray[i].ToCharArray();
                charArray[0]= Char.ToUpper(strArray[i][0]);
                strArray[i] = new String(charArray);
            }

            string finalStr = String.Join("", strArray);

            return finalStr;
        }
    }
}
