using System;

namespace ConsoleApp1
{
    internal class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car constructor is called. " + registrationNumber);
        }
    }
}