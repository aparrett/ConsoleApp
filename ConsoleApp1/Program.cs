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
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            Console.WriteLine("Do stuff");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.TimeElapsed);
        }
    }
}
