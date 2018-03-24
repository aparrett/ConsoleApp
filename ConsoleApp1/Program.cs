using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Anthony";
            Console.WriteLine(cookie["name"]);

            var dictionary = new Dictionary<string, string>();
            dictionary["name"] = "Anthony";
            dictionary["name2"] = "Meagan";
            Console.WriteLine(dictionary["name"] + dictionary["name2"]);
        }
    }
}
