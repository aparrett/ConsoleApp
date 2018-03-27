using System;

namespace ConsoleApp1
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Save photo.");
        }
    }
}