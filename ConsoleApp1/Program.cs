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
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\file.txt");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
    }

    public class Calculator
    {
        public int Divide(int numerator, int denomenator)
        {
            return numerator / denomenator;
        }
    }
}