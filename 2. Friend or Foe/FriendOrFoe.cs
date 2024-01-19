using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Friend_or_Foe
{
    class FriendOrFoe
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            //string[] expected = { "Ryan", "Mark" };

            foreach(string res in Kata.FriendOrFoe(names))
            {
                Debug.Write(res+ " ");
            }
            Debug.Write("\n");
        }
    }

    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> expected = new List<string>();
            foreach(string name in names)
            {
                if (name.Length == 4)
                {
                    expected.Add(name);
                }
            }
            return expected;
        }
    }
}
