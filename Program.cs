using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UbbiDubbi
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] character = input.ToCharArray();

            List<string> letters = new List<string>();

            foreach (var item in character)
            {
                if (item == 'a'|| item == 'e' || item == 'i' || item == 'o' || item == 'u' || item == 'y')
                {
                    letters.Add("ub" + item.ToString());
                }
                else
                {
                    letters.Add(item.ToString());
                }  
            }

            foreach (string letter in letters)
            {
                Console.Write(letter.ToString());
            }
            
        }
    }
}
