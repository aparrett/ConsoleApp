using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void UsePoints()
        {
            try
            {
                var point1 = new Point(5, 7);
                var point2 = new Point(10, 10);
                point1.Move(null);
                Console.WriteLine($"{point1.X}, {point1.Y}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(25, 13));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
        }
    }
}
