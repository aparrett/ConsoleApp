using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sorry, cannot divide by zero.");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Sorry, an unexpected arithmetic error occured.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
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