using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvowel = true;

            while (isvowel)
            {
                Console.Write("Type in a vowel: ");
                string check = Console.ReadLine().ToLower();

                if (check == "a" || check == "e" || check == "i" || check == "o" || check == "u")
                    Console.WriteLine("\nOK!\n");
                else if (check == "!")
                    isvowel = false;
                else
                    Console.WriteLine("\nTHAT'S NOT A VOWEL!\n");
            }
        }
    }
}
