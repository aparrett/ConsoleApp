using System;

namespace ConsoleApp1.Fundamentals
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
            if (number == 0 || number == null)
                throw new ArgumentNullException();
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString(); 
        }
    }
}