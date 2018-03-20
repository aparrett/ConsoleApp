using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            
            Console.WriteLine("index = " + numbers.LastIndexOf(1));
            Console.WriteLine("count = " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            var s = string.Join(" ", numbers);
            Console.WriteLine(s);
        }
    }
}
