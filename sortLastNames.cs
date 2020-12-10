using System;
using System.Collections.Generic;
using System.Linq;

namespace sortLastNames
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<string> names = Console.ReadLine().Split(',').ToList();

                Dictionary<string, string> nameDict = new Dictionary<string, string>();

                foreach (var item in names)
                {
                    var word = item.Trim();
                    var firstNLast = word.Split(new[] { ' ' }, 2);
                    nameDict.Add(firstNLast[1], firstNLast[0]);
                }


                Console.WriteLine();

                foreach (KeyValuePair<string, string> item in nameDict.OrderBy(i => i.Key))
                {
                    Console.WriteLine(item.Value + " " + item.Key);
                }

            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
        }
    }
}
