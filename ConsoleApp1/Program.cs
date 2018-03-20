using System;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNum = random.Next(1, 10);
            Console.WriteLine("Please enter a number");
            var userAnswer = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i < 4; i++)
            {
                if (userAnswer == randomNum)
                {
                    Console.WriteLine("You win!");
                    return;
                }
                else
                {
                    Console.WriteLine("Sorry. Please try again.");
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("You lose");
        }
    }
}
