using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s in args)
            {
                if (CheckPalindrome(s))
                    Console.WriteLine($"{s} -> true");

                else Console.WriteLine($"{s} -> false");
            }
            string nullstring = null;
            CheckPalindrome(nullstring);
        }
        private static bool CheckPalindrome(string s)
        {
            bool CheckLetters(string s)
            {
                int length = s.Length - 1;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(s[i] == s[length-i]))
                        return false;
                }
                return true;
            }

            switch (s)
            {
                case null:
                    throw new ArgumentNullException();

                default:
                    if (s.Length < 2)
                        return true;

                    else return CheckLetters(s);

            }
        }
    }
}
