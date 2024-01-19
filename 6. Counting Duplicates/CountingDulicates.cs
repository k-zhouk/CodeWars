/*
Count the number of Duplicates

Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits
that occur more than once in the input string. The input string can be assumed to contain only alphabets
(both uppercase and lowercase) and numeric digits.

Example

"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice

*/
using System.Diagnostics;

using System;
using System.Linq;

namespace _6.Counting_Duplicates
{
    class CountingDulicates
    {
        static void Main(string[] args)
        {
            string testString1 = "abcde";
            Debug.WriteLine(nameof(testString1) + ": " + DuplicateCount(testString1));

            string testString2 = "aabbcde";
            Debug.WriteLine(nameof(testString2) + ": " + DuplicateCount(testString2));

            string testString3 = "aabBcde";
            Debug.WriteLine(nameof(testString3) + ": " + DuplicateCount(testString3));

            string testString4 = "indivisibility";
            Debug.WriteLine(nameof(testString4) + ": " + DuplicateCount(testString4));

            string testString5 = "Indivisibilities";
            Debug.WriteLine(nameof(testString5) + ": " + DuplicateCount(testString5));

            string testString6 = "aA11";
            Debug.WriteLine(nameof(testString6) + ": " + DuplicateCount(testString6));

            string testString7 = "ABBA";
            Debug.WriteLine(nameof(testString7) + ": " + DuplicateCount(testString7));
        }
        
        public static int DuplicateCount(string str)
        {
            if (System.String.IsNullOrEmpty(str))
            {
                return 0;
            }

            string lowerCaseStr = str.ToLower();
            var uniqQuery = lowerCaseStr.Distinct<char>();
            
            int totalCounter = default;
            foreach( char sym in uniqQuery)
            {
                var query = lowerCaseStr.Where(a => a.Equals(sym));
                if (query.Count() > 1)
                {
                    totalCounter++;
                 }
            }
            return totalCounter;
        }
    }
}
