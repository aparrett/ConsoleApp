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
                var api = new YouTubeApi();
                var videos = api.GetVideos("Anthony");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Video
    {
        public string Title { get; set; }
    }

    class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Oops a Youtube error occured.");
            }
            catch (Exception e)
            {
                throw new YouTubeException("Could not fetch Youtube videos.", e);
            }

            return new List<Video>();
        }
    }

    class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            :base(message, innerException)
        {
            
        }
    }
}