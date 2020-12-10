using System;
using System.Collections.Generic;

namespace Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string word = Console.ReadLine();

                if (word.Contains('1') || word.Contains('2') || word.Contains('3') || word.Contains('4') || word.Contains('5') || word.Contains('6') || word.Contains('7') || word.Contains('8') || word.Contains('9') || word.Contains('0'))
                {
                    Console.WriteLine("Crazy Input!");

                }
                else if (word.Contains('!') || word.Contains('@') || word.Contains('£') || word.Contains('$') || word.Contains('%') || word.Contains('^') || word.Contains('&') || word.Contains('*') || word.Contains('(') || word.Contains(')') || word.Contains('~') || word.Contains(':') || word.Contains(';'))
                {
                    Console.WriteLine("Crazy Input!");

                }

                else
                {
                    int count = 0;
                    List<char> charList = new List<char>();

                    bool isIsogram = false;

                    foreach (char c in word)
                    {
                        if (!charList.Contains(c)) charList.Add(c);
                        else count++;
                    }

                    if (count > 0) isIsogram = false;
                    else isIsogram = true;

                    Console.WriteLine(isIsogram);
                }
            }
            catch (Exception) { Console.WriteLine("Crazy Input!"); }   

        }
    }
}


