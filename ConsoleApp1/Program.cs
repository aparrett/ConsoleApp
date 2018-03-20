using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            var yesterday = today.AddDays(-1);
            var tomorrow = today.AddDays(1);
            var now = DateTime.Now;

            Console.WriteLine(today);
            Console.WriteLine(yesterday);
            Console.WriteLine(tomorrow);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd"));
        }
    }
}
