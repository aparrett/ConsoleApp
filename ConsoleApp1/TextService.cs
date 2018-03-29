using System;

namespace ConsoleApp1
{
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Text sent by Text Service." + e.Video.Title);
        }
    }
}