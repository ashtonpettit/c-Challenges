using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Emordnilap
{
    class Program
    {
       public static string Reverse(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main(string[] args)
        {

            try
            {
                string word = Console.ReadLine();
                bool match = Regex.IsMatch(word, @"^[a-zA-Z]+$");
                if (match == true)
                {
                    string reverseWord = "";

                    StreamReader reader = File.OpenText("english.txt");

                    string fullText = reader.ReadToEnd();

                    bool WordExists = false;
                    bool isEmordnilap = false;

                    reverseWord = Reverse(word);

                    if (fullText.Contains(reverseWord)) WordExists = true;

                    else WordExists = false;

                    if (WordExists == true)
                    {
                        if (reverseWord == word)
                        {
                            isEmordnilap = false;
                        }
                        else
                        {
                            isEmordnilap = true;
                        }
                    }
                    else isEmordnilap = false;



                    Console.WriteLine(reverseWord);
                    Console.WriteLine(isEmordnilap);
                }

                else
                {
                    Console.WriteLine("Crazy Input!");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }

           
            
            
        }
    }
}
