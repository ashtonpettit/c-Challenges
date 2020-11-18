using System;
using System.Text.RegularExpressions;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int strength = 0;

            Regex rgx = new Regex("^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=]).{7,}$");
            Match match = rgx.Match(password);

            if (match.Success)
            {
                strength++;
            }

            if (strength > 0)
            {
                Console.WriteLine("Strong");
            }
            if (strength == 0)
            {
                Console.WriteLine("Weak");
            }
        }
    }
}
