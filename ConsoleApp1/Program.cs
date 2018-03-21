using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Anthony Parrett ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("To Upper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("To Lower: '{0}'", fullName.Trim().ToLower());
            Console.WriteLine("To Upper: '{0}'", fullName.Trim().ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: {0}. Last Name: {1}.", firstName.Trim(), lastName.Trim());

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: {0}. Last Name: {1}.", names[0], names[1]);

            var newFullName = fullName.Replace("Parrett", "Parrettiasdf");
            Console.WriteLine(newFullName);

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
