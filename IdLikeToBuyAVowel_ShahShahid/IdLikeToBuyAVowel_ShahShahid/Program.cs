using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdLikeToBuyAVowel_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and I'll tell you how many vowels there are.");
            string input = Console.ReadLine();

                string vowels = "aeiouAEIOU";
                int vowelCount = 0;
                for (int x = 0; x < input.Length; x++)
                {
                    if (vowels.Contains(input[x]))
                    {
                        vowelCount++;
                    }
                }
            Console.WriteLine($"There are {vowelCount} number of vowels in '{input}'.");
            Console.ReadLine();
        }
    }
}
