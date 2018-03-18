using System;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Anthony";
            p.LastName = "Parrett";
            p.SayHello();

            int x = 7;
            int y = 4;
            int z = Calculator.Add(x, y);
            Console.WriteLine($"{x} + {y} = {z}");
        }

    }
}
