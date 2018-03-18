using System;

namespace ConsoleApp1
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }
    }
}