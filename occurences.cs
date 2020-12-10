using System;
using System.Collections.Generic;
using System.Linq;

namespace occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> fruits = Console.ReadLine().Split(' ').ToList();
                int count = 0;
                Dictionary<string, int> fruitDict = new Dictionary<string, int>();

                foreach (var item in fruits)
                {
                    if (!fruitDict.Keys.Contains(item))
                    {
                        count = 0;
                        foreach (var fruit in fruits)
                        {
                            if (item == fruit)
                            {
                                count++;
                            }
                        }
                        fruitDict.Add(item, count);
                    }
                }

                foreach (KeyValuePair<string, int> item in fruitDict.OrderBy(i => i.Key))
                {
                    Console.WriteLine(item.Key + ":" + " " + item.Value);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
