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
            int[] myArr = { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(" ", myArr));

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }

            foreach (int myInt in myArr)
            {
                Console.WriteLine(myInt);
            }
        }
    }
}
