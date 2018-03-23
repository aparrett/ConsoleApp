using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Anthony");
            person.Introduce("Meagan");
        }
    }
}
