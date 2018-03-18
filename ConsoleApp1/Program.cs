using System;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        enum Weekdays
        {
            Sun = 0,
            Mon = 1,
            Tues = 2,
            Wed = 3,
            Thurs = 4,
            Fri = 5,
            Sat = 6
        }

        static void Main(string[] args)
        {
            var s = "Sun";
            var WeekDay = (Weekdays)Enum.Parse(typeof(Weekdays), s);
        }
    }
}
