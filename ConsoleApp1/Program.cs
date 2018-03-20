using System;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var numbers2 = new[] {4, 5, 6};

            // Length.
            Console.WriteLine("Length:" + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 5);
            Console.WriteLine(index);

            // Clear()
            // Sets values to 0 starting at 2nd parameter, and setting however many values are given in the 3rd
            // parameter.
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            // Copies values from first array to second array, overwriting
            // the original values.
            Array.Copy(numbers, numbers2, 2);
            Console.WriteLine("Copy");
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }

            numbers2[0] = 10;

            // Sort()
            Console.WriteLine("Sort");
            Array.Sort(numbers2);
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Console.WriteLine("Reverse");
            Array.Reverse(numbers2);
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
