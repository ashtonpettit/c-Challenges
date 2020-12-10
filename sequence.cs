using System;

namespace sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                bool isSequence = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = 0; j < numbers.Length - i - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i + 1] != numbers[i] + 1)
                    {
                        isSequence = false;
                        break;
                    }
                    else isSequence = true;
                }

                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.WriteLine(isSequence);
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
        }
    }
}
