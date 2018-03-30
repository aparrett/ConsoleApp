using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? birthday = null;
            DateTime date2 = birthday ?? DateTime.Today;
            Console.WriteLine(date2);
        }
    }
}