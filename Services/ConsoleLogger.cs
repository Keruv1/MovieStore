using System;

namespace MovieStore.Services
{
    public class ConseleLogger : ILogger
    {
        public void Write(string massage)
        {
            System.Console.WriteLine("[ConsoleLogger] -", massage);
        }
    }
}