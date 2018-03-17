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
            int a = 5;
            string b = "test";
            int c;
            string d;
            Test.ReturnRefValues(ref a, ref b);
            Test.ReturnOutValues(out c, out d);
            Console.WriteLine($"Value a is {a}, value b is {b}, value c is {c} and value d is {d}.");
        }
    }

    class Test
    {
        public static void ReturnOutValues(out int i, out string s)
        {
            i = 1;
            s = "one";
        }
        public static void ReturnRefValues(ref int i, ref string s)
        {
            i = 20;
            s = "overwritten";
        }
    }
}
