using System;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2, 
        Express = 3
    }

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
            var Wednesday = Weekdays.Wed;
            Console.WriteLine((int)Wednesday);
        }
    }
}
