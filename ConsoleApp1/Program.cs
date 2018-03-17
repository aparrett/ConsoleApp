using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVar = "test";
            Console.WriteLine("This is a {0} message.", myVar);

            string color = "purple";
            switch (color)
            {
                case "green":
                    Console.WriteLine($"Color is {color}");
                    break;

                case "blue":
                    Console.WriteLine($"Color is {color}");
                    break;

                default:
                    Console.WriteLine($"This is the default message");
                    break;
            }
        }
    }
}
