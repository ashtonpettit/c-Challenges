using System;
using System.Collections.Generic;

namespace UniqueWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();

            List<string> unqWordsList = new List<string>();

            foreach (var item in words)
            {
                if (!unqWordsList.Contains(item)) 
                {
                    unqWordsList.Add(item);
                }
            }

            string[] unqWords = unqWordsList.ToArray();
            int num = 0;
            int numTwo = 1;

            for (int i = 0; i < unqWords.Length; i++)
            {
                for (int j = 0; j < unqWords.Length - i - 1; j++)
                {
                    var inputOne = unqWords[j].Substring(num, 1);
                    var inputTwo = unqWords[j + 1].Substring(num, 1);

                    char letterOne = char.Parse(inputOne);
                    char letterTwo = char.Parse(inputTwo);

                    int asciiOne = (int)letterOne;
                    int asciiTwo = (int)letterTwo;

                    if (asciiOne > asciiTwo)
                    {
                        string temp = unqWords[j];
                        unqWords[j] = unqWords[j + 1];
                        unqWords[j + 1] = temp;
                    }
                    else if (asciiOne == asciiTwo)
                    {
                        while (asciiOne == asciiTwo)
                        {
                            numTwo++;
                            inputOne = unqWords[j].Substring(numTwo, 1);
                            inputTwo = unqWords[j + 1].Substring(numTwo, 1);

                            letterOne = char.Parse(inputOne);
                            letterTwo = char.Parse(inputTwo);

                            asciiOne = (int)letterOne;
                            asciiTwo = (int)letterTwo;
                            if (asciiOne > asciiTwo)
                            {
                                string temp = unqWords[j];
                                unqWords[j] = unqWords[j + 1];
                                unqWords[j + 1] = temp;
                            }

                        }
                    }
                    num = 0;
                    numTwo = 1;
                }
            }


            foreach (var item in unqWords)
            {
                Console.Write(item + " ");
            }
        }
    }
}
