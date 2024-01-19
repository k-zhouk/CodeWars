using System;
using System.Diagnostics;


namespace You_re_a_square_
{
    class Square
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("isSquare(-1): "+ isSquare(-1));
            Debug.WriteLine("isSquare(3): " + isSquare(3));
            Debug.WriteLine("isSquare(4): " + isSquare(4));
            Debug.WriteLine("isSquare(25): " + isSquare(25));
            Debug.WriteLine("isSquare(26): " + isSquare(26));
        }

    static bool isSquare(int n)
        {
            if (n < 0)
            {
                return false;
            }
            else
            {
                int tmp = (int)Math.Sqrt(n);
                if (tmp * tmp == n)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
