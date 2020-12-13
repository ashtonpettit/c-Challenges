using System;
using System.Collections.Generic;

namespace monster_part_2
{
    class Program
    {
        static void Method7(string a, string b)
        {
            bool isAnagram = false;
            int count = 0;

            foreach (char item in a)
            {
                foreach (char letter in b)
                {
                    if(letter == item)
                    {
                        count++;
                    }
                }
            }
            if (count == a.Length) isAnagram = true;
            Console.WriteLine(isAnagram);
        }

        static void Method8(string a)
        {
            string text = a.Replace(" ", string.Empty);
            char[] word = text.ToCharArray();
            char[] alphabet = {'!','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k','l','m','n','o'
            ,'p','q','r','s','t','u','v','w','x','y','z'};
            List<int> numList = new List<int>();
            foreach (char item in word)
            {
                int v = Array.IndexOf(alphabet, item);
                numList.Add(v);
            }
            int answer = 0;

            foreach (var item in numList)
            {
                Console.Write(item + " + ");
                answer = answer + item;
            }
            Console.WriteLine("= " + answer);        
        }

        static void Method9(int a, int b)
        {
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            List<int> final = new List<int>();
            int answer = 0;
            for (int i = a; i > 0; i--)
            {
                answer = a / i;
                if (a % i == 0) aList.Add(answer);
            }
            for (int j = b; j > 0; j--)
            {
                answer = b / j;
                if (b % j == 0) bList.Add(answer);
            }
            answer = 1;
            foreach (var item in aList)
            {
                answer = answer * item;
                if (answer <= a) final.Add(item);
            }
            answer = 1;
            foreach (var item in bList)
            {
                answer = answer * item;
                if (answer <= b) final.Add(item);
            }
            answer = 1;
            foreach (var item in final)
            {
                answer = answer * item;
            }
            Console.WriteLine(answer);
        }

        static void Method10(int a, int b)
        {
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            List<int> final = new List<int>();
            int answer = 0;
            for (int i = a; i > 0; i--)
            {
                answer = a / i;
                if (a % i == 0) aList.Add(answer);
            }
            for (int j = b; j > 0; j--)
            {
                answer = b / j;
                if (b % j == 0) bList.Add(answer);
            }
            foreach (var item in aList)
            {
                foreach (var num in bList)
                {
                    if (item == num) final.Add(item);
                }
            }
            int[] finalArray = final.ToArray();
            Console.WriteLine(final[finalArray.Length - 1]);
        }
        static void Main(string[] args)
        {

            string method = Console.ReadLine();

            switch (method)
            {
                case "7":
                    string input = Console.ReadLine();
                    string text = Console.ReadLine();
                    Method7(input, text);
                    break;
                case "8":
                    string inputTwo = Console.ReadLine();
                    Method8(inputTwo);
                    break;
                case "9":
                    int num = Convert.ToInt32(Console.ReadLine());
                    int numTwo = Convert.ToInt32(Console.ReadLine());
                    Method9(num, numTwo);
                    break;
                case "10":
                    int intONe = Convert.ToInt32(Console.ReadLine());
                    int intTwo = Convert.ToInt32(Console.ReadLine());
                    Method10(intONe, intTwo);
                    break;
            }
                
        }
    }
}
