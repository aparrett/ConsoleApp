using System;

namespace ConsoleApp1
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applied brightness to photo.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applied contrast to photo");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resized the photo.");
        }
    }
}