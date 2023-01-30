using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_smallest_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a series of 5 numbers: ");
            var input = Console.ReadLine();
            var numbers = Array.ConvertAll(input.Split(','), int.Parse).ToList();

            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid list");
            }
            else
            {
                numbers.Sort();
                Console.WriteLine(numbers[0]);
                Console.WriteLine(numbers[1]);
                Console.WriteLine(numbers[2]);
            }
            
        }
    }
}
