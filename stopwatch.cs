using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        bool running = true;

        Console.WriteLine("Simple Stopwatch");
        Console.WriteLine("Commands: START, STOP, RESET, EXIT");

        while (running)
        {
            Console.Write("Enter command: ");
            string command = Console.ReadLine().ToUpper();

            switch (command)
            {
                case "START":
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                        Console.WriteLine("Stopwatch started!");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is already running.");
                    }
                    break;

                case "STOP":
                    if (stopwatch.IsRunning)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Stopped at: {stopwatch.Elapsed}");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is not running.");
                    }
                    break;

                case "RESET":
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset!");
                    break;

                case "EXIT":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid command. Use START, STOP, RESET, EXIT.");
                    break;
            }
        }
    }
}
