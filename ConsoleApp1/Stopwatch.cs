using System;

namespace ConsoleApp1
{
    public class Stopwatch
    {
        private bool Started { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public TimeSpan TimeElapsed
        {
            get
            {
                return EndTime - StartTime;
            }
        }

        public void Start()
        {
            if(Started == true)
                throw new InvalidOperationException("Stopwatch already started.");

            Started = true;
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if(Started == false)
                throw new InvalidOperationException("Stopwatch already stopped.");

            Started = false;
            EndTime = DateTime.Now;
        }
    }
}