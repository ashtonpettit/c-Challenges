using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace writing
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();
                string[] words = Console.ReadLine().Split(' ');

                StreamReader reader = File.OpenText(filename);
                string[] text = reader.ReadToEnd().Split(' ');
                int count = 0;
                Dictionary<string, int> dict = new Dictionary<string, int>();

                Array.Sort(words);
                words.ToList();
                int num = 0;


                foreach (var item in words)
                {
                    if (!dict.ContainsKey(item))
                    {
                        foreach (var word in text)
                        {
                            string newWord = word.Replace("\r\n", string.Empty);
                            if (newWord.Contains(item + '.') || newWord.Contains(item + ',') || newWord.Contains(item + ":") || item == newWord)
                            {
                                count++;
                            }
                            else if (word.Contains(item) && word.Length == item.Length)
                            {
                                count++;
                            }
                        }
                        dict.Add(item, count);
                        count = 0;
                    }
                }

                List<string> notUsed = new List<string>();

                foreach (KeyValuePair<string, int> word in dict)
                {
                    if (word.Value == 0)
                    {
                        notUsed.Add(word.Key);
                    }
                }

                foreach (KeyValuePair<string, int> item in dict)
                {
                    if (item.Value != 0)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }

                Console.Write("Not Used: ");
                foreach (var item in notUsed)
                {
                    Console.Write(item + " ");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input");
            }

        }
    }
}
