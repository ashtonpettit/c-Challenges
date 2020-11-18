using System;
using System.Linq;

namespace Palindrome_check
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;

            bool isPalindrome = false;

            char[] charArray = word.ToCharArray();
            char[] revCharArray = charArray.Reverse().ToArray();
            int sameLetter = 0;
            for (int i = 0; i < wordLength; i++)
            {
                if (charArray[i] == revCharArray[i])
                {
                    sameLetter++;
                }
            }
            if (sameLetter == wordLength)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
