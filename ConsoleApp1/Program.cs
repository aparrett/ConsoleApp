using System;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(5, 20));
            }
        }
    }
}
