﻿/*
https://www.codewars.com/kata/54da539698b8a2ad76000228 

Take a Ten Minutes Walk

You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment,
so you decided to take the opportunity to go for a short walk.

The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array
of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter
(direction) and you know it takes you one minute to traverse one city block, so create a function that will return TRUE if the walk the
app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point.
Return FALSE otherwise.

Note: you will always receive a valid array containing a random assortment of direction letters
('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).

 */
using System.Diagnostics;

using System;
using System.Linq;

namespace _9.Take_a_Ten_Minutes_Walk
{
    class TenMinWalk
    {
        static void Main(string[] args)
        {
            string[] testArray1= new string[] { "n", "s", "w", "e", "e", "s", "n", "w" };

            bool res = IsValidWalk(testArray1);
            Debug.WriteLine(res);

            string[] testArray2 = new string[] { "n", "s", "w", "e", "e", "s", "n", "w", "w", "w" };
            res = IsValidWalk(testArray2);
            Debug.WriteLine(res);

            string[] testArray3 = new string[] { "n", "s", "w", "e", "e", "s", "n", "n", "s", "w" };
            res = IsValidWalk(testArray3);
            Debug.WriteLine(res);
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
            {
                return false;
            }
            else if (walk.Where(a=> a.ToLower()=="n").Count()!= walk.Where(a => a.ToLower() == "s").Count())
            {
                return false;
            } else if (walk.Where(a => a.ToLower() == "w").Count()!= walk.Where(a => a.ToLower() == "e").Count())
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
