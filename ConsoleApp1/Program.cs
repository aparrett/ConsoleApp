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
            double a = 11.1, b = 14.2;
            int c = 1, d = 3;
            float e = 5, f = 5;
            double result = Sum(a, b);
            int intResult = Sum(c, d);
            float floatResult = Sum(e, f);
            Console.WriteLine($"Double result = {result}. Int result = {intResult}. Float result = {floatResult}.");
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static float Sum(float x, float y)
        {
            return x + y;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
