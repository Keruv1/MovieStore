using System;

namespace MovieStore.Services 
{
    public class DBLogerr : ILogger
    {
        public void Write(string massage)
        {
            Console.WriteLine("[DBLogerr] -", massage);
        }
    }
}