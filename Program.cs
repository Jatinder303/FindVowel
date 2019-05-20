using System;

namespace FindVowel
{
    // This program is used to find that vowel.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter any Char ");
            char ch = char.Parse(Console.ReadLine());
            String st = ch.ToString().ToLower();
            switch (st)
            {
                case "a":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "e":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "i":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "o":
                    Console.WriteLine(st + " is a vowel");
                    break;
                case "u":
                    Console.WriteLine(st + " is a vowel");
                    break;
                default:
                    Console.WriteLine(st + " is not a vowel");
                    break;

            }
        }
    }
}
