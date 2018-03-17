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
            int a = 1;
            string b = "hello";
            string c = TestClass.ReturnStr(a, s: b);
            Console.WriteLine("The string returned is {0}", c);
        }
    }

    class TestClass
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
        public static string ReturnStr(int i, string s)
        {
            return s;
        }
    }
}
