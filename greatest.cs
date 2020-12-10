using System;
using System.Collections.Generic;
using System.Linq;

namespace greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int[] sequence = new int[] { };
                List<int> intList = new List<int>();

                for (int i = 0; i < num; i++)
                {
                    sequence = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Array.Sort(sequence);
                    int n = sequence[sequence.Length - 1];
                    intList.Add(n);
                }

                foreach (var item in intList.OrderBy(i => i.ToString()))
                {
                    Console.Write(item + " ");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
