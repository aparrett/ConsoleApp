using System;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int speedLimit, speed;
            Console.WriteLine("Enter a speed limit");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a speed");
            speed = Convert.ToInt32(Console.ReadLine());

            if (speed <= speedLimit)
            {
                Console.WriteLine("Thank you for obeying the law");
                return;
            }

            int speedDifference = speed - speedLimit;
            int points = speedDifference / 5;

            if (points > 12)
                Console.WriteLine("License suspended");

        }
    }
}
