using System;

namespace OwodaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            process useIt = new process();

            Console.WriteLine("Welcome to OwodaApp");
            
            Console.WriteLine (useIt.Ticketing());

        }
    }
}
