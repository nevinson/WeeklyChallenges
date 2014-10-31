using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read text input, remove vowels and set the first letter to uppercase
            var input = Console.ReadLine();
            var vowels = "AaEeIiOoUu";
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a sentence to continue\n");
            }
            else
            {
                input = new string(input.Where(m => !vowels.Contains(m)).ToArray());
                input = input.First().ToString().ToUpper() + input.Substring(1);

                Console.WriteLine($"Result after vowels removed: {input}");
            }

            Console.ReadLine();
        }
    }
}
