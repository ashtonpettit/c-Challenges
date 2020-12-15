using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    class Program
    {
        static void Method1(string a) 
        {
            int year = Convert.ToInt32(a);
            bool leapYear = false;
            while (leapYear == false)
            {
                if (year % 4 != 0) leapYear = false;      
                else if (year % 4 == 0)
                {
                    if (year % 100 != 0) leapYear = true;            
                    else if (year % 100 == 0)
                    {
                        if (year % 400 != 0) leapYear = false;
                        else if (year % 400 == 0)
                        { leapYear = true; }
                    }
                }
                if(leapYear == false) year++;
            }
            Console.WriteLine(year);
        }
        static void Method2(string a) 
        {
            char[] numbers = a.ToCharArray();
            while (numbers.Length != 1)
            {
                int answer = 0;
                foreach (var item in numbers)
                {
                    int num = int.Parse(item.ToString());
                    answer = answer + num;
                }
                a = answer.ToString();
                numbers = new char[] { };
                numbers = a.ToCharArray();
            }
            Console.WriteLine(a);
        }
        static void Method3(int a) 
        {
            int result = 0;
            int num = 0;
            int num2 = 1;
            bool isFibo = false;
            while (result < a)
            {
                result = num + num2;
                num = num2;
                num2 = result;

            }

            if (result == a) isFibo = true;

            Console.WriteLine(isFibo);
        }

        static void Method4(int a)
        {
            int num = a;
            int factor = 0;
            bool isPrime = false;
            while (isPrime == false)
            {
                for (double i = num; i > 0; i--)
                {

                    if (num % i == 0)
                    {
                        factor++;
                    }
                }
                if (factor < 3)
                {
                    isPrime = true;
                }
                else
                {
                    num++;
                    factor = 0;
                }
            }
            Console.WriteLine(num);
        }

        static void Method5(string a)
        {
            char[] c = a.ToCharArray();
            char[] cUpper = a.ToUpper().ToCharArray();
            char[] cLower = a.ToLower().ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == cUpper[i])
                {
                    c[i] = cLower[i];
                }
                else if (c[i] == cLower[i])
                {
                    c[i] = cUpper[i];
                }
            }
            foreach (var item in c)
            {
                Console.Write(item);
            }
        }

        static void Method6(string a)
        {
            string text = a.Replace(" ", string.Empty);
            int wordLength = text.Length;
            bool isPalindrome = false;
            char[] charArray = text.ToCharArray();
            char[] revCharArray = charArray.Reverse().ToArray();
            int sameLetter = 0;
            for (int i = 0; i < wordLength; i++)
            {
                if (charArray[i] == revCharArray[i])
                {
                    sameLetter++;
                }
            }
            if (sameLetter == wordLength)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            Console.WriteLine(isPalindrome);
        }

        static void Method7(string a, string b)
        {
            bool isAnagram = false;
            int count = 0;

            foreach (char item in a)
            {
                foreach (char letter in b)
                {
                    if (letter == item)
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
                case "1":
                    string input = Console.ReadLine();
                    Method1(input); break;
                case "2":
                    string i = Console.ReadLine();
                    Method2(i); break;
                case "3":
                    int inputint = Convert.ToInt32(Console.ReadLine());
                    Method3(inputint); break;
                case "4":
                    int j = Convert.ToInt32(Console.ReadLine());
                    Method4(j); break;
                case "5":
                    string caseString = Console.ReadLine();
                    Method5(caseString); break;
                case "6":
                    string text = Console.ReadLine();
                    Method6(text); break;
                case "7":
                    string textOne = Console.ReadLine();
                    string textTwo = Console.ReadLine();
                    Method7(textOne, textTwo);
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
                default:
                    Console.WriteLine("Crazy Input!");
                    break;
            }


            Console.ReadLine();
        }
    }
}
