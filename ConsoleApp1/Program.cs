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
            int x = 6, y = 0;
            Console.WriteLine(Divide(x, y));
        }
        static int Divide(int x, int y)
        {
            int result = 0;

            try
            {
                result = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            return result;
        }
    }
}
