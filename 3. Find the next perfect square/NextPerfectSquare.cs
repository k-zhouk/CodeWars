using System;
using System.Diagnostics;

namespace _3.Find_the_next_perfect_square
{
    class NextPerfectSquare
    {
        static void Main(string[] args)
        {
            long testNum1 = 155;                        // -1
            long testNum2 = 121;                        // 144
            long testNum3 = 625;                        // 676
            long testNum4 = 319225;                     // 320356
            long testNum5 = 15241383936;                // 15241630849
            long testNum6 = 4503599627370497;           // -1

            long res;

            res = FindNextSquare(testNum1);
            Debug.WriteLine("Testing "+ nameof(testNum1)+ "="+ testNum1+ ". Result is: {0}", res);

            res = FindNextSquare(testNum2);
            Debug.WriteLine("Testing " + nameof(testNum2) + "=" + testNum2 + ". Result is: {0}", res);

            res = FindNextSquare(testNum3);
            Debug.WriteLine("Testing " + nameof(testNum3) + "=" + testNum3 + ". Result is: {0}", res);

            res = FindNextSquare(testNum4);
            Debug.WriteLine("Testing " + nameof(testNum4) + "=" + testNum4 + ". Result is: {0}", res);

            res = FindNextSquare(testNum5);
            Debug.WriteLine("Testing " + nameof(testNum5) + "=" + testNum5 + ". Result is: {0}", res);

            res = FindNextSquare(testNum6);
            Debug.WriteLine("Testing " + nameof(testNum6) + "=" + testNum6 + ". Result is: {0}", res);

        }

        public static long FindNextSquare(long num)
        {
            if (num < 0)
            {
                return -1;
            }

            long longRoot = Convert.ToInt64(Math.Sqrt(num));
            
            if (longRoot * longRoot == num)
            {
                return (++longRoot * longRoot++);
            }
            else
            {
                return -1;
            }
        }
    }
}
