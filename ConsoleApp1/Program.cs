using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IPainter
    {
        void Paint();
    }

    public class Anthony : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Paint stuff");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
