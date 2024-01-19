/*
Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed
(Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
Spaces will be included only when more than one word is present.

Examples:
spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
*/

using System.Diagnostics;

using System;


namespace _4.Stop_gninnipS_My_sdroW
{
    class Stop
    {
        static void Main(string[] args)
        {
            string testStr1 = "Hey fellow warriors";
            Debug.WriteLine(SpinWords(testStr1));

            string testStr2 = "This is a test";
            Debug.WriteLine(SpinWords(testStr2));

            string testStr3 = "This is another test";
            Debug.WriteLine(SpinWords(testStr3));
        }

        public static string SpinWords(string sentence)
        {
            string resString = "";

            string[] subStrings = sentence.Split(' ');
            foreach (string subString in subStrings)
            {
                if (subString.Length >= 5)
                {
                    string reversedStr = "";
                    for (int i=0; i< subString.Length; i++)
                    {
                        reversedStr += subString[subString.Length - i - 1];
                    }

                    resString += reversedStr + " ";
                }
                else
                {
                    resString += subString+ " ";
                }
            }

            return resString.Remove(resString.Length - 1);
        }
    }
}
