using System;
using System.Collections.Generic;
using System.Linq;

namespace filter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> input = Console.ReadLine().Split(',').ToList();

                foreach (var item in input)
                {
                    if (item.Contains('1') || item.Contains('2') || item.Contains('3') || item.Contains('4') || item.Contains('5') || item.Contains('6') || item.Contains('7') || item.Contains('8') || item.Contains('9') || item.Contains('0'))
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
        }
    }
}
