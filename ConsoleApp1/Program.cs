using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"C:\file.txt"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sorry, that file could not be found.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
        }
    }
}