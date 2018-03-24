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
            var person = new Person(new DateTime(1992, 7, 7));
            Console.WriteLine(person.Age);
        }
    }
}
