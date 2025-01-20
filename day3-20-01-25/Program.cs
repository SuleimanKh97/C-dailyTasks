using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_20_01_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountVowels();
        }

        static void CountVowels()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of vowels: " + count);
        }
        
    }
}
